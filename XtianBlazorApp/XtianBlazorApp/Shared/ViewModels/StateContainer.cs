using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtianBlazorApp.Shared.ViewModels
{
    public class StateContainer
    {
        public SignatureApproved SignatureApproved
        {
            get; set;
        }
        public List<UploadModel>? List { get; set; }
    }
}
