namespace NuevoLoteDeAutos
{
    partial class FrmAgregarUsuario
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasenaAgregarUsuario = new System.Windows.Forms.TextBox();
            this.txtEmailAgregarUsuario = new System.Windows.Forms.TextBox();
            this.cmbRolAgregarUsuario = new System.Windows.Forms.ComboBox();
            this.btbAceptarAgregarUsuario = new System.Windows.Forms.Button();
            this.btnCancelarAgregarUsuario = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // txtContrasenaAgregarUsuario
            // 
            this.txtContrasenaAgregarUsuario.Location = new System.Drawing.Point(113, 57);
            this.txtContrasenaAgregarUsuario.Name = "txtContrasenaAgregarUsuario";
            this.txtContrasenaAgregarUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtContrasenaAgregarUsuario.TabIndex = 6;
            // 
            // txtEmailAgregarUsuario
            // 
            this.txtEmailAgregarUsuario.Location = new System.Drawing.Point(113, 16);
            this.txtEmailAgregarUsuario.Name = "txtEmailAgregarUsuario";
            this.txtEmailAgregarUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtEmailAgregarUsuario.TabIndex = 7;
            // 
            // cmbRolAgregarUsuario
            // 
            this.cmbRolAgregarUsuario.FormattingEnabled = true;
            this.cmbRolAgregarUsuario.Location = new System.Drawing.Point(113, 98);
            this.cmbRolAgregarUsuario.Name = "cmbRolAgregarUsuario";
            this.cmbRolAgregarUsuario.Size = new System.Drawing.Size(213, 28);
            this.cmbRolAgregarUsuario.TabIndex = 8;
            this.cmbRolAgregarUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbRolAgregarUsuario_SelectedIndexChanged);
            // 
            // btbAceptarAgregarUsuario
            // 
            this.btbAceptarAgregarUsuario.Location = new System.Drawing.Point(148, 132);
            this.btbAceptarAgregarUsuario.Name = "btbAceptarAgregarUsuario";
            this.btbAceptarAgregarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btbAceptarAgregarUsuario.TabIndex = 9;
            this.btbAceptarAgregarUsuario.Text = "Agregar";
            this.btbAceptarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btbAceptarAgregarUsuario.Click += new System.EventHandler(this.btbAceptarAgregarUsuario_Click);
            // 
            // btnCancelarAgregarUsuario
            // 
            this.btnCancelarAgregarUsuario.Location = new System.Drawing.Point(240, 132);
            this.btnCancelarAgregarUsuario.Name = "btnCancelarAgregarUsuario";
            this.btnCancelarAgregarUsuario.Size = new System.Drawing.Size(86, 39);
            this.btnCancelarAgregarUsuario.TabIndex = 10;
            this.btnCancelarAgregarUsuario.Text = "Cancelar";
            this.btnCancelarAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarUsuario.Click += new System.EventHandler(this.btnCancelarAgregarUsuario_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 185);
            this.Controls.Add(this.btnCancelarAgregarUsuario);
            this.Controls.Add(this.btbAceptarAgregarUsuario);
            this.Controls.Add(this.cmbRolAgregarUsuario);
            this.Controls.Add(this.txtEmailAgregarUsuario);
            this.Controls.Add(this.txtContrasenaAgregarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAgregarUsuario";
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.FrmAgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContrasenaAgregarUsuario;
        private System.Windows.Forms.TextBox txtEmailAgregarUsuario;
        private System.Windows.Forms.ComboBox cmbRolAgregarUsuario;
        private System.Windows.Forms.Button btbAceptarAgregarUsuario;
        private System.Windows.Forms.Button btnCancelarAgregarUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}