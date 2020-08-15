using RuDateAndMoneyConverter;
using ServiceStation.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ServiceStation.PrintDocument
{
    internal class CertificateCompletion : Document
    {
        internal CertificateCompletion(int numberApplication) : base(numberApplication, Directory.GetCurrentDirectory() + @"\DocumentTemplates\CertificateCompletion.dotx") { }

        internal override void Load()
        {
            try
            {
                WordDocument = WordOpen(directory);

                List<Guid> reasonCustomerID = new List<Guid>();
                decimal totalSum = 0;
                decimal amountWorks = 0;
                decimal sumWorks = 0;
                decimal amountMaterials = 0;
                decimal sumMaterials = 0;
                string powerOfattorneyInfo = null;

                using (var context = new DbSSContext())
                {
                    var applicationInfo = context.Application.Where(a => a.Number == NumberApplication).Select(a => new
                    {
                        a.Number,
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
                        Color = a.Car.Color,
                        a.Car.Year,

                        ContactPerson = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.FFP) ? null : a.PowerOfAttorney.ContactPerson.FFP,
                        PhoneContactPerson = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.Phone) ? null : a.PowerOfAttorney.ContactPerson.Phone,
                        AddressContactPerson = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.Address) ? null : a.PowerOfAttorney.ContactPerson.Address,

                        PowerOfAttorneyNumber = string.IsNullOrEmpty(a.PowerOfAttorney.Number) ? null : a.PowerOfAttorney.Number,
                        PowerOfAttorneyDate = a.PowerOfAttorney.Date == null ? null : (DateTime?)a.PowerOfAttorney.Date,

                        Employee = a.Employee.FFP,
                        a.Readiness,
                        a.Extradition

                    }).First();



                    reasonCustomerID = context.ReasonCustomer.Where(rc => rc.Number == applicationInfo.Number).Select(rc => rc.ID).ToList();


                    var workInfo = context.Work.Where(w => reasonCustomerID.Contains(w.ID_reasonCustomer)).OrderBy(w => new { w.Nomenclature.ShortName }).Select(w => new
                    {
                        Work = w.Nomenclature.ShortName,
                        w.Amount,
                        w.NormOfTime,
                        PriceWorkingHour = w.WorkingHour.Price,
                        Sum = w.WorkingHour.Price * w.Amount * w.NormOfTime
                    }).ToList();

                    Word.Table workTable = WordDocument.Tables[1];
                    workTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitFixed);


                    for (int i = 1; i <= workInfo.Count; i++)
                    {
                        workTable.Rows.Add();

                        if (i == 1)
                            SetParameterNomenclatureRow(workTable);

                        var work = workInfo[i - 1];
                        var currentRow = workTable.Rows[i + 1];
                                                

                        currentRow.Cells[1].Range.Text = work.Work;
                        currentRow.Cells[2].Range.Text = work.Amount.ToString();
                        currentRow.Cells[3].Range.Text = work.NormOfTime.ToString("0.00");
                        currentRow.Cells[4].Range.Text = work.PriceWorkingHour.ToString();
                        currentRow.Cells[5].Range.Text = work.Sum.ToString();

                        amountWorks += work.Amount;
                        sumWorks += work.Sum;

                        totalSum += sumWorks;
                    }

                    MergeTotalRow(workTable, "Итого:", amountWorks, totalSum);

                    ReplaceWordStub("{SumWork}", DateAndMoneyConverter.CurrencyToTxt((double)sumWorks, false));

                    var materialInfo = context.Material.Where(m => m.Customer == false && reasonCustomerID.Contains(m.ID_reasonCustomer)).Select(m => new
                    {
                        m.Customer,
                        Material = m.Nomenclature.ShortName,
                        m.Amount,
                        Unit = m.Nomenclature.Unit.Name,
                        m.Price,
                        Sum = m.Amount * m.Price
                    }).OrderBy(m => new { m.Material }).ToList();


                    Word.Table materialTable = WordDocument.Tables[2];
                    materialTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitFixed);


                    for (int i = 1; i <= materialInfo.Count; i++)
                    {
                        materialTable.Rows.Add();

                        if (i == 1)
                            SetParameterNomenclatureRow(materialTable);

                        var material = materialInfo[i - 1];
                        var currentRow = materialTable.Rows[i + 1];

                        currentRow.Cells[1].Range.Text = material.Material;
                        currentRow.Cells[2].Range.Text = material.Amount.ToString();
                        currentRow.Cells[3].Range.Text = material.Unit;
                        currentRow.Cells[4].Range.Text = material.Price.ToString();
                        currentRow.Cells[5].Range.Text = material.Sum.ToString();


                        sumMaterials += material.Sum;
                        amountMaterials += material.Amount;

                        totalSum += sumMaterials;
                    }

                    MergeTotalRow(materialTable, "Итого:", amountMaterials, sumMaterials);

                    ReplaceWordStub("{SumMaterial}", DateAndMoneyConverter.CurrencyToTxt((double)sumMaterials, false));
                    

                    // Итого по документу
                    ReplaceWordStub("{SumDocument}", totalSum.ToString("0.00 рублей"));
                    ReplaceWordStub("{SumDocumentText}", DateAndMoneyConverter.CurrencyToTxt((double)totalSum, false));

                    
                    if (!string.IsNullOrEmpty(applicationInfo.PowerOfAttorneyNumber))
                        powerOfattorneyInfo = string.Format("№{0} от {1:dd MMMM yyyy}", applicationInfo.PowerOfAttorneyNumber, applicationInfo.PowerOfAttorneyDate);



                    ReplaceWordStub("{Number}", applicationInfo.Number.ToString());
                    ReplaceWordStub("{Date}", GetDateString(applicationInfo.Readiness));

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

                    //ReplaceWordStub("{AgreementConditions}", Properties.Settings.Default.AgreementConditions);
                    //ReplaceWordStub("{TermsPurchaseMaterials}", Properties.Settings.Default.TermsPurchaseMaterials);


                    //ReplaceWordStub("{Revealed}", applicationInfo.Revealed);
                    //ReplaceWordStub("{Other}", applicationInfo.Other);


                    //ReplaceWordStub("{Readiness}", applicationInfo.Readiness == null ? null : ((DateTime)applicationInfo.Readiness).ToString("dd MMMM yyyy"));
                    //ReplaceWordStub("{Extradition}", applicationInfo.Extradition == null ? null : ((DateTime)applicationInfo.Extradition).ToString("dd MMMM yyyy"));

                    ReplaceWordStub("{Guarantee}", Properties.Settings.Default.Guarantee);


                    ReplaceWordStub("{Employee}", applicationInfo.Employee);
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
