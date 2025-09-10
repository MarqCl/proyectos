namespace prBonificacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkbonificacion = new System.Windows.Forms.CheckBox();
            this.nphijos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpagohextras = new System.Windows.Forms.TextBox();
            this.txtpagohnormal = new System.Windows.Forms.TextBox();
            this.txthorasextras = new System.Windows.Forms.TextBox();
            this.txthorasnormales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsueldoneto = new System.Windows.Forms.TextBox();
            this.txtbonificacion = new System.Windows.Forms.TextBox();
            this.txtsueldobruto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btsalir);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtpagohextras);
            this.groupBox1.Controls.Add(this.txtpagohnormal);
            this.groupBox1.Controls.Add(this.txthorasextras);
            this.groupBox1.Controls.Add(this.txthorasnormales);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "jornada laboral";
            // 
            // btsalir
            // 
            this.btsalir.BackColor = System.Drawing.Color.DarkGreen;
            this.btsalir.ForeColor = System.Drawing.Color.White;
            this.btsalir.Location = new System.Drawing.Point(279, 261);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(75, 34);
            this.btsalir.TabIndex = 10;
            this.btsalir.Text = "salir";
            this.btsalir.UseVisualStyleBackColor = false;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.DarkGreen;
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(169, 261);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 34);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnnuevo.ForeColor = System.Drawing.Color.White;
            this.btnnuevo.Location = new System.Drawing.Point(49, 261);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 34);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "nuevo";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkbonificacion);
            this.groupBox3.Controls.Add(this.nphijos);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(33, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 80);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // chkbonificacion
            // 
            this.chkbonificacion.AutoSize = true;
            this.chkbonificacion.Location = new System.Drawing.Point(207, 31);
            this.chkbonificacion.Name = "chkbonificacion";
            this.chkbonificacion.Size = new System.Drawing.Size(114, 17);
            this.chkbonificacion.TabIndex = 10;
            this.chkbonificacion.Text = "recibir bonificacion";
            this.chkbonificacion.UseVisualStyleBackColor = true;
            // 
            // nphijos
            // 
            this.nphijos.Location = new System.Drawing.Point(97, 29);
            this.nphijos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nphijos.Name = "nphijos";
            this.nphijos.Size = new System.Drawing.Size(75, 20);
            this.nphijos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "numero de hijos:";
            // 
            // txtpagohextras
            // 
            this.txtpagohextras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpagohextras.Location = new System.Drawing.Point(358, 139);
            this.txtpagohextras.Name = "txtpagohextras";
            this.txtpagohextras.Size = new System.Drawing.Size(134, 20);
            this.txtpagohextras.TabIndex = 7;
            // 
            // txtpagohnormal
            // 
            this.txtpagohnormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpagohnormal.Location = new System.Drawing.Point(357, 73);
            this.txtpagohnormal.Name = "txtpagohnormal";
            this.txtpagohnormal.Size = new System.Drawing.Size(135, 20);
            this.txtpagohnormal.TabIndex = 6;
            // 
            // txthorasextras
            // 
            this.txthorasextras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthorasextras.Location = new System.Drawing.Point(33, 139);
            this.txthorasextras.Name = "txthorasextras";
            this.txthorasextras.Size = new System.Drawing.Size(172, 20);
            this.txthorasextras.TabIndex = 5;
            // 
            // txthorasnormales
            // 
            this.txthorasnormales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthorasnormales.Location = new System.Drawing.Point(30, 63);
            this.txthorasnormales.Name = "txthorasnormales";
            this.txthorasnormales.Size = new System.Drawing.Size(175, 20);
            this.txthorasnormales.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "pago por hora extra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "pago por hora normal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "horas extras trabajadas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "horas normales trabajadas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsueldoneto);
            this.groupBox2.Controls.Add(this.txtbonificacion);
            this.groupBox2.Controls.Add(this.txtsueldobruto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sueldo";
            // 
            // txtsueldoneto
            // 
            this.txtsueldoneto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsueldoneto.Location = new System.Drawing.Point(118, 110);
            this.txtsueldoneto.Name = "txtsueldoneto";
            this.txtsueldoneto.Size = new System.Drawing.Size(126, 20);
            this.txtsueldoneto.TabIndex = 5;
            // 
            // txtbonificacion
            // 
            this.txtbonificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbonificacion.Location = new System.Drawing.Point(118, 71);
            this.txtbonificacion.Name = "txtbonificacion";
            this.txtbonificacion.Size = new System.Drawing.Size(126, 20);
            this.txtbonificacion.TabIndex = 4;
            // 
            // txtsueldobruto
            // 
            this.txtsueldobruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsueldobruto.Location = new System.Drawing.Point(118, 29);
            this.txtsueldobruto.Name = "txtsueldobruto";
            this.txtsueldobruto.Size = new System.Drawing.Size(126, 20);
            this.txtsueldobruto.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "sueldo neto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "boinificacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "sueldo bruto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bonificación";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nphijos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkbonificacion;
        private System.Windows.Forms.NumericUpDown nphijos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpagohextras;
        private System.Windows.Forms.TextBox txtpagohnormal;
        private System.Windows.Forms.TextBox txthorasextras;
        private System.Windows.Forms.TextBox txthorasnormales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsueldoneto;
        private System.Windows.Forms.TextBox txtbonificacion;
        private System.Windows.Forms.TextBox txtsueldobruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

