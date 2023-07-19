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

        public string? Signature
        {
            get;
            set;
        } = string.Empty;

        public bool? SignatureSaved { get; set; } = false;

        public int? AgePreference { get; set; } = 1;

        public int? RealAge { get; set; } = 0;

        public string? FullName { get; set; } = "Not Yet Scanned";

        public string? AgeCategory { get; set; } = "Not Found";

        public bool? Under16AgeMode { get; set; } = false;

        public bool? Above16AgeMode { get; set; } = false;

        [Required(ErrorMessage = "Signature date is required")]
        public DateTime SignatureDate
        {
            get;
            set;
        } = DateTime.UtcNow;
    }
}
