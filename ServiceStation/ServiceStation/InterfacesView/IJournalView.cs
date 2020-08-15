using System.Drawing;
using System.Windows.Forms;

namespace ServiceStation.InterfacesView
{
    internal interface IJournalView : IView
    {
        Size ClientZoneSize { get; set; }

        DataGridView Grid { get; }

        event Filter Seach;

        event ActionAsync Add;
        event ActionAsync Edit;
        event ActionAsync Delele;
        event ActionAsync Choose;
    }
}
