namespace ServiceStation.InterfacesView
{
    internal interface IEditingOptionView : IEditingView
    {
        string ShortName { get; }
        string FullName { get; }
        void SetOptionInfo(string shortName, string fullName);
    }
}
