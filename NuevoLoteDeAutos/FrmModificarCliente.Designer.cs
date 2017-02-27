namespace NuevoLoteDeAutos
{
    partial class FrmModificarCliente
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
            this.txtNombreCompletoModificarCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCompletaModificarCliente = new System.Windows.Forms.TextBox();
            this.btnAceptarModificarCliente = new System.Windows.Forms.Button();
            this.btnCancelarModificarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion Completa";
            // 
            // txtNombreCompletoModificarCliente
            // 
            this.txtNombreCompletoModificarCliente.Location = new System.Drawing.Point(12, 32);
            this.txtNombreCompletoModificarCliente.Name = "txtNombreCompletoModificarCliente";
            this.txtNombreCompletoModificarCliente.Size = new System.Drawing.Size(281, 26);
            this.txtNombreCompletoModificarCliente.TabIndex = 3;
            // 
            // txtDireccionCompletaModificarCliente
            // 
            this.txtDireccionCompletaModificarCliente.Location = new System.Drawing.Point(12, 105);
            this.txtDireccionCompletaModificarCliente.Name = "txtDireccionCompletaModificarCliente";
            this.txtDireccionCompletaModificarCliente.Size = new System.Drawing.Size(281, 26);
            this.txtDireccionCompletaModificarCliente.TabIndex = 4;
            // 
            // btnAceptarModificarCliente
            // 
            this.btnAceptarModificarCliente.Location = new System.Drawing.Point(223, 169);
            this.btnAceptarModificarCliente.Name = "btnAceptarModificarCliente";
            this.btnAceptarModificarCliente.Size = new System.Drawing.Size(96, 36);
            this.btnAceptarModificarCliente.TabIndex = 6;
            this.btnAceptarModificarCliente.Text = "Aceptar";
            this.btnAceptarModificarCliente.UseVisualStyleBackColor = true;
            this.btnAceptarModificarCliente.Click += new System.EventHandler(this.btnAceptarModificarCliente_Click);
            // 
            // btnCancelarModificarCliente
            // 
            this.btnCancelarModificarCliente.Location = new System.Drawing.Point(325, 169);
            this.btnCancelarModificarCliente.Name = "btnCancelarModificarCliente";
            this.btnCancelarModificarCliente.Size = new System.Drawing.Size(96, 36);
            this.btnCancelarModificarCliente.TabIndex = 7;
            this.btnCancelarModificarCliente.Text = "Cancelar";
            this.btnCancelarModificarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarModificarCliente.Click += new System.EventHandler(this.btnCancelarModificarCliente_Click);
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 217);
            this.Controls.Add(this.btnCancelarModificarCliente);
            this.Controls.Add(this.btnAceptarModificarCliente);
            this.Controls.Add(this.txtDireccionCompletaModificarCliente);
            this.Controls.Add(this.txtNombreCompletoModificarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModificarCliente";
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.FrmModificarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCompletoModificarCliente;
        private System.Windows.Forms.TextBox txtDireccionCompletaModificarCliente;
        private System.Windows.Forms.Button btnAceptarModificarCliente;
        private System.Windows.Forms.Button btnCancelarModificarCliente;
    }
}