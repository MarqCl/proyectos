namespace prcontroltimer
{
    partial class Form2
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
            this.btingresar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btingresar
            // 
            this.btingresar.Location = new System.Drawing.Point(169, 97);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(153, 54);
            this.btingresar.TabIndex = 0;
            this.btingresar.Text = "ingresar datos";
            this.btingresar.UseVisualStyleBackColor = true;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(356, 175);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 62);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "btnsalir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 261);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btingresar);
            this.Name = "Form2";
            this.Text = "cuadros  de mensaje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btingresar;
        private System.Windows.Forms.Button btnsalir;
    }
}