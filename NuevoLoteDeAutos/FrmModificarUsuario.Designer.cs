namespace NuevoLoteDeAutos
{
    partial class FrmModificarUsuario
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
            this.btnCancelarModificarUsuario = new System.Windows.Forms.Button();
            this.btbAceptarModificarUsuario = new System.Windows.Forms.Button();
            this.cmbRolModificarUsuario = new System.Windows.Forms.ComboBox();
            this.txtEmailModificarrUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenaModificarUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarModificarUsuario
            // 
            this.btnCancelarModificarUsuario.Location = new System.Drawing.Point(235, 128);
            this.btnCancelarModificarUsuario.Name = "btnCancelarModificarUsuario";
            this.btnCancelarModificarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btnCancelarModificarUsuario.TabIndex = 20;
            this.btnCancelarModificarUsuario.Text = "Cancelar";
            this.btnCancelarModificarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarModificarUsuario.Click += new System.EventHandler(this.btnCancelarModificarUsuario_Click);
            // 
            // btbAceptarModificarUsuario
            // 
            this.btbAceptarModificarUsuario.Location = new System.Drawing.Point(143, 128);
            this.btbAceptarModificarUsuario.Name = "btbAceptarModificarUsuario";
            this.btbAceptarModificarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btbAceptarModificarUsuario.TabIndex = 19;
            this.btbAceptarModificarUsuario.Text = "Aceptar";
            this.btbAceptarModificarUsuario.UseVisualStyleBackColor = true;
            this.btbAceptarModificarUsuario.Click += new System.EventHandler(this.btbAceptarModificarUsuario_Click);
            // 
            // cmbRolModificarUsuario
            // 
            this.cmbRolModificarUsuario.FormattingEnabled = true;
            this.cmbRolModificarUsuario.Location = new System.Drawing.Point(108, 94);
            this.cmbRolModificarUsuario.Name = "cmbRolModificarUsuario";
            this.cmbRolModificarUsuario.Size = new System.Drawing.Size(213, 28);
            this.cmbRolModificarUsuario.TabIndex = 18;
            // 
            // txtEmailModificarrUsuario
            // 
            this.txtEmailModificarrUsuario.Location = new System.Drawing.Point(108, 12);
            this.txtEmailModificarrUsuario.Name = "txtEmailModificarrUsuario";
            this.txtEmailModificarrUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtEmailModificarrUsuario.TabIndex = 17;
            // 
            // txtContrasenaModificarUsuario
            // 
            this.txtContrasenaModificarUsuario.Location = new System.Drawing.Point(108, 53);
            this.txtContrasenaModificarUsuario.Name = "txtContrasenaModificarUsuario";
            this.txtContrasenaModificarUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtContrasenaModificarUsuario.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // FrmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 181);
            this.Controls.Add(this.btnCancelarModificarUsuario);
            this.Controls.Add(this.btbAceptarModificarUsuario);
            this.Controls.Add(this.cmbRolModificarUsuario);
            this.Controls.Add(this.txtEmailModificarrUsuario);
            this.Controls.Add(this.txtContrasenaModificarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModificarUsuario";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.FrmModificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarModificarUsuario;
        private System.Windows.Forms.Button btbAceptarModificarUsuario;
        private System.Windows.Forms.ComboBox cmbRolModificarUsuario;
        private System.Windows.Forms.TextBox txtEmailModificarrUsuario;
        private System.Windows.Forms.TextBox txtContrasenaModificarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}