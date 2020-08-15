using System;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingNomenclatureReasonCustomerView : IEditingView
    {
        event Action CalculateSum;

        event Action SelectionNomenclature;

        string Sum { set; }
        string Nomenclature { set; }
        int Amount { get; set; }
    }
}
