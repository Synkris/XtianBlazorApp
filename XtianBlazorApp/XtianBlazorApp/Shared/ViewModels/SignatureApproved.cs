using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtianBlazorApp.Shared.ViewModels
{
    public class SignatureApproved
    {
        [Required(ErrorMessage = "Printed name is required")]
        public string PrintedName
        {
            get;
            set;
        } = string.Empty;

        public string Signature
        {
            get;
            set;
        } = string.Empty;

        [Required(ErrorMessage = "Signature date is required")]
        public DateTime SignatureDate
        {
            get;
            set;
        } = DateTime.UtcNow;
    }
}
