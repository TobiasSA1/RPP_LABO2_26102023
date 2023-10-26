using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo
    {
        private bool cabinaSimple;

        protected override string Tipo
        {
            get { return "Camioneta"; }
        }

        public Camioneta(Propulsion.EPropulsion propulsion, bool cabinaSimple) : base(propulsion, true)
        {
            this.cabinaSimple = cabinaSimple;
        }

        protected override string GetInfo()
        {
            string cabina = this.cabinaSimple ? "Simple (true)" : "Doble (false)";
            StringBuilder info = new StringBuilder(base.GetInfo());
            info.AppendFormat(", con cabina: [{0}]", cabina);
            return info.ToString();
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
