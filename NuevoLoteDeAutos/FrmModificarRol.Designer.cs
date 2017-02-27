namespace NuevoLoteDeAutos
{
    partial class FrmModificarRol
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarNuevoRol = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(191, 197);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregarNuevoRol
            // 
            this.btnAgregarNuevoRol.Location = new System.Drawing.Point(12, 197);
            this.btnAgregarNuevoRol.Name = "btnAgregarNuevoRol";
            this.btnAgregarNuevoRol.Size = new System.Drawing.Size(173, 37);
            this.btnAgregarNuevoRol.TabIndex = 3;
            this.btnAgregarNuevoRol.Text = "Modificar  Rol";
            this.btnAgregarNuevoRol.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoRol.Click += new System.EventHandler(this.btnAgregarNuevoRol_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(8, 6);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(33, 20);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 96);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(343, 95);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(12, 29);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(343, 26);
            this.txtRol.TabIndex = 5;
            // 
            // FrmModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 244);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarNuevoRol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModificarRol";
            this.Text = "Modificar Rol";
            this.Load += new System.EventHandler(this.FrmModificarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarNuevoRol;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtRol;
    }
}