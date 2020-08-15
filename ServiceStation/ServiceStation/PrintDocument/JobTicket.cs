using RuDateAndMoneyConverter;
using ServiceStation.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ServiceStation.PrintDocument
{
    internal class JobTicket : Document
    {

        /// <summary>
        /// Номер заявки для загрузки из базы данных
        /// </summary>
        /// <param name="numberApplication"></param>
        internal JobTicket(int numberApplication) : base(numberApplication, Directory.GetCurrentDirectory() + @"\DocumentTemplates\JobTicket.dotx") {}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal override void Load()
        {
            try
            {
                WordDocument = WordOpen(directory);

                List<Guid> reasonCustomerID = new List<Guid>();
                //List<Guid> workID =
                decimal totalSum = 0;
                decimal amountWorks = 0;
                decimal sumWorks = 0;
                decimal amountMaterials = 0;
                decimal sumMaterials = 0;
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
                        PhoneContactPerson = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.Phone) ? null : a.PowerOfAttorney.ContactPerson.Phone,
                        AddressContactPerson = string.IsNullOrEmpty(a.PowerOfAttorney.ContactPerson.Address) ? null : a.PowerOfAttorney.ContactPerson.Address,

                        PowerOfAttorneyNumber = string.IsNullOrEmpty(a.PowerOfAttorney.Number) ? null : a.PowerOfAttorney.Number,
                        PowerOfAttorneyDate = a.PowerOfAttorney.Date == null ? null : (DateTime?)a.PowerOfAttorney.Date,

                        Employee = a.Employee.FFP,
                        //a.FirstControlTime,
                        //a.SecondControlTime,
                        //a.Type,
                        a.Readiness,
                        a.Extradition,
                        a.Revealed,
                        a.Recommendations

                    }).First();
                    

                    reasonCustomerID = context.ReasonCustomer.Where(rc => rc.Number == applicationInfo.Number).Select(rc => rc.ID).ToList();


                    var workInfo = context.Work.Where(w => reasonCustomerID.Contains(w.ID_reasonCustomer)).OrderBy(w => new { w.Nomenclature.ShortName/*, w.WorkingHour.Name*/ }).Select(w => new
                    {
                        w.ID,
                        Work = w.Nomenclature.ShortName,
                        w.Amount,
                        //WorkingHour = w.WorkingHour.Name,
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

                        var currentWorkRow = workTable.Rows[i + 1];
                        var work = workInfo[i - 1];
                        
                        currentWorkRow.Cells[1].Range.Text = work.Work;
                        currentWorkRow.Cells[2].Range.Text = work.Amount.ToString();
                        currentWorkRow.Cells[3].Range.Text = work.NormOfTime.ToString("0.00");
                        currentWorkRow.Cells[4].Range.Text = work.PriceWorkingHour.ToString();
                        currentWorkRow.Cells[5].Range.Text = work.Sum.ToString();

                        amountWorks += work.Amount;
                        sumWorks += work.Sum;

                        totalSum += sumWorks;
                    }

                    MergeTotalRow(workTable, "Итого:", amountWorks, totalSum);

                    ReplaceWordStub("{SumWork}", DateAndMoneyConverter.CurrencyToTxt((double)sumWorks, false));

                    var materialInfo = context.Material.Where(m => reasonCustomerID.Contains(m.ID_reasonCustomer)).Select(m => new
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
                        var material = materialInfo[i - 1];

                        if (material.Customer == false)
                        {
                            materialTable.Rows.Add();

                            if (i == 1)
                                SetParameterNomenclatureRow(materialTable);

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
                    }

                    MergeTotalRow(materialTable, "Итого:", amountMaterials, sumMaterials);

                    ReplaceWordStub("{SumMaterial}", DateAndMoneyConverter.CurrencyToTxt((double)sumMaterials, false));



                    Word.Table materialCustomerTable = WordDocument.Tables[3];
                    materialTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitFixed);


                    for (int i = 1; i <= materialInfo.Count; i++)
                    {
                        var material = materialInfo[i-1];
                        if (material.Customer == true)
                        {
                            materialCustomerTable.Rows.Add();

                            if (i == 1)
                                SetParameterNomenclatureRow(materialCustomerTable);

                            var currentRow = materialCustomerTable.Rows[i + 1];

                            currentRow.Cells[1].Range.Text = material.Material;
                            currentRow.Cells[2].Range.Text = material.Amount.ToString();
                            currentRow.Cells[3].Range.Text = material.Unit;
                            currentRow.Cells[4].Range.Text = material.Price.ToString();
                            currentRow.Cells[5].Range.Text = material.Sum.ToString();
                            
                            sumMaterialsCustomer += material.Sum;
                            amountMaterialsCustomer += material.Amount;

                            //totalSum += sumMaterials;
                        }
                    }

                    MergeTotalRow(materialCustomerTable, "Итого:", amountMaterialsCustomer, sumMaterialsCustomer);


                    // Итого по документу
                    ReplaceWordStub("{SumDocument}", totalSum.ToString("0.00 рублей"));
                    ReplaceWordStub("{SumDocumentText}", DateAndMoneyConverter.CurrencyToTxt((double)totalSum, false));




                    if (!string.IsNullOrEmpty(applicationInfo.PowerOfAttorneyNumber))
                        powerOfattorneyInfo = string.Format("№{0} от {1:dd MMMM yyyy}", applicationInfo.PowerOfAttorneyNumber, applicationInfo.PowerOfAttorneyDate);



                    ReplaceWordStub("{Number}", applicationInfo.Number.ToString());
                    ReplaceWordStub("{Date}", applicationInfo.Date.ToString("dd MMMM yyyy"));

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


                    ReplaceWordStub("{Revealed}", applicationInfo.Revealed);
                    ReplaceWordStub("{Other}", applicationInfo.Recommendations);


                    ReplaceWordStub("{Readiness}", applicationInfo.Readiness == null ? null : ((DateTime)applicationInfo.Readiness).ToString("dd MMMM yyyy"));
                    ReplaceWordStub("{Extradition}", applicationInfo.Extradition == null ? null : ((DateTime)applicationInfo.Extradition).ToString("dd MMMM yyyy"));

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
