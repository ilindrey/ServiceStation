namespace ServiceStation.InterfacesView
{
    internal interface IEditingUnitView : IEditingView
    {
        int Code { get; }
        string NameUnit { get; }
        string ShortName { get; }
        void SetUnitInfo(int code, string name, string shortName);
    }
}
