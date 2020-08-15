namespace ServiceStation.InterfacesView
{
    internal interface IEditingMarkView : IEditingView
    {
        string ShortName { get; }
        string FullName { get; }
        void SetMarkInfo(string shortName, string fullName);
    }
}
