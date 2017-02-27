namespace NuevoLoteDeAutos
{
    partial class FrmCatalogoPropietario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDatosPropietario = new System.Windows.Forms.DataGridView();
            this.pkPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_pkCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosPropietario
            // 
            this.dgvDatosPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPropietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPropietario,
            this.sNombre,
            this.sDireccion,
            this.sTelefono,
            this.sCorreo,
            this.iIfe,
            this.sFoto,
            this.Cliente_pkCliente});
            this.dgvDatosPropietario.Location = new System.Drawing.Point(22, 75);
            this.dgvDatosPropietario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatosPropietario.Name = "dgvDatosPropietario";
            this.dgvDatosPropietario.Size = new System.Drawing.Size(1278, 231);
            this.dgvDatosPropietario.TabIndex = 0;
            this.dgvDatosPropietario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosPropietario_CellDoubleClick);
            // 
            // pkPropietario
            // 
            this.pkPropietario.DataPropertyName = "pkPropietario";
            this.pkPropietario.HeaderText = "Codigo";
            this.pkPropietario.Name = "pkPropietario";
            this.pkPropietario.Width = 50;
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "sNombre";
            this.sNombre.HeaderText = "Nombre Completo";
            this.sNombre.Name = "sNombre";
            this.sNombre.ReadOnly = true;
            this.sNombre.Width = 230;
            // 
            // sDireccion
            // 
            this.sDireccion.DataPropertyName = "sDireccion";
            this.sDireccion.HeaderText = "Direccion Cmpleta";
            this.sDireccion.Name = "sDireccion";
            this.sDireccion.ReadOnly = true;
            this.sDireccion.Width = 275;
            // 
            // sTelefono
            // 
            this.sTelefono.DataPropertyName = "sTelefono";
            this.sTelefono.HeaderText = "Telefono";
            this.sTelefono.Name = "sTelefono";
            this.sTelefono.ReadOnly = true;
            // 
            // sCorreo
            // 
            this.sCorreo.DataPropertyName = "sCorreo";
            this.sCorreo.HeaderText = "Correo";
            this.sCorreo.Name = "sCorreo";
            this.sCorreo.ReadOnly = true;
            this.sCorreo.Width = 200;
            // 
            // iIfe
            // 
            this.iIfe.DataPropertyName = "iIfe";
            this.iIfe.HeaderText = "Ife";
            this.iIfe.Name = "iIfe";
            this.iIfe.ReadOnly = true;
            this.iIfe.Width = 125;
            // 
            // sFoto
            // 
            this.sFoto.DataPropertyName = "sFoto";
            this.sFoto.HeaderText = "Foto";
            this.sFoto.Name = "sFoto";
            this.sFoto.ReadOnly = true;
            // 
            // Cliente_pkCliente
            // 
            this.Cliente_pkCliente.DataPropertyName = "Cliente_pkCliente";
            this.Cliente_pkCliente.HeaderText = "Cliente Foraneo";
            this.Cliente_pkCliente.Name = "Cliente_pkCliente";
            this.Cliente_pkCliente.ReadOnly = true;
            this.Cliente_pkCliente.Width = 150;
            // 
            // txtBuscarNombreCompleto
            // 
            this.txtBuscarNombreCompleto.Location = new System.Drawing.Point(22, 39);
            this.txtBuscarNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarNombreCompleto.Name = "txtBuscarNombreCompleto";
            this.txtBuscarNombreCompleto.Size = new System.Drawing.Size(438, 26);
            this.txtBuscarNombreCompleto.TabIndex = 1;
            this.txtBuscarNombreCompleto.TextChanged += new System.EventHandler(this.txtBuscarNombreCompleto_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1188, 346);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(948, 346);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1068, 346);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Por Nombre Completo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(1228, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "status";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmCatalogoPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 398);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBuscarNombreCompleto);
            this.Controls.Add(this.dgvDatosPropietario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCatalogoPropietario";
            this.Text = "Catalogo Propietario";
            this.Load += new System.EventHandler(this.FrmCatalogoPropietario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosPropietario;
        private System.Windows.Forms.TextBox txtBuscarNombreCompleto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_pkCliente;
    }
}