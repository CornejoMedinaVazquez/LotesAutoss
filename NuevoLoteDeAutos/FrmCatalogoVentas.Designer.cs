namespace NuevoLoteDeAutos
{
    partial class FrmCatalogoVentas
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
            this.txtBuscarPorNombreCatalogoCliente = new System.Windows.Forms.TextBox();
            this.dgvCatalogoCliente = new System.Windows.Forms.DataGridView();
            this.btncancelarCatalogoCliente = new System.Windows.Forms.Button();
            this.pkVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auto_pkAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_pkCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar Por Nombre";
            // 
            // txtBuscarPorNombreCatalogoCliente
            // 
            this.txtBuscarPorNombreCatalogoCliente.Location = new System.Drawing.Point(12, 21);
            this.txtBuscarPorNombreCatalogoCliente.Name = "txtBuscarPorNombreCatalogoCliente";
            this.txtBuscarPorNombreCatalogoCliente.Size = new System.Drawing.Size(444, 20);
            this.txtBuscarPorNombreCatalogoCliente.TabIndex = 16;
            this.txtBuscarPorNombreCatalogoCliente.TextChanged += new System.EventHandler(this.txtBuscarPorNombreCatalogoCliente_TextChanged);
            // 
            // dgvCatalogoCliente
            // 
            this.dgvCatalogoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkVenta,
            this.sConcepto,
            this.dCantidad,
            this.auto_pkAuto,
            this.cliente_pkCliente});
            this.dgvCatalogoCliente.Location = new System.Drawing.Point(12, 53);
            this.dgvCatalogoCliente.Name = "dgvCatalogoCliente";
            this.dgvCatalogoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoCliente.Size = new System.Drawing.Size(542, 198);
            this.dgvCatalogoCliente.TabIndex = 15;
            // 
            // btncancelarCatalogoCliente
            // 
            this.btncancelarCatalogoCliente.Location = new System.Drawing.Point(458, 280);
            this.btncancelarCatalogoCliente.Name = "btncancelarCatalogoCliente";
            this.btncancelarCatalogoCliente.Size = new System.Drawing.Size(97, 39);
            this.btncancelarCatalogoCliente.TabIndex = 14;
            this.btncancelarCatalogoCliente.Text = "Salir";
            this.btncancelarCatalogoCliente.UseVisualStyleBackColor = true;
            this.btncancelarCatalogoCliente.Click += new System.EventHandler(this.btncancelarCatalogoCliente_Click);
            // 
            // pkVenta
            // 
            this.pkVenta.DataPropertyName = "pkVenta";
            this.pkVenta.HeaderText = "Id de la venta";
            this.pkVenta.Name = "pkVenta";
            // 
            // sConcepto
            // 
            this.sConcepto.DataPropertyName = "sConcepto";
            this.sConcepto.HeaderText = "Concepto";
            this.sConcepto.Name = "sConcepto";
            // 
            // dCantidad
            // 
            this.dCantidad.DataPropertyName = "dCantidad";
            this.dCantidad.HeaderText = "Cantidad";
            this.dCantidad.Name = "dCantidad";
            // 
            // auto_pkAuto
            // 
            this.auto_pkAuto.DataPropertyName = "auto_pkAuto";
            this.auto_pkAuto.HeaderText = "Id del auto";
            this.auto_pkAuto.Name = "auto_pkAuto";
            // 
            // cliente_pkCliente
            // 
            this.cliente_pkCliente.DataPropertyName = "cliente_pkCliente";
            this.cliente_pkCliente.HeaderText = "Column1";
            this.cliente_pkCliente.Name = "cliente_pkCliente";
            // 
            // FrmCatalogoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorNombreCatalogoCliente);
            this.Controls.Add(this.dgvCatalogoCliente);
            this.Controls.Add(this.btncancelarCatalogoCliente);
            this.Name = "FrmCatalogoVentas";
            this.Text = "FrmCatalogoVentas";
            this.Load += new System.EventHandler(this.FrmCatalogoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPorNombreCatalogoCliente;
        private System.Windows.Forms.DataGridView dgvCatalogoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn auto_pkAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_pkCliente;
        private System.Windows.Forms.Button btncancelarCatalogoCliente;
    }
}