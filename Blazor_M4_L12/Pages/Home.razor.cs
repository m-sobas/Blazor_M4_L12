using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;

namespace Blazor_M4_L12.Pages
{
    public partial class Home
    {
        private bool _modalDialogVisible = false;
        private bool _stateVisible = false;

        private void ShowModalDialog()
        {
            _stateVisible = false;
            _modalDialogVisible = true;
        }

        private void OnClickCancel(MouseEventArgs e)
        {
            _modalDialogVisible = false;
        }

        private void OnClickDelete(MouseEventArgs e)
        {
            _stateVisible = true;
            _modalDialogVisible = false;
        }
    }
}
