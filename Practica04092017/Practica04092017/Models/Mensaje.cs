using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica04092017.Models
{
    public class Mensaje
    {
        public string saludo { get; set; }

        public Mensaje (string mensaje)
        {
            saludo = mensaje;
        }
    }
}