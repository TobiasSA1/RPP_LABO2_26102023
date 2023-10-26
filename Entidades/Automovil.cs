using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Propulsion;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        protected override string Tipo
        {
            get { return "Automovil"; }
        }

        public Automovil() : base(EPropulsion.Hibrida)
        {
        }
    }
}
