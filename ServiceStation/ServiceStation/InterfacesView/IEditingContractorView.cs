using System.Windows.Forms;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingContractorView : IEditingView
    {
        event ActionAsync AddCar;
        event ActionAsync EditCar;
        event ActionAsync DeleteCar;
        event ActionAsync AddContactPerson;
        event ActionAsync EditContactPerson;
        event ActionAsync DeleteContactPerson;
        DataGridView ContactPersonJournal { get; }
        DataGridView CarsJournal { get; }
        string View { get; }
        string ShortName { get; }
        string FullName { get; }
        string INN { get; }
        string KPP { get; }
        string OKPO { get; }
        string Phone { get; }
        string Email { get; }
        string Address { get; }
        string Additionally { get; }
        void SetСontractorInfo(string view, string shortName, string fullName, string INN, string KPP, string OKPO,
                                        string phone, string email, string address, string additionally);
    }
}
