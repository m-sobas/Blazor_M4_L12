using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Blazor_M4_L12.Components
{
    public partial class ModalDialog
    {
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public string Content { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClickDelete { get; set; }
        
        [Parameter]
        public EventCallback<MouseEventArgs> OnClickCancel { get; set; }
    }
}
