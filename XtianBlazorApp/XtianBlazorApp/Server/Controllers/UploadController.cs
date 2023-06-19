using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using XtianBlazorApp.Server.Helper;
using XtianBlazorApp.Shared.ViewModels;

namespace XtianBlazorApp.Server.Controllers
{
    public class UploadController : ControllerBase
    {
        private readonly ISignatureUploadHelper _signatureUploadHelper;

        public UploadController(SignatureUploadHelper signatureUploadHelper)
        {
            _signatureUploadHelper = signatureUploadHelper;
        }
        /// <summary>
        /// This method upload user input to back end. 
        /// B4 now, it is believed that after scanning the qr-scanner that If <paramref name="SetDataAsync"/> method has been called
        /// and the value has been stored locally. 
        /// So we retrieve to those values and and user them here
        /// </summary>
        /// <param name="signatureDetails"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UploadSignature")]
        public async Task<IActionResult> UploadSignature(string signatureDetails)
        {
            var url = "";
            var apiKey = "qm8nLvw92J89uZBazE9FmHfCjCVaOhqaa6wmr661FhduEom5QZyqmmL3dSTsCkBHJO8eiQ9oO81j8WopzYaSM9jZJhy3Aptt4sLhnEbWl7bRujqbwHTWCzsdBaZmpimFqmjYuE8RDJjKYnIJFkx0oH3U3sbBELDw8tvDzDsTGgnCdoQ7SZOYlhP8xHk2E6hK31xgb0flhBo2HfnQUPo75oRAlyICSg9E42DCQ3gy3p1CKVxa47W4bv7IR3pdr8pC";
            if (signatureDetails != null)
            {
                using (var client = new HttpClient())
                {
                    var data = JsonConvert.DeserializeObject<UploadModel>(signatureDetails);
                    if (data != null)
                    {
                        var userData = await _signatureUploadHelper.GetDataAsync<UserData>("userData").ConfigureAwait(false);
                        if (userData != null)
                        {
                            var uploadUrl = await _signatureUploadHelper.GetDataAsync<UploadUrl>("uploadData").ConfigureAwait(false);
                            if (uploadUrl == null)
                            {
                                return BadRequest(new { message = "Upload URL Not Set. Use eMAF System Menu and select the eSign option and scan the relevant QR code." });
                            }
                            switch (uploadUrl)
                            {
                                case { URL_PRODUCTION: var productionUrl } when productionUrl != null:
                                    url = productionUrl += "/signatures";
                                    break;
                                case { URL_LOCAL: var localUrl } when localUrl != null:
                                    url = localUrl += "/signatures"; ;
                                    break;
                                case { URL_UAT: var uatUrl }:
                                    url = uatUrl += "/signatures"; ;
                                    break;
                                default:
                                    break;
                            }
                            byte[] bytes = Encoding.UTF8.GetBytes(apiKey + userData.D);
                            using (SHA512 sha512 = SHA512.Create())
                            {
                                byte[] hashBytes = sha512.ComputeHash(bytes);
                                string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToUpper();
                                var content = new StringContent(
                                                    JsonConvert.SerializeObject(data),
                                                    Encoding.UTF8,
                                                    "application/json"
                                                    );
                                client.DefaultRequestHeaders.Add("ApiKey", apiKey);
                                client.DefaultRequestHeaders.Add("Hash", hash);

                                var response = await client.PostAsync(url, content);
                                if (response.IsSuccessStatusCode)
                                {
                                    return Ok(new { message = "Successful Signature Upload." });
                                }
                            }

                        }
                    }
                }
            }
            return BadRequest(new { message = "Error Occurred" });
        }

    }
}
