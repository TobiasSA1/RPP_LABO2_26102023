namespace Recuperatorio_Primer_Parcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstVehiculos = new ListBox();
            btnEliminar = new Button();
            btnFabricar = new Button();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            pcbFabrica = new PictureBox();
            lblTipoPropulsion = new Label();
            cmbTipoPropulsion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(35, 76);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.ScrollAlwaysVisible = true;
            lstVehiculos.Size = new Size(479, 349);
            lstVehiculos.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(551, 362);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(219, 61);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnFabricar
            // 
            btnFabricar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnFabricar.Location = new Point(551, 295);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(219, 61);
            btnFabricar.TabIndex = 2;
            btnFabricar.Text = "FABRICAR";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(551, 65);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(219, 23);
            cmbTipo.TabIndex = 3;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(551, 23);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(178, 30);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de vehiculo:";
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = (Image)resources.GetObject("pcbFabrica.Image");
            pcbFabrica.Location = new Point(627, 193);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(76, 76);
            pcbFabrica.TabIndex = 5;
            pcbFabrica.TabStop = false;
            // 
            // lblTipoPropulsion
            // 
            lblTipoPropulsion.AutoSize = true;
            lblTipoPropulsion.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoPropulsion.Location = new Point(551, 111);
            lblTipoPropulsion.Name = "lblTipoPropulsion";
            lblTipoPropulsion.Size = new Size(178, 30);
            lblTipoPropulsion.TabIndex = 7;
            lblTipoPropulsion.Text = "Tipo de vehiculo:";
            // 
            // cmbTipoPropulsion
            // 
            cmbTipoPropulsion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPropulsion.FormattingEnabled = true;
            cmbTipoPropulsion.Location = new Point(551, 153);
            cmbTipoPropulsion.Name = "cmbTipoPropulsion";
            cmbTipoPropulsion.Size = new Size(219, 23);
            cmbTipoPropulsion.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipoPropulsion);
            Controls.Add(cmbTipoPropulsion);
            Controls.Add(pcbFabrica);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(btnFabricar);
            Controls.Add(btnEliminar);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Fabrica de Vehiculos.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Button btnEliminar;
        private Button btnFabricar;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private PictureBox pcbFabrica;
        private Label lblTipoPropulsion;
        private ComboBox cmbTipoPropulsion;
    }
}