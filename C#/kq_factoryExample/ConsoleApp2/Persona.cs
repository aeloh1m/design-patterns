using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Persona : Envio
    {
        public override float TiempoEstimadoxCuadra()
        {
            return 1.7f;
        }
        public override float Asd()
        {
            return 200f;
        }
        public override string TipoRepartidor()
        {
            return "Motociclista";
        }
    }
}
