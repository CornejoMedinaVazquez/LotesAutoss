namespace NuevoLoteDeAutos
{
    partial class FrmCtalogoCliente
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
            this.btnModificarCatalogoCliente = new System.Windows.Forms.Button();
            this.btnEliminarCatalogoCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPorNombreCatalogoCliente = new System.Windows.Forms.TextBox();
            this.dgvCatalogoCliente = new System.Windows.Forms.DataGridView();
            this.pkIdcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelarCatalogoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarCatalogoCliente
            // 
            this.btnModificarCatalogoCliente.Location = new System.Drawing.Point(284, 291);
            this.btnModificarCatalogoCliente.Name = "btnModificarCatalogoCliente";
            this.btnModificarCatalogoCliente.Size = new System.Drawing.Size(97, 39);
            this.btnModificarCatalogoCliente.TabIndex = 13;
            this.btnModificarCatalogoCliente.Text = "Modificar";
            this.btnModificarCatalogoCliente.UseVisualStyleBackColor = true;
            this.btnModificarCatalogoCliente.Click += new System.EventHandler(this.btnModificarCatalogoCliente_Click);
            // 
            // btnEliminarCatalogoCliente
            // 
            this.btnEliminarCatalogoCliente.Enabled = false;
            this.btnEliminarCatalogoCliente.Location = new System.Drawing.Point(397, 291);
            this.btnEliminarCatalogoCliente.Name = "btnEliminarCatalogoCliente";
            this.btnEliminarCatalogoCliente.Size = new System.Drawing.Size(97, 39);
            this.btnEliminarCatalogoCliente.TabIndex = 12;
            this.btnEliminarCatalogoCliente.Tag = "7";
            this.btnEliminarCatalogoCliente.Text = "Eliminar";
            this.btnEliminarCatalogoCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCatalogoCliente.Click += new System.EventHandler(this.btnEliminarCatalogoCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar Por Nombre";
            // 
            // txtBuscarPorNombreCatalogoCliente
            // 
            this.txtBuscarPorNombreCatalogoCliente.Location = new System.Drawing.Point(12, 32);
            this.txtBuscarPorNombreCatalogoCliente.Name = "txtBuscarPorNombreCatalogoCliente";
            this.txtBuscarPorNombreCatalogoCliente.Size = new System.Drawing.Size(444, 26);
            this.txtBuscarPorNombreCatalogoCliente.TabIndex = 10;
            this.txtBuscarPorNombreCatalogoCliente.TextChanged += new System.EventHandler(this.txtBuscarPorNombreCatalogoCliente_TextChanged);
            // 
            // dgvCatalogoCliente
            // 
            this.dgvCatalogoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkIdcliente,
            this.sNombre,
            this.sDireccion});
            this.dgvCatalogoCliente.Location = new System.Drawing.Point(12, 64);
            this.dgvCatalogoCliente.Name = "dgvCatalogoCliente";
            this.dgvCatalogoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogoCliente.Size = new System.Drawing.Size(585, 198);
            this.dgvCatalogoCliente.TabIndex = 9;
            this.dgvCatalogoCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogoCliente_CellDoubleClick);
            // 
            // pkIdcliente
            // 
            this.pkIdcliente.DataPropertyName = "pkcliente";
            this.pkIdcliente.HeaderText = "Id del cliente";
            this.pkIdcliente.Name = "pkIdcliente";
            this.pkIdcliente.Width = 57;
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "sNombre";
            this.sNombre.HeaderText = "Nombre del cliente";
            this.sNombre.Name = "sNombre";
            this.sNombre.Width = 185;
            // 
            // sDireccion
            // 
            this.sDireccion.DataPropertyName = "sDireccion";
            this.sDireccion.HeaderText = "Direccion";
            this.sDireccion.Name = "sDireccion";
            this.sDireccion.Width = 300;
            // 
            // btncancelarCatalogoCliente
            // 
            this.btncancelarCatalogoCliente.Location = new System.Drawing.Point(500, 291);
            this.btncancelarCatalogoCliente.Name = "btncancelarCatalogoCliente";
            this.btncancelarCatalogoCliente.Size = new System.Drawing.Size(97, 39);
            this.btncancelarCatalogoCliente.TabIndex = 8;
            this.btncancelarCatalogoCliente.Text = "Cancelar";
            this.btncancelarCatalogoCliente.UseVisualStyleBackColor = true;
            this.btncancelarCatalogoCliente.Click += new System.EventHandler(this.btncancelarCatalogoCliente_Click);
            // 
            // FrmCtalogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 357);
            this.Controls.Add(this.btnModificarCatalogoCliente);
            this.Controls.Add(this.btnEliminarCatalogoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorNombreCatalogoCliente);
            this.Controls.Add(this.dgvCatalogoCliente);
            this.Controls.Add(this.btncancelarCatalogoCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCtalogoCliente";
            this.Text = "Catalogo Cliente";
            this.Activated += new System.EventHandler(this.FrmCtalogoCliente_Activated);
            this.Load += new System.EventHandler(this.FrmCtalogoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCatalogoCliente;
        private System.Windows.Forms.Button btnEliminarCatalogoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPorNombreCatalogoCliente;
        private System.Windows.Forms.DataGridView dgvCatalogoCliente;
        private System.Windows.Forms.Button btncancelarCatalogoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkIdcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDireccion;
    }
}