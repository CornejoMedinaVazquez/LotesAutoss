namespace NuevoLoteDeAutos
{
    partial class FrmCatalogoUsuario
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
            this.btnAgregarCatalogoUsuario = new System.Windows.Forms.Button();
            this.btncancelarCatalogoUsuario = new System.Windows.Forms.Button();
            this.dgvCatalogoUsuario = new System.Windows.Forms.DataGridView();
            this.pkUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_pkRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarPorNombreCatalogoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarCatalogoUsuario = new System.Windows.Forms.Button();
            this.btnModificarCatalogoUsuario = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCatalogoUsuario
            // 
            this.btnAgregarCatalogoUsuario.Location = new System.Drawing.Point(111, 298);
            this.btnAgregarCatalogoUsuario.Name = "btnAgregarCatalogoUsuario";
            this.btnAgregarCatalogoUsuario.Size = new System.Drawing.Size(97, 39);
            this.btnAgregarCatalogoUsuario.TabIndex = 0;
            this.btnAgregarCatalogoUsuario.Text = "Agregar";
            this.btnAgregarCatalogoUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarCatalogoUsuario.Click += new System.EventHandler(this.btnAgregarCatalogoUsuario_Click);
            // 
            // btncancelarCatalogoUsuario
            // 
            this.btncancelarCatalogoUsuario.Location = new System.Drawing.Point(430, 298);
            this.btncancelarCatalogoUsuario.Name = "btncancelarCatalogoUsuario";
            this.btncancelarCatalogoUsuario.Size = new System.Drawing.Size(97, 39);
            this.btncancelarCatalogoUsuario.TabIndex = 1;
            this.btncancelarCatalogoUsuario.Text = "Cancelar";
            this.btncancelarCatalogoUsuario.UseVisualStyleBackColor = true;
            this.btncancelarCatalogoUsuario.Click += new System.EventHandler(this.btncancelarCatalogoUsuario_Click);
            // 
            // dgvCatalogoUsuario
            // 
            this.dgvCatalogoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkUsuario,
            this.sEmail,
            this.rol_pkRol});
            this.dgvCatalogoUsuario.Location = new System.Drawing.Point(12, 64);
            this.dgvCatalogoUsuario.Name = "dgvCatalogoUsuario";
            this.dgvCatalogoUsuario.Size = new System.Drawing.Size(515, 198);
            this.dgvCatalogoUsuario.TabIndex = 2;
            // 
            // pkUsuario
            // 
            this.pkUsuario.DataPropertyName = "pkUsuario";
            this.pkUsuario.HeaderText = "Codigo";
            this.pkUsuario.Name = "pkUsuario";
            this.pkUsuario.ReadOnly = true;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.ReadOnly = true;
            this.sEmail.Width = 270;
            // 
            // rol_pkRol
            // 
            this.rol_pkRol.DataPropertyName = "rol_pkRol";
            this.rol_pkRol.HeaderText = "rol_Rol";
            this.rol_pkRol.Name = "rol_pkRol";
            this.rol_pkRol.ReadOnly = true;
            // 
            // txtBuscarPorNombreCatalogoUsuario
            // 
            this.txtBuscarPorNombreCatalogoUsuario.Location = new System.Drawing.Point(12, 32);
            this.txtBuscarPorNombreCatalogoUsuario.Name = "txtBuscarPorNombreCatalogoUsuario";
            this.txtBuscarPorNombreCatalogoUsuario.Size = new System.Drawing.Size(416, 26);
            this.txtBuscarPorNombreCatalogoUsuario.TabIndex = 3;
            this.txtBuscarPorNombreCatalogoUsuario.TextChanged += new System.EventHandler(this.txtBuscarPorNombreCatalogoUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Por Nombre";
            // 
            // btnEliminarCatalogoUsuario
            // 
            this.btnEliminarCatalogoUsuario.Enabled = false;
            this.btnEliminarCatalogoUsuario.Location = new System.Drawing.Point(327, 298);
            this.btnEliminarCatalogoUsuario.Name = "btnEliminarCatalogoUsuario";
            this.btnEliminarCatalogoUsuario.Size = new System.Drawing.Size(97, 39);
            this.btnEliminarCatalogoUsuario.TabIndex = 5;
            this.btnEliminarCatalogoUsuario.Tag = "7";
            this.btnEliminarCatalogoUsuario.Text = "Eliminar";
            this.btnEliminarCatalogoUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarCatalogoUsuario.Click += new System.EventHandler(this.btnEliminarCatalogoUsuario_Click);
            // 
            // btnModificarCatalogoUsuario
            // 
            this.btnModificarCatalogoUsuario.Location = new System.Drawing.Point(214, 298);
            this.btnModificarCatalogoUsuario.Name = "btnModificarCatalogoUsuario";
            this.btnModificarCatalogoUsuario.Size = new System.Drawing.Size(97, 39);
            this.btnModificarCatalogoUsuario.TabIndex = 6;
            this.btnModificarCatalogoUsuario.Text = "Modificar";
            this.btnModificarCatalogoUsuario.UseVisualStyleBackColor = true;
            this.btnModificarCatalogoUsuario.Click += new System.EventHandler(this.btnModificarCatalogoUsuario_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(455, 268);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "status";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmCatalogoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnModificarCatalogoUsuario);
            this.Controls.Add(this.btnEliminarCatalogoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorNombreCatalogoUsuario);
            this.Controls.Add(this.dgvCatalogoUsuario);
            this.Controls.Add(this.btncancelarCatalogoUsuario);
            this.Controls.Add(this.btnAgregarCatalogoUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCatalogoUsuario";
            this.Text = "Catalogo Usuario";
            this.Activated += new System.EventHandler(this.FrmCatalogoUsuario_Activated);
            this.Load += new System.EventHandler(this.FrmCatalogoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCatalogoUsuario;
        private System.Windows.Forms.Button btncancelarCatalogoUsuario;
        private System.Windows.Forms.DataGridView dgvCatalogoUsuario;
        private System.Windows.Forms.TextBox txtBuscarPorNombreCatalogoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarCatalogoUsuario;
        private System.Windows.Forms.Button btnModificarCatalogoUsuario;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_pkRol;
    }
}