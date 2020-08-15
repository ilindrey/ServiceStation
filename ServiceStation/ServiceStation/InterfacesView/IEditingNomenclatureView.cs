using System;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingNomenclatureView : IEditingView
    {
        event Action SelectionUnit;


        int Number { get; set; }
        string ShortName { get; }
        string FullName { get; }
        string Type { get; }
        string NameUnit { set; }
        string VendorCode { get; }
        decimal Price { get; }
        string Descriprion { get; }


        void SetNomenclatureInfo(int number, string shortName, string fullName, string type, string nameUnit, string vendorCode, decimal price, string descriprion);
    }
}
