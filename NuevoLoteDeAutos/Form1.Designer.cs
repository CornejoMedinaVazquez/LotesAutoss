namespace NuevoLoteDeAutos
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPropietarioAutos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRol);
            this.groupBox1.Controls.Add(this.btnUsuario);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.btnPropietarioAutos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(185, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 68);
            this.button2.TabIndex = 5;
            this.button2.Tag = "5";
            this.button2.Text = "Permisos por Rol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 68);
            this.button1.TabIndex = 4;
            this.button1.Tag = "4";
            this.button1.Text = "Catalogo de ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRol
            // 
            this.btnRol.Enabled = false;
            this.btnRol.Location = new System.Drawing.Point(355, 103);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(164, 68);
            this.btnRol.TabIndex = 3;
            this.btnRol.Tag = "6";
            this.btnRol.Text = "Rol";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Enabled = false;
            this.btnUsuario.Location = new System.Drawing.Point(355, 20);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(164, 68);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Tag = "3";
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.Enabled = false;
            this.btnCliente.Location = new System.Drawing.Point(185, 20);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(164, 68);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Tag = "2";
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // btnPropietarioAutos
            // 
            this.btnPropietarioAutos.Enabled = false;
            this.btnPropietarioAutos.Location = new System.Drawing.Point(15, 20);
            this.btnPropietarioAutos.Name = "btnPropietarioAutos";
            this.btnPropietarioAutos.Size = new System.Drawing.Size(164, 68);
            this.btnPropietarioAutos.TabIndex = 0;
            this.btnPropietarioAutos.Tag = "1";
            this.btnPropietarioAutos.Text = "Propietarios y Autos";
            this.btnPropietarioAutos.UseVisualStyleBackColor = true;
            this.btnPropietarioAutos.Click += new System.EventHandler(this.btnPropietarioAutos_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 210);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.FrmMenu_Activated_1);
            this.Load += new System.EventHandler(this.FrmMenu_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPropietarioAutos;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

