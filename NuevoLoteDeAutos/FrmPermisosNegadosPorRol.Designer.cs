namespace NuevoLoteDeAutos
{
    partial class FrmPermisosNegadosPorRol
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
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.btnBuscarRol = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permisos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Roles";
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(16, 32);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(326, 28);
            this.cmbPermisos.TabIndex = 1;
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(12, 86);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(285, 28);
            this.cmbRoles.TabIndex = 2;
            // 
            // btnBuscarRol
            // 
            this.btnBuscarRol.Location = new System.Drawing.Point(348, 12);
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.Size = new System.Drawing.Size(131, 47);
            this.btnBuscarRol.TabIndex = 3;
            this.btnBuscarRol.Text = "Buscar";
            this.btnBuscarRol.UseVisualStyleBackColor = true;
            this.btnBuscarRol.Click += new System.EventHandler(this.btnBuscarRol_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 153);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 46);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Permiso";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(180, 153);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir De Permisos";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPermisosNegadosPorRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 211);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscarRol);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.cmbPermisos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisosNegadosPorRol";
            this.Text = "Permisos Negados Por Rol";
            this.Load += new System.EventHandler(this.FrmPermisosNegadosPorRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Button btnBuscarRol;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
    }
}