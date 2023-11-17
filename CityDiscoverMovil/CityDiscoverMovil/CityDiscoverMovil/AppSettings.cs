using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CityDiscoverMovil
{
    public class AppSettings
    {
        public string ApiBaseUrl { get; set; }

        public static AppSettings LoadSettings()
        {
            try
            {
                var configFilePath = "appsettings.json"; // Ajusta la ruta según la ubicación de tu archivo
                var json = File.ReadAllText(configFilePath);
                return JsonConvert.DeserializeObject<AppSettings>(json);
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la carga del archivo
                Console.WriteLine($"Error al cargar la configuración: {ex.Message}");
                return null;
            }
        }
    }
}
