namespace ServiceStation.InterfacesView
{
    internal interface IEditingView : IView
    {
        event ActionAsync Save;
    }
}
