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
            cmbTipo.Items.Add("Automóvil");
            cmbTipo.Items.Add("Camioneta");
            cmbTipo.Items.Add("Moto");

            cmbTipoPropulsion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPropulsion.Items.Add("Combustion");
            cmbTipoPropulsion.Items.Add("Hibrida");
            cmbTipoPropulsion.Items.Add("Electrica");

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InicializarFabrica()
        {
            this.fabrica = new Fabrica(100);
            this.fabrica += new Camioneta(Propulsion.EPropulsion.Electrica, true);
        }

        private void Refrescar()
        {
            this.lstVehiculos.DataSource = null;
            this.lstVehiculos.DataSource = fabrica.Vehiculos;
        }

        private Vehiculo CrearVehiculo()
        {
            string tipo = cmbTipo.SelectedItem.ToString();

            Propulsion.EPropulsion propulsion = (Propulsion.EPropulsion)cmbTipoPropulsion.SelectedIndex;

            switch (tipo)
            {
                case "Automóvil":
                    return new Automovil(propulsion);
                case "Camioneta":
                    return new Camioneta(propulsion, true);
                case "Moto":
                    return new Moto(propulsion);
                default:
                    return null;
            }
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            Vehiculo nuevoVehiculo = CrearVehiculo();
            if (nuevoVehiculo is not null)
            {
                this.fabrica += nuevoVehiculo;
                Refrescar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstVehiculos.SelectedItem != null)
            {
                Vehiculo vehiculo = (Vehiculo)this.lstVehiculos.SelectedItem;
                this.fabrica -= vehiculo;
                Refrescar();
            }
        }
    }
}
