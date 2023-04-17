using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dron : Envio
    {
        public override float TiempoEstimadoxCuadra()
        {
            return .4f;
        }

        public override float Asd()
        {
            return 180f;
        }
        public override string TipoRepartidor()
        {
            return "Dron";
        }
    }
}
