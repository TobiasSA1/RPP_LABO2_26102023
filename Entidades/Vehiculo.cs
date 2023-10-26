using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected Propulsion.EPropulsion propulsion;

        protected Vehiculo(Propulsion.EPropulsion propulsion) : this(propulsion, false) { }

        /// <summary>
        /// Crea una nueva instancia de la clase Vehiculo con la propulsión y el estado AWD especificados.
        /// </summary>
        /// <param name="propulsion">El tipo de propulsión del vehículo.</param>
        /// <param name="esAWD">Indica si el vehículo es AWD (4x4) o no.</param>
        protected Vehiculo(Propulsion.EPropulsion propulsion, bool esAWD)
        {
            this.propulsion = propulsion;
            this.esAWD = esAWD;
            this.numeroDeChasis = Guid.NewGuid(); 
        }
        protected Propulsion.EPropulsion Propulsion
        {
            get
            {
                return this.propulsion;
            }
        }

        protected abstract string Tipo { get; }
        protected virtual string GetInfo()
        {
            string awdStatus = esAWD ? "SI" : "NO";
            return string.Format("[{0}] con propulsión a [{1}], {2} es AWD, número de chasis [{3}].", this.Tipo, this.propulsion, awdStatus, this.numeroDeChasis);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return GetInfo();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (ReferenceEquals(v1, v2)) // Si ambos objetos son nulos o apuntan a la misma referencia
                return true;

            if (ReferenceEquals(v1, null) || ReferenceEquals(v2, null)) // Si uno de los objetos es nulo
                return false;

            if (v1.GetType() != v2.GetType()) // Si los objetos son de tipos diferentes
                return false;

            return v1.numeroDeChasis == v2.numeroDeChasis;
        }
    }   
}
