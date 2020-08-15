using System.Windows.Forms;

namespace ServiceStation
{
    public class Message
    {
        internal void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
        }

        internal bool ShowConfirmation(string message)
        {
            if (DialogResult.Yes == MessageBox.Show(message, "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, 0))
                return true;
            return false;
        }
    }
}
