using System.Windows.Forms;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingContactPersonView : IEditingView
    {
        event ActionAsync AddPowerOfAttorney;
        event ActionAsync EditPowerOfAttorney;
        event ActionAsync DeletePowerOfAttorney;
        DataGridView PowerOfAttorneyJournal { get; }
        string FFP { get; }
        string Phone { get; }
        string Email { get; }
        string Address { get; }
        string Additionally { get; }
        void SetContactNameInfo(string FFP, string phone, string email, string address, string additionaly);
    }
}
