using System;
using System.Windows;

namespace ServiceStation.InterfacesView
{
    internal interface IMainView : IView
    {
        event Action OutputJopTicket;
        event Action OutputCertificateCompletion;
        event Action OutputAcceptanceTransferOwnershipCertificate;


        event Filter SeachEmployee;
        event Filter SeachWorkingHour;
        event Filter SeachUnit;
        event Filter SeachNomenclature;
        event Filter SeachOption;
        event Filter SeachReason;
        event Filter SeachMark;
        event Filter SeachModel;
        event Filter SeachContractor;
        event Filter SeachApplication;


        event ActionAsync UpdateEmployee;
        event ActionAsync UpdateWorkingHour;
        event ActionAsync UpdateUnit;
        event ActionAsync UpdateNomenclature;
        event ActionAsync UpdateOption;
        event ActionAsync UpdateReason;
        event ActionAsync UpdateMark;
        event ActionAsync UpdateModel;
        event ActionAsync UpdateContractor;
        event ActionAsync UpdateApplication;


        event ActionAsync AddEmployee;
        event ActionAsync AddWorkingHour;
        event ActionAsync AddUnit;
        event ActionAsync AddNomenclature;
        event ActionAsync AddOption;
        event ActionAsync AddReason;
        event ActionAsync AddMark;
        event ActionAsync AddModel;
        event ActionAsync AddContractor;
        event ActionAsync AddApplication;


        event ActionAsync EditEmployee;
        event ActionAsync EditWorkingHour;
        event ActionAsync EditUnit;
        event ActionAsync EditNomenclature;
        event ActionAsync EditOption;
        event ActionAsync EditReason;
        event ActionAsync EditMark;
        event ActionAsync EditModel;
        event ActionAsync EditContractor;
        event ActionAsync EditApplication;


        event ActionAsync DeleteEmployee;
        event ActionAsync DeleteWorkingHour;
        event ActionAsync DeleteUnit;
        event ActionAsync DeleteNomenclature;
        event ActionAsync DeleteOption;
        event ActionAsync DeleteReason;
        event ActionAsync DeleteMark;
        event ActionAsync DeleteModel;
        event ActionAsync DeleteContractor;
        event ActionAsync DeleteApplication;

        Visibility SettingVisibility { set; }


        MainControl.MainControl Main { get; }        
    }
}
