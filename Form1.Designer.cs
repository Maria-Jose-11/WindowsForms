
namespace IntroduccionWindowsForms
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(69, 143);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(332, 150);
            this.GridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 109);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(145, 63);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(256, 20);
            this.txtCedula.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(145, 102);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(77, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(66, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PROGRAMA DE INSTRODUCCIÓN A WINDOWS FORMS";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(438, 49);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(438, 78);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

