using Entidades;

namespace Recuperatorio_Primer_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarFabrica();
            Refrescar();
        }

        private Fabrica fabrica;

        private void Form1_Load(object sender, EventArgs e)
        {

            // Configurar ComboBox
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Items.Add("Autom�vil");
            cmbTipo.Items.Add("Camioneta");
            cmbTipo.Items.Add("Moto");
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InicializarFabrica()
        {
            fabrica = new Fabrica(100);
            fabrica += new Camioneta(Propulsion.EPropulsion.Electrica, true);
        }

        private void Refrescar()
        {
            lstVehiculos.DataSource = null;
            lstVehiculos.DataSource = fabrica.Vehiculos;
        }

        private Vehiculo CrearVehiculo()
        {
            string tipo = cmbTipo.SelectedItem.ToString();

            switch (tipo)
            {
                case "Autom�vil":
                    return new Automovil();
                case "Camioneta":
                    return new Camioneta(Propulsion.EPropulsion.Combustion, true);
                case "Moto":
                    return new Moto(Propulsion.EPropulsion.Electrica);
                default:
                    return null;
            }
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = CrearVehiculo();
            if (nuevoVehiculo is not null)
            {
                fabrica += nuevoVehiculo;
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedItem != null)
            {
                Vehiculo vehiculo = (Vehiculo)lstVehiculos.SelectedItem;
                fabrica -= vehiculo;
                Refrescar();
            }
        }
    }
}
