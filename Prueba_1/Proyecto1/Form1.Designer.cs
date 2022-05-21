namespace Proyecto1
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
            this.lBlArchivos = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMaster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBlArchivos
            // 
            this.lBlArchivos.FormattingEnabled = true;
            this.lBlArchivos.Location = new System.Drawing.Point(12, 89);
            this.lBlArchivos.Name = "lBlArchivos";
            this.lBlArchivos.ScrollAlwaysVisible = true;
            this.lBlArchivos.Size = new System.Drawing.Size(228, 303);
            this.lBlArchivos.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Archivos Excel",
            "Otros"});
            this.comboBox1.Location = new System.Drawing.Point(12, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnMaster
            // 
            this.btnMaster.Location = new System.Drawing.Point(262, 47);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(102, 21);
            this.btnMaster.TabIndex = 2;
            this.btnMaster.Text = "Abrir Master";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 424);
            this.Controls.Add(this.btnMaster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lBlArchivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Reader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBlArchivos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMaster;
    }
}

