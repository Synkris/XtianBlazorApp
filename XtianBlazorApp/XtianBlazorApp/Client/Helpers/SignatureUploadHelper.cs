
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace XtianBlazorApp.Client.Helpers
{
    public interface ISignatureUploadHelper
    {
        void SetDataAsync<T>(string key, string data);
        Task<T> GetDataAsync<T>(string key);
    }
    public class SignatureUploadHelper : ISignatureUploadHelper
    {
        private readonly ILocalStorageService _localStorage;

        public SignatureUploadHelper(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }
        /// <summary>
        /// This method is for storing value locally.
        /// Use <paramref name="userData"/> as the key name when storing data after scanning for user data
        /// Use <paramref name="uploadData"/> as the key name when storing data after scanning for uploadUrl
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="data"></param>
        public async void SetDataAsync<T>(string key, string data)
        {
            await _localStorage.SetItemAsync(key, data);
        }
        public async Task<T> GetDataAsync<T>(string key)
        {
            var data = await _localStorage.GetItemAsync(key);
            if (!string.IsNullOrEmpty(data))
            {
                var jsonResponses = JsonConvert.DeserializeObject<T>(data);
                if (jsonResponses != null)
                {
                    return jsonResponses;
                }
            }
            return default;
        }
    }
}
