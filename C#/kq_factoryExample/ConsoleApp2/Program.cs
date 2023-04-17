using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cuadras = "0";
            Console.WriteLine("Bienvenido a PedidosYa Blue!");

            Console.WriteLine("Ingrese las cuadras a la que esta del local: ");
            cuadras = Console.ReadLine();

            Envio envio0 = Creador.CreadorEnvio(Creador.DRON);
            Envio envio1 = Creador.CreadorEnvio(Creador.PERSONA);
            Envio envio2 = Creador.CreadorEnvio(Creador.CICLISTA);
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("\nPedidosYa BLUE !!!");
            Console.WriteLine(" Tipo de repartidor: " + envio0.TipoRepartidor());
            Console.WriteLine(" Tiempo de envio: " + envio0.TiempoEstimadoxCuadra() * Convert.ToInt32(cuadras) + " minutos de envio");
            Console.WriteLine(" Precio de envio: " + envio0.Asd() + "$");

            Console.WriteLine("___________________________________________________");
            Console.WriteLine("\nPedidosYa ");
            Console.WriteLine(" Tipo de repartidor: " + envio1.TipoRepartidor());
            Console.WriteLine(" Tiempo de envio: " + envio1.TiempoEstimadoxCuadra() * Convert.ToInt32(cuadras) + " minutos de envio");
            Console.WriteLine(" Precio de envio: " + envio1.Asd() + "$");
            Console.WriteLine("___________________________________________________");

            Console.WriteLine("\nPedidosYa ");
            Console.WriteLine(" Tipo de repartidor: " + envio2.TipoRepartidor());
            Console.WriteLine(" Tiempo de envio: " + envio2.TiempoEstimadoxCuadra() * Convert.ToInt32(cuadras) + " minutos de envio");
            Console.WriteLine(" Precio de envio: " + envio2.Asd() + "$");
            Console.WriteLine("___________________________________________________");


            Console.ReadLine();

        }
    }
}
