using System;
using System.Windows.Forms;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingApplicationView : IEditingView
    {
        event Action ClearContactPerson;
        event Action SelectionContractor;
        event Action SelectionContactPerson;
        event Action SelectionCar;
        event Action SelectionPowerOfAttorney;
        event Action SelectionResponsible;
        
        event ActionAsync AddReason;
        event ActionAsync EditReason;
        event ActionAsync DeleteReason;

        event ActionAsync AddOption;
        event ActionAsync DeleteOption;


        DataGridView Options { get; }
        DataGridView Reasons { get; }
        bool EnabledContactPerson { set; }
        bool EnabledPowerOfAttorney { set; }
        bool EnabledCar { set; }
        // Ответственный
        string Responsible { set; }
        string Contractor { set; }
        string ContactPerson { set; }
        string PowerOfAttorney { set; }
        string Car {  set; }
        int Number { get; set; }
        DateTime Date { get; set; }
        DateTime? FirstControlTime { get; set; }
        DateTime? SecondControlTime { get; set; }
        DateTime? Readiness { get; set; }
        DateTime? Extradition { get; set; }
        string TypeRepair { get; set; }
        string Revealed { get; set; }
        string Recommendations { get; set; }
        void SetApplicationInfo(string contractor,string car, DateTime date, DateTime? firstControlTime, DateTime? secondControlTIme, DateTime? readiness, DateTime? extradition, string typeRepair, string revealed, string recommendations, string responsible);
        void SetContactPersonInfo(string contactPerson, string powerOfAttorney);
        string Sum { set; }
    }
}
