using ServiceStation.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Documents;
using Word = Microsoft.Office.Interop.Word;
using RuDateAndMoneyConverter;

namespace ServiceStation.PrintDocument
{
    internal class AcceptanceTransferOwnershipCertificate : Document
    {
        internal AcceptanceTransferOwnershipCertificate(int numberApplication) : base(numberApplication, Directory.GetCurrentDirectory() + @"\DocumentTemplates\AcceptanceTransferOwnershipCertificate.dotx") { }


        internal override void Load()
        {
            try
            {
                WordDocument = WordOpen(directory);

                List<Guid> reasonCustomerID = new List<Guid>();
                decimal sumRepair = 0;
                decimal amountMaterialsCustomer = 0;
                decimal sumMaterialsCustomer = 0;

                string powerOfattorneyInfo = null;

                using (var context = new DbSSContext())
                {
                    var applicationInfo = context.Application.Where(a => a.Number == NumberApplication).Select(a => new
                    {
                        a.Number,
                        a.Date,
                        ID_contractor = a.Car.Contractor.ID,
                        ID_contactPerson = a.PowerOfAttorney.ID_contactPerson == null ? null : (Guid?)a.PowerOfAttorney.ID_contactPerson,

                        Contractor = a.Car.Contractor.ShortName,
                        a.Car.Contractor.Address,
                        Phone = a.Car.Contractor.Phone,

                        Model = a.Car.Model.Name,
                        a.Car.VIN,
                        a.Car.LicensePlate,
                        a.Car.NumberBody,
                        a.Car.Price,
                        a.Car.Mileage,
                        a.Car.Color,
                        a.Car.Year,

                        ContactPerson = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.FFP) ? null : a.PowerOfAttorney.ContactPerson.FFP,
                        PhoneContactPerson  = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.Phone) ? null : a.PowerOfAttorney.ContactPerson.Phone,
                        AddressContactPerson = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.Address) ? null : a.PowerOfAttorney.ContactPerson.Address,

                        PowerOfAttorneyNumber = string.IsNullOrEmpty(a.PowerOfAttorney.Number) ? null : a.PowerOfAttorney.Number,
                        PowerOfAttorneyDate = a.PowerOfAttorney.Date == null ? null : (DateTime?)a.PowerOfAttorney.Date,

                        Employee = a.Employee.FFP,
                        a.FirstControlTime,
                        a.SecondControlTime,
                        a.Type,
                        //a.Readiness,
                        //a.Extradition,

                    }).First();

                    var optionInfo = context.OptionCustomer.Where(oc => oc.Number == NumberApplication).OrderBy(oc => oc.Option.ShortName).Select(oc => oc.Option.ShortName).ToList();

                    Word.Table optionTable = WordDocument.Tables[2];
                    optionTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitFixed);

                    for (int i = 1; i <= optionInfo.Count; i++)
                    {
                        optionTable.Rows.Add();

                        if (i == 1)
                            SetFontRow(optionTable.Rows[i + 1]);

                        optionTable.Rows[i + 1].Cells[1].Range.Text = optionInfo[i - 1].ToString();
                    }

                    var repairInfo = context.ReasonCustomer.Where(rc => rc.Number == NumberApplication).Select(rc => new
                    {
                        rc.ID,
                        rc.Reason.ShortName,
                        rc.Reason.Type,
                        Price =

                        (rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)) == null ? 0

                        : rc.Material.Where(m => m.Customer == false).Sum(m => (m.Amount == null ? 0 : m.Amount) * (m.Price == null ? 0 : (decimal?)m.Price)))


                        +


