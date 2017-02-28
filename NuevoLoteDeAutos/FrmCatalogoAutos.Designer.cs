namespace NuevoLoteDeAutos
{
    partial class FrmCatalogoAutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarAuto = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            this.btnSalirAuto = new System.Windows.Forms.Button();
            this.txtBuscarModeloAuto = new System.Windows.Forms.TextBox();
            this.dgvDatosAuto = new System.Windows.Forms.DataGridView();
            this.pkAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario_pkPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar Por Modelo";
            // 
            // btnEliminarAuto
            // 
            this.btnEliminarAuto.Enabled = false;
            this.btnEliminarAuto.Location = new System.Drawing.Point(487, 348);
            this.btnEliminarAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarAuto.Name = "btnEliminarAuto";
            this.btnEliminarAuto.Size = new System.Drawing.Size(112, 35);
            this.btnEliminarAuto.TabIndex = 10;
            this.btnEliminarAuto.Tag = "7";
            this.btnEliminarAuto.Text = "Eliminar";
            this.btnEliminarAuto.UseVisualStyleBackColor = true;
            this.btnEliminarAuto.Click += new System.EventHandler(this.btnEliminarAuto_Click);
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(367, 348);
            this.btnModificarAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(112, 35);
            this.btnModificarAuto.TabIndex = 9;
            this.btnModificarAuto.Text = "Modificar";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            this.btnModificarAuto.Click += new System.EventHandler(this.btnModificarAuto_Click);
            // 
            // btnSalirAuto
            // 
            this.btnSalirAuto.Location = new System.Drawing.Point(607, 348);
            this.btnSalirAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalirAuto.Name = "btnSalirAuto";
            this.btnSalirAuto.Size = new System.Drawing.Size(112, 35);
            this.btnSalirAuto.TabIndex = 8;
            this.btnSalirAuto.Text = "Salir";
            this.btnSalirAuto.UseVisualStyleBackColor = true;
            this.btnSalirAuto.Click += new System.EventHandler(this.btnSalirAuto_Click);
            // 
            // txtBuscarModeloAuto
            // 
            this.txtBuscarModeloAuto.Location = new System.Drawing.Point(8, 34);
            this.txtBuscarModeloAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarModeloAuto.Name = "txtBuscarModeloAuto";
            this.txtBuscarModeloAuto.Size = new System.Drawing.Size(438, 26);
            this.txtBuscarModeloAuto.TabIndex = 7;
            this.txtBuscarModeloAuto.TextChanged += new System.EventHandler(this.txtBuscarModeloAuto_TextChanged);
            // 
            // dgvDatosAuto
            // 
            this.dgvDatosAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkAuto,
            this.sMarca,
            this.iAnio,
            this.sPlaca,
            this.iPrecio,
            this.sColor,
            this.sNacionalidad,
            this.iSerie,
            this.Propietario_pkPropietario});
            this.dgvDatosAuto.Location = new System.Drawing.Point(8, 70);
            this.dgvDatosAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatosAuto.Name = "dgvDatosAuto";
            this.dgvDatosAuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosAuto.Size = new System.Drawing.Size(736, 231);
            this.dgvDatosAuto.TabIndex = 6;
            this.dgvDatosAuto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosAuto_CellDoubleClick);
            // 
            // pkAuto
            // 
            this.pkAuto.DataPropertyName = "pkAuto";
            this.pkAuto.HeaderText = "Codigo";
            this.pkAuto.Name = "pkAuto";
            this.pkAuto.Width = 50;
            // 
            // sMarca
            // 
            this.sMarca.DataPropertyName = "sMarca";
            this.sMarca.HeaderText = "Marca";
            this.sMarca.Name = "sMarca";
            this.sMarca.Width = 70;
            // 
            // iAnio
            // 
            this.iAnio.DataPropertyName = "iAnio";
            this.iAnio.HeaderText = "Año";
            this.iAnio.Name = "iAnio";
            this.iAnio.Width = 50;
            // 
            // sPlaca
            // 
            this.sPlaca.HeaderText = "Placa";
            this.sPlaca.Name = "sPlaca";
            // 
            // iPrecio
            // 
            this.iPrecio.DataPropertyName = "iPrecio";
            this.iPrecio.HeaderText = "Precio";
            this.iPrecio.Name = "iPrecio";
            this.iPrecio.Width = 70;
            // 
            // sColor
            // 
            this.sColor.DataPropertyName = "sColor";
            this.sColor.HeaderText = "Color";
            this.sColor.Name = "sColor";
            this.sColor.Width = 60;
            // 
            // sNacionalidad
            // 
            this.sNacionalidad.DataPropertyName = "sNacionalidad";
            this.sNacionalidad.HeaderText = "Nacionalidad";
            this.sNacionalidad.Name = "sNacionalidad";
            this.sNacionalidad.Width = 90;
            // 
            // iSerie
            // 
            this.iSerie.DataPropertyName = "iSerie";
            this.iSerie.HeaderText = "Serie";
            this.iSerie.Name = "iSerie";
            // 
            // Propietario_pkPropietario
            // 
            this.Propietario_pkPropietario.DataPropertyName = "Propietario_pkPropietario";
            this.Propietario_pkPropietario.HeaderText = "Propietario";
            this.Propietario_pkPropietario.Name = "Propietario_pkPropietario";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(638, 316);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(75, 24);
            this.chkStatus.TabIndex = 12;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged_1);
            // 
            // FrmCatalogoAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 397);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarAuto);
            this.Controls.Add(this.btnModificarAuto);
            this.Controls.Add(this.btnSalirAuto);
            this.Controls.Add(this.txtBuscarModeloAuto);
            this.Controls.Add(this.dgvDatosAuto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCatalogoAutos";
            this.Text = "FrmCatalogoAutos";
            this.Activated += new System.EventHandler(this.FrmCatalogoAutos_Activated);
            this.Load += new System.EventHandler(this.FrmCatalogoAutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarAuto;
        private System.Windows.Forms.Button btnModificarAuto;
        private System.Windows.Forms.Button btnSalirAuto;
        private System.Windows.Forms.TextBox txtBuscarModeloAuto;
        private System.Windows.Forms.DataGridView dgvDatosAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario_pkPropietario;
        private System.Windows.Forms.CheckBox chkStatus;
    }
}