using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Jose";
            contacto1.Celular = "6444227374";
            contacto1.Correo = "chayanne@gmail.com";
            

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Celular: " + contacto1.Celular);
            Console.WriteLine("Correo: " + contacto1.Correo);
            Console.WriteLine("Direccion: " + contacto1.Direccion);

            Contacto contacto2 = new Contacto("Juan", "veniocamela@gmail.com");

            Console.WriteLine("Contacto 2: ");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Correo: " + contacto2.Correo);
            Console.WriteLine("Direcion : " + contacto2.Direccion);

            Console.Read();
        }
    }
}
