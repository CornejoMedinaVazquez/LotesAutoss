namespace NuevoLoteDeAutos
{
    partial class FromVentasPropietarioAuto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalVentaVentaPropietarioAuto = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaVentaPropietarioAuto = new System.Windows.Forms.TextBox();
            this.txtCambioVentaVentaPropietarioAuto = new System.Windows.Forms.TextBox();
            this.btnAceptarVentaVentaPropietarioAuto = new System.Windows.Forms.Button();
            this.btnCancelarVentaVentaPropietarioAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cambio";
            // 
            // txtTotalVentaVentaPropietarioAuto
            // 
            this.txtTotalVentaVentaPropietarioAuto.Location = new System.Drawing.Point(117, 24);
            this.txtTotalVentaVentaPropietarioAuto.Name = "txtTotalVentaVentaPropietarioAuto";
            this.txtTotalVentaVentaPropietarioAuto.ReadOnly = true;
            this.txtTotalVentaVentaPropietarioAuto.Size = new System.Drawing.Size(204, 26);
            this.txtTotalVentaVentaPropietarioAuto.TabIndex = 3;
            this.txtTotalVentaVentaPropietarioAuto.Text = "$ 200";
            // 
            // txtPrecioVentaVentaPropietarioAuto
            // 
            this.txtPrecioVentaVentaPropietarioAuto.Location = new System.Drawing.Point(117, 65);
            this.txtPrecioVentaVentaPropietarioAuto.Name = "txtPrecioVentaVentaPropietarioAuto";
            this.txtPrecioVentaVentaPropietarioAuto.Size = new System.Drawing.Size(204, 26);
            this.txtPrecioVentaVentaPropietarioAuto.TabIndex = 4;
            // 
            // txtCambioVentaVentaPropietarioAuto
            // 
            this.txtCambioVentaVentaPropietarioAuto.Location = new System.Drawing.Point(117, 106);
            this.txtCambioVentaVentaPropietarioAuto.Name = "txtCambioVentaVentaPropietarioAuto";
            this.txtCambioVentaVentaPropietarioAuto.ReadOnly = true;
            this.txtCambioVentaVentaPropietarioAuto.Size = new System.Drawing.Size(204, 26);
            this.txtCambioVentaVentaPropietarioAuto.TabIndex = 5;
            // 
            // btnAceptarVentaVentaPropietarioAuto
            // 
            this.btnAceptarVentaVentaPropietarioAuto.Location = new System.Drawing.Point(78, 151);
            this.btnAceptarVentaVentaPropietarioAuto.Name = "btnAceptarVentaVentaPropietarioAuto";
            this.btnAceptarVentaVentaPropietarioAuto.Size = new System.Drawing.Size(111, 40);
            this.btnAceptarVentaVentaPropietarioAuto.TabIndex = 6;
            this.btnAceptarVentaVentaPropietarioAuto.Text = "Aceptar";
            this.btnAceptarVentaVentaPropietarioAuto.UseVisualStyleBackColor = true;
            this.btnAceptarVentaVentaPropietarioAuto.Click += new System.EventHandler(this.btnAceptarVentaVentaPropietarioAuto_Click);
            // 
            // btnCancelarVentaVentaPropietarioAuto
            // 
            this.btnCancelarVentaVentaPropietarioAuto.Location = new System.Drawing.Point(210, 151);
            this.btnCancelarVentaVentaPropietarioAuto.Name = "btnCancelarVentaVentaPropietarioAuto";
            this.btnCancelarVentaVentaPropietarioAuto.Size = new System.Drawing.Size(111, 40);
            this.btnCancelarVentaVentaPropietarioAuto.TabIndex = 7;
            this.btnCancelarVentaVentaPropietarioAuto.Text = "Cancelar";
            this.btnCancelarVentaVentaPropietarioAuto.UseVisualStyleBackColor = true;
            this.btnCancelarVentaVentaPropietarioAuto.Click += new System.EventHandler(this.btnCancelarVentaVentaPropietarioAuto_Click);
            // 
            // FromVentasPropietarioAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 207);
            this.Controls.Add(this.btnCancelarVentaVentaPropietarioAuto);
            this.Controls.Add(this.btnAceptarVentaVentaPropietarioAuto);
            this.Controls.Add(this.txtCambioVentaVentaPropietarioAuto);
            this.Controls.Add(this.txtPrecioVentaVentaPropietarioAuto);
            this.Controls.Add(this.txtTotalVentaVentaPropietarioAuto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FromVentasPropietarioAuto";
            this.Text = "Ventas Propietario Auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalVentaVentaPropietarioAuto;
        private System.Windows.Forms.TextBox txtPrecioVentaVentaPropietarioAuto;
        private System.Windows.Forms.TextBox txtCambioVentaVentaPropietarioAuto;
        private System.Windows.Forms.Button btnAceptarVentaVentaPropietarioAuto;
        private System.Windows.Forms.Button btnCancelarVentaVentaPropietarioAuto;
    }
}