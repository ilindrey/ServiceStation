using System;
using System.Windows.Forms;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingReasonCustomerView : IEditingView
    {
        event Action SelectionReason;

        event ActionAsync AddWork;
        event ActionAsync EditWork;
        event ActionAsync DeleteWork;

        event ActionAsync AddMaterial;
        event ActionAsync EditMaterial;
        event ActionAsync DeleteMaterial;
        
        event ActionAsync AddMaterialCustomer;
        event ActionAsync EditMaterialCustomer;
        event ActionAsync DeleteMaterialCustomer;

        DataGridView Works { get; }
        DataGridView Materials { get; }
        DataGridView MaterialsCustomer { get; }


        string Sum { set; }
        string Reason { set; }
    }
}
