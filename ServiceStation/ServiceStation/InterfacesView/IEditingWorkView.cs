using System;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingWorkView : IEditingNomenclatureReasonCustomerView
    {
        event Action SelectionWorkingHour;
        string NameWorkingHour { set; }
        string PriceWorkingHour { set; }
        decimal NormOfTime { get; set; }
        void SetWorkInfo(string nomenclature, int amount, string nameWorkingHour, string priceWorkingHour, decimal normOfTime);
    }
}
