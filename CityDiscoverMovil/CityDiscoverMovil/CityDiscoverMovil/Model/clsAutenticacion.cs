using System;
using System.Collections.Generic;
using System.Text;

namespace CityDiscoverMovil.Model
{
    public class clsAutenticacion
    {
        public string Usuario { get; set; }

        public string Contrasena { get; set; }

        public clsAutenticacion(string _Usuario, string _Contrasena)
        {
            Usuario = _Usuario;
            Contrasena = _Contrasena;
        }

    }
}
