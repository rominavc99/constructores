using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructores
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Contacto()
        {
            Nombre = "Sin nombre";
            Telefono = "Sin telefono";
            Celular = "Sin celular";
            Correo = "Sin correo";
            Direccion = "Sin direccion";
        }

        public Contacto(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin celular";
            Direccion = "Sin direccion";
            Telefono = "Sin telefono";
        }

        public Contacto(string nombre, string celular, string telefono, string direccion, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = celular;
            Direccion = direccion;
            Telefono = correo;
        }
    }
}
