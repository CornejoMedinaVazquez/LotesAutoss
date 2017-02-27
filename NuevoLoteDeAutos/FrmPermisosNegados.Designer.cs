namespace NuevoLoteDeAutos
{
    partial class FrmPermisosNegados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pkPermisoNegadoRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permiso_pkPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_pkRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPermisoNegadoRol,
            this.permiso_pkPermiso,
            this.rol_pkRol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // pkPermisoNegadoRol
            // 
            this.pkPermisoNegadoRol.DataPropertyName = "pkPermisoNegadoRol";
            this.pkPermisoNegadoRol.HeaderText = "Codigo";
            this.pkPermisoNegadoRol.Name = "pkPermisoNegadoRol";
            // 
            // permiso_pkPermiso
            // 
            this.permiso_pkPermiso.DataPropertyName = "permiso_pkPermiso";
            this.permiso_pkPermiso.HeaderText = "Permiso";
            this.permiso_pkPermiso.Name = "permiso_pkPermiso";
            this.permiso_pkPermiso.Width = 300;
            // 
            // rol_pkRol
            // 
            this.rol_pkRol.DataPropertyName = "rol_pkRol";
            this.rol_pkRol.HeaderText = "Rol";
            this.rol_pkRol.Name = "rol_pkRol";
            this.rol_pkRol.Width = 250;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(714, 94);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 28);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(714, 60);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 28);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(714, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 28);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(720, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Status";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // FrmPermisosNegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 202);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPermisosNegados";
            this.Text = "Permisos Negados";
            this.Load += new System.EventHandler(this.FrmPermisosNegados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPermisoNegadoRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn permiso_pkPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_pkRol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}