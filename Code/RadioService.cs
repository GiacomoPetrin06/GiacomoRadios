using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace GiacomoRadios.Code
{
    public class RadioService
    {
        private HttpClient _http;
        public RadioService(HttpClient http)
        {
            _http = http;
            List<Radio> list = new List<Radio>();
        }

        public async Task<List<Radio>> GetRadios()
        {
            List<Radio> radios = await _http.GetFromJsonAsync<List<Radio>>("radioList/radios.json");
            return radios ?? [];
            // se radios è null, mi restituisce un array vuoto
        }
    }
}