using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtianBlazorApp.Shared.ViewModels
{
    public class UserData
    {
        public string A { get; set; }// parsedJson['SIGNATURE_TYPE'];
        public string B { get; set; }// parsedJson['CONSENT_GUID'];
        public string C { get; set; }// parsedJson['DETENTIONLOGID'];
        public string D { get; set; }// int.parse(parsedJson['USER_ID']);
        public string E { get; set; }// parsedJson['USER_NAME'];
        public string F { get; set; }//  parsedJson['USER_DISPLAY_NAME'];
        public string G { get; set; }// int.parse(parsedJson['DETENTION_ID']);
        public string H { get; set; }// int.parse(parsedJson['DETAINEE_ID']);
        public string I { get; set; }//  parsedJson['DETAINEE_DOB'];
        public string J { get; set; }// int.parse(parsedJson['DETAINEE_AGE_YEARS']);
        public string K { get; set; }// int.parse(parsedJson['DETAINEE_AGE_PREFERENCE']);
        public string L { get; set; }// parsedJson['DETAINEE_DISPLAY_NAME'];
        public string M { get; set; }// parsedJson['SIGNATURE_NAME'];
        public string N { get; set; }// int.parse(parsedJson['EXPIRY_EPOCH_MS']);
    }
}
