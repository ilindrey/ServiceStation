namespace ServiceStation.InterfacesView
{
    internal interface IEditingMaterialView : IEditingNomenclatureReasonCustomerView
    {
        decimal Price { get; set; }
        void SetMaterialInfo(string nameNomenclature, int amount, decimal price);
    }
}
