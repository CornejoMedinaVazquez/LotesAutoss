namespace NuevoLoteDeAutos
{
    partial class FrmClientesVentas
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
            this.btnCancelarVentaVentaCliente = new System.Windows.Forms.Button();
            this.btnAceptarVentaVentaCliente = new System.Windows.Forms.Button();
            this.txtCambioVentaVentaCliente = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaVentaClientes = new System.Windows.Forms.TextBox();
            this.txtTotalVentaVentaCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarVentaVentaCliente
            // 
            this.btnCancelarVentaVentaCliente.Location = new System.Drawing.Point(210, 145);
            this.btnCancelarVentaVentaCliente.Name = "btnCancelarVentaVentaCliente";
            this.btnCancelarVentaVentaCliente.Size = new System.Drawing.Size(111, 40);
            this.btnCancelarVentaVentaCliente.TabIndex = 15;
            this.btnCancelarVentaVentaCliente.Text = "Cancelar";
            this.btnCancelarVentaVentaCliente.UseVisualStyleBackColor = true;
            this.btnCancelarVentaVentaCliente.Click += new System.EventHandler(this.btnCancelarVentaVentaCliente_Click);
            // 
            // btnAceptarVentaVentaCliente
            // 
            this.btnAceptarVentaVentaCliente.Location = new System.Drawing.Point(78, 145);
            this.btnAceptarVentaVentaCliente.Name = "btnAceptarVentaVentaCliente";
            this.btnAceptarVentaVentaCliente.Size = new System.Drawing.Size(111, 40);
            this.btnAceptarVentaVentaCliente.TabIndex = 14;
            this.btnAceptarVentaVentaCliente.Text = "Aceptar";
            this.btnAceptarVentaVentaCliente.UseVisualStyleBackColor = true;
            this.btnAceptarVentaVentaCliente.Click += new System.EventHandler(this.btnAceptarVentaVentaCliente_Click);
            // 
            // txtCambioVentaVentaCliente
            // 
            this.txtCambioVentaVentaCliente.Location = new System.Drawing.Point(117, 100);
            this.txtCambioVentaVentaCliente.Name = "txtCambioVentaVentaCliente";
            this.txtCambioVentaVentaCliente.ReadOnly = true;
            this.txtCambioVentaVentaCliente.Size = new System.Drawing.Size(204, 26);
            this.txtCambioVentaVentaCliente.TabIndex = 13;
            // 
            // txtPrecioVentaVentaClientes
            // 
            this.txtPrecioVentaVentaClientes.Location = new System.Drawing.Point(117, 59);
            this.txtPrecioVentaVentaClientes.Name = "txtPrecioVentaVentaClientes";
            this.txtPrecioVentaVentaClientes.Size = new System.Drawing.Size(204, 26);
            this.txtPrecioVentaVentaClientes.TabIndex = 12;
            // 
            // txtTotalVentaVentaCliente
            // 
            this.txtTotalVentaVentaCliente.Location = new System.Drawing.Point(117, 18);
            this.txtTotalVentaVentaCliente.Name = "txtTotalVentaVentaCliente";
            this.txtTotalVentaVentaCliente.ReadOnly = true;
            this.txtTotalVentaVentaCliente.Size = new System.Drawing.Size(204, 26);
            this.txtTotalVentaVentaCliente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cambio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Ventas";
            // 
            // FrmClientesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 210);
            this.Controls.Add(this.btnCancelarVentaVentaCliente);
            this.Controls.Add(this.btnAceptarVentaVentaCliente);
            this.Controls.Add(this.txtCambioVentaVentaCliente);
            this.Controls.Add(this.txtPrecioVentaVentaClientes);
            this.Controls.Add(this.txtTotalVentaVentaCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmClientesVentas";
            this.Text = "Clientes Ventas";
            this.Load += new System.EventHandler(this.FrmClientesVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarVentaVentaCliente;
        private System.Windows.Forms.Button btnAceptarVentaVentaCliente;
        private System.Windows.Forms.TextBox txtCambioVentaVentaCliente;
        private System.Windows.Forms.TextBox txtPrecioVentaVentaClientes;
        private System.Windows.Forms.TextBox txtTotalVentaVentaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}