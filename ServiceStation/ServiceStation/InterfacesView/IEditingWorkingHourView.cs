namespace ServiceStation.InterfacesView
{
    internal interface IEditingWorkingHourView : IEditingView
    {
        string NameWorkingHour { get; }
        decimal Price { get; }
        void SetWorkingHourInfo(string name, decimal price);
    }
}
