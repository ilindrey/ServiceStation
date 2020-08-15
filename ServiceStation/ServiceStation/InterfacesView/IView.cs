namespace ServiceStation.InterfacesView
{
    internal interface IView
    {
        event ActionAsync Loading;
        void Hide();
        void Close();
        string Title { set; }
    }
}
