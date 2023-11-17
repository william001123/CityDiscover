using CityDiscoverMovil.Interfaces;
using CityDiscoverMovil.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverMovil.Services
{
    public class clsUbicacionServ : IServicioBase<clsUbicacion, int>
    {
        private static readonly HttpClient client = new HttpClient();
        static string ApiBaseUrl = "";

        public clsUbicacionServ()
        {
            ApiBaseUrl = AppSettings.LoadSettings().ApiBaseUrl;
        }

        public async Task<bool> Actualizar(clsUbicacion entidad)
        {
            clsUbicacion loginData = new clsUbicacion(entidad.IdUbicacion, entidad.numLatitud, entidad.numLongitud, entidad.strNombre, entidad.strDescripcion, entidad.IdTipoLugar);
            var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(loginData), System.Text.Encoding.UTF8, "application/json");
            client.BaseAddress = new Uri(ApiBaseUrl);
            var response = await client.PutAsync("/api/Ubicacion", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public Task<clsUbicacion> Insertar(clsUbicacion entidad)
        {
            throw new NotImplementedException();
        }

        public Task<clsUbicacion> ObtenerPorID(int entidadID)
        {
            throw new NotImplementedException();
        }

        public Task<List<clsUbicacion>> ObtenerTodo()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int entidadID)
        {
            throw new NotImplementedException();
        }

    }
}
