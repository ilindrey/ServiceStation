using System;
using System.Windows.Forms;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingEmployeeView : IEditingView
    {
        event Action SelectionPost;
        event ActionAsync DeleteUser;
        Button EditingUser { get; }
        bool VisibleDeleteUser { set; }
        string FFP { get; }
        string Post { get; set; }
        bool EnterUser { get; set; }
        string Username { get; }
        string Password { get; }
        bool Administrator { get; }
        void SetEmployeeInfo(string FFP, string post);
        void SetUserInfo(string username, string password, bool administrator);
    }
}
