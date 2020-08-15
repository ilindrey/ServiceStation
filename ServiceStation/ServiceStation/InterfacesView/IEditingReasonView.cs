namespace ServiceStation.InterfacesView
{
    internal interface IEditingReasonView : IEditingView
    {
        string TypeManifestation { get; }
        string ShortName { get; }
        string FullName { get; }
        string Additionally { get; }
        void SetReasonInfo(string shortName, string fullName, string typeMainifestation, string additionally);
    }
}
