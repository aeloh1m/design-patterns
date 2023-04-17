using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ciclista : Envio
    {
        public override float TiempoEstimadoxCuadra()
        {
            return 2.7f;
        }
        public override float Asd()
        {
            return 100f;
        }
        public override string TipoRepartidor()
        {
            return "Bicibandido";
        }
    }
}
