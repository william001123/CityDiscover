using CityDiscoverMovil.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverMovil.Services
{
    public class clsAutenticacionServ
    {
        private static readonly HttpClient client = new HttpClient();
        static string ApiBaseUrl = "";

        public clsAutenticacionServ()
        {
            ApiBaseUrl = AppSettings.LoadSettings().ApiBaseUrl;
        }

        public static async Task<string> GetAuthToken(string username, string password)
        {
            try
            {
                //clsAutenticacion loginData = new clsAutenticacion(username, password);
                //var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(loginData), System.Text.Encoding.UTF8, "application/json");
                //client.BaseAddress = new Uri(ApiBaseUrl);
                //var response = await client.PostAsync("/api/Autenticacion/Validar", content);

                //if (response.IsSuccessStatusCode)
                //{
                //    var responseContent = await response.Content.ReadAsStringAsync();
                //    var token = Newtonsoft.Json.JsonConvert.DeserializeObject<clsTokenResponse>(responseContent);
                //    return token.token;
                //}
                return "Prueba";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

    }
}