                        (rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)) == null ? 0


                        : rc.Work.Sum(w => (w.Amount == null ? 0 : (int?)w.Amount) * (w.NormOfTime == null ? 0 : w.NormOfTime) * (w.WorkingHour.Price == null ? 0 : w.WorkingHour.Price)))

                    }).OrderBy(rc => new { rc.ShortName }).ToList();

                    Word.Table reairTable = WordDocument.Tables[3];
                    reairTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitFixed);

                    for (int i = 1; i <= repairInfo.Count; i++)
                    {
                        reairTable.Rows.Add();

                        var currentRow = reairTable.Rows[i + 1];

                        if (i == 1)
                        {
                            SetFontRow(currentRow);
                            SetFontCell(currentRow.Cells[3], Word.WdParagraphAlignment.wdAlignParagraphRight, 0);

                        }


                        var repair = repairInfo[i - 1];

                        currentRow.Cells[1].Range.Text = repair.ShortName;
                        currentRow.Cells[2].Range.Text = repair.Type;
                        currentRow.Cells[3].Range.Text = repair.Price.ToString();

                        sumRepair += (decimal)repair.Price;
                        reasonCustomerID.Add(repair.ID);
                    }

                    reairTable.Rows.Add();

                    int rowCount = reairTable.Rows.Count;

                    object begCell = reairTable.Cell(rowCount, 1).Range.Start;
                    object endCell = reairTable.Cell(rowCount, 2).Range.End;

                    WordDocument.Range(ref begCell, ref endCell).Cells.Merge();

                    var repairTotalRow = reairTable.Rows[rowCount];

                    repairTotalRow.Cells[1].Range.Font.Bold = 1;
                    repairTotalRow.Cells[1].Range.Text = "Итого:";
                    repairTotalRow.Cells[2].Range.Text = sumRepair.ToString("0.00");

                    var materialCustomerInfo = context.Material.Where(m => m.Customer == true && reasonCustomerID.Contains(m.ID_reasonCustomer)).Select(m => new
                    {
                        Material = m.Nomenclature.ShortName,
                        m.Amount,
                        Unit = m.Nomenclature.Unit.Name,
                        m.Price,
                        Sum = m.Amount * m.Price
                    }).OrderBy(m => new { m.Material }).ToList();


                    Word.Table materialCustomerTable = WordDocument.Tables[4];
                    materialCustomerTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitFixed);


                    for (int i = 1; i <= materialCustomerInfo.Count; i++)
                    {
                        materialCustomerTable.Rows.Add();

                        if (i == 1)
                            SetParameterNomenclatureRow(materialCustomerTable);

                        var materialCustomer = materialCustomerInfo[i - 1];
                        var currentRow = materialCustomerTable.Rows[i + 1];

                        currentRow.Cells[1].Range.Text = materialCustomer.Material;
                        currentRow.Cells[2].Range.Text = materialCustomer.Amount.ToString();
                        currentRow.Cells[3].Range.Text = materialCustomer.Unit;
                        currentRow.Cells[4].Range.Text = materialCustomer.Price.ToString();
                        currentRow.Cells[5].Range.Text = materialCustomer.Sum.ToString();

                        amountMaterialsCustomer += materialCustomer.Amount;
                        sumMaterialsCustomer += materialCustomer.Sum;
                    }

                    MergeTotalRow(materialCustomerTable, "Всего:", amountMaterialsCustomer, sumMaterialsCustomer);


                    if (!string.IsNullOrEmpty(applicationInfo.PowerOfAttorneyNumber))
                        powerOfattorneyInfo = string.Format("№{0} от {1}", applicationInfo.PowerOfAttorneyNumber, GetDateString(applicationInfo.PowerOfAttorneyDate));



                    ReplaceWordStub("{Number}", applicationInfo.Number.ToString());
                    ReplaceWordStub("{Date}", applicationInfo.Date.ToString("dd MMMM yyyy"));

                    ReplaceWordStub("{TypeRepair}", applicationInfo.Type);
                    ReplaceWordStub("{First}", GetDateString(applicationInfo.FirstControlTime));
                    ReplaceWordStub("{Second}", GetDateString(applicationInfo.SecondControlTime));

                    ReplaceWordStub("{Contractor}", applicationInfo.Contractor);
                    ReplaceWordStub("{Phone}", applicationInfo.Phone);
                    ReplaceWordStub("{AddressContractor}", applicationInfo.Address);


                    ReplaceWordStub("{ContactPerson}", applicationInfo.ContactPerson);
                    ReplaceWordStub("{PhoneContactPerson}", applicationInfo.PhoneContactPerson);

                    ReplaceWordStub("{PowerOfAttorney}", powerOfattorneyInfo);
                    ReplaceWordStub("{AddressContactPerson}", applicationInfo.AddressContactPerson);


                    ReplaceWordStub("{Model}", applicationInfo.Model);
                    ReplaceWordStub("{LicensePlate}", applicationInfo.LicensePlate);
                    ReplaceWordStub("{Year}", applicationInfo.Year.ToString("yyyy"));
                    ReplaceWordStub("{PriceCar}", applicationInfo.Price == 0 ? null : applicationInfo.Price.ToString());
                    ReplaceWordStub("{VIN}", applicationInfo.VIN);
                    ReplaceWordStub("{Mileage}", applicationInfo.Mileage.ToString());
                    ReplaceWordStub("{NumberBody}", applicationInfo.NumberBody);
                    ReplaceWordStub("{Color}", applicationInfo.Color);

                    ReplaceWordStub("{AgreementConditions}", Properties.Settings.Default.AgreementConditions);
                    ReplaceWordStub("{TermsPurchaseMaterials}", Properties.Settings.Default.TermsPurchaseMaterials);

                    ReplaceWordStub("{Employee}", applicationInfo.Employee);

                    ReplaceWordStub("{Sum}", DateAndMoneyConverter.CurrencyToTxt((double)sumRepair, false));
                }

                Save();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}