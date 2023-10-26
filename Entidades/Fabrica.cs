using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos
        {
            get { return vehiculos; }
        }

        private Fabrica()
        {
            this.capacidad = int.MaxValue; // Sin límite de capacidad
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad)
        {
            this.capacidad = capacidad;
            this.vehiculos = new List<Vehiculo>();
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            var vehiculoEncontrado = fabrica.vehiculos.FirstOrDefault(v => v.GetType() == vehiculo.GetType() && v.ToString() == vehiculo.ToString());
            if (vehiculoEncontrado != null)
            {
                fabrica.vehiculos.Remove(vehiculoEncontrado);
            }
            return fabrica;
        }

    }
}
