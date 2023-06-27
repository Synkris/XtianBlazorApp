using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtianBlazorApp.Shared.ViewModels
{
    public class UploadModel
    {
        public string UserId { get; set; }
        public string Guid { get; set; }
        public string DetentionId { get; set; }
        public string DetentionLogId { get; set; }
        public string SignatureName { get; set; }
        public string SignatureType { get; set; }
        public string Base64Image { get; set; }
        public string AgePreference { get; set; }
        public string ImageData { get; set; } = string.Empty;
        public bool ConsentUnder16DPMedicalExam { get; set; }
        public bool ConsentUnder16DPForensicSampling { get; set; }
        public bool ConsentUnder16BodyDiagram { get; set; }
        public bool ConsentUnder16StatementCareRecord { get; set; }
        public bool ConsentUnder16ContatingGp { get; set; }
        public bool ConsentUnder16RelevantServiceAndReferral { get; set; }
        public string ConsentUnder16RelevantServiceAndReferralTextBox { get; set; }
        public bool ConsentUnder16AccessingSummaryRecord { get; set; }
        public bool ConsentUnder16SafeguardingReferral { get; set; }
        public bool ConsentUnder16DPInfoResearchPlanning { get; set; }
        public bool ConsentUnder16DPInfoShared { get; set; }
        public bool Consent16AndOlderDPMedicalExam { get; set; }
        public bool Consent16AndOlderDPForensicSampling { get; set; }
        public bool Consent16AndOlderBodyDiagram { get; set; }
        public bool Consent16AndOlderStatementCareRecord { get; set; }
        public bool Consent16AndOlderContatingGp { get; set; }
        public bool Consent16AndOlderRelevantServiceAndReferral { get; set; }
        public string Consent16AndOlderRelevantServiceAndReferralTextBox { get; set; }
        public bool Consent16AndOlderAccessingSummaryRecord { get; set; }
        public bool Consent16AndOlderSafeguardingReferral { get; set; }
        public bool Consent16AndOlderDPInfoResearchPlanning { get; set; }
        public bool Consent16AndOlderDPInfoShared { get; set; }
    }
    public class UploadUrl
    {
        public string URL_PRODUCTION { get; set; }
        public string URL_UAT { get; set; }
        public string URL_LOCAL { get; set; }
    }
}
