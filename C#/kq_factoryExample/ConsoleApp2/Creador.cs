using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Creador
    {
        public const int DRON = 1;
        public const int PERSONA = 2;
        public const int CICLISTA = 3;

        public static Envio CreadorEnvio(int Tipo)
        {
            switch (Tipo)
            {
                case DRON: return new Dron();
                case PERSONA: return new Persona();
                case CICLISTA: return new Ciclista();

                    default: return null;
            }
        }
    }
}
