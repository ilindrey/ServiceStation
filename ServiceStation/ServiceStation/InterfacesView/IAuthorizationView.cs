namespace ServiceStation.InterfacesView
{
    internal interface IAuthorizationView : IView
    {
        event ActionAsync Login;
        string Username { get; }
        string Password { get; }
    }
}
