using System;
using System.Collections.Generic;
using System.Text;

namespace CityDiscoverMovil.Model
{
    public class clsUbicacion
    {
        public int IdUbicacion { get; set; }

        public double numLatitud { get; set; }

        public double numLongitud { get; set; }

        public string strNombre { get; set; }

        public string strDescripcion { get; set; }

        public int IdTipoLugar { get; set; }

        public clsUbicacion(int _IdUbicacion, double _numLatitud, double _numLongitud, string _strNombre, string _strDescripcion, int _IdTipoLugar)
        {
            IdUbicacion = _IdUbicacion;
            numLatitud = _numLatitud;
            numLongitud = _numLongitud;
            strNombre = _strNombre;
            strDescripcion = _strDescripcion;
            IdTipoLugar = _IdTipoLugar;
        }

    }
}
