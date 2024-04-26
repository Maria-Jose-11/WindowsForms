
namespace ConsumoApi
{
    partial class Form1
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
            this.btnObtenerInfo = new System.Windows.Forms.Button();
            this.dgbPersonajes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtenerInfo
            // 
            this.btnObtenerInfo.Location = new System.Drawing.Point(260, 219);
            this.btnObtenerInfo.Name = "btnObtenerInfo";
            this.btnObtenerInfo.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerInfo.TabIndex = 0;
            this.btnObtenerInfo.Text = "Obtener Info";
            this.btnObtenerInfo.UseVisualStyleBackColor = true;
            this.btnObtenerInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgbPersonajes
            // 
            this.dgbPersonajes.AllowUserToAddRows = false;
            this.dgbPersonajes.AllowUserToDeleteRows = false;
            this.dgbPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPersonajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Genero,
            this.Especie,
            this.Origen});
            this.dgbPersonajes.Location = new System.Drawing.Point(12, 12);
            this.dgbPersonajes.Name = "dgbPersonajes";
            this.dgbPersonajes.ReadOnly = true;
            this.dgbPersonajes.Size = new System.Drawing.Size(559, 210);
            this.dgbPersonajes.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 255;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbPersonajes);
            this.Controls.Add(this.btnObtenerInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbPersonajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerInfo;
        private System.Windows.Forms.DataGridView dgbPersonajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
    }
}

