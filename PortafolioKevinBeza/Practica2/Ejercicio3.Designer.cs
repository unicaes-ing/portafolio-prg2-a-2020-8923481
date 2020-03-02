namespace Practica2
{
    partial class Ejercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConver = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoPulgadas = new System.Windows.Forms.RadioButton();
            this.rdoPies = new System.Windows.Forms.RadioButton();
            this.rdoYardas = new System.Windows.Forms.RadioButton();
            this.rdoPulgadas1 = new System.Windows.Forms.RadioButton();
            this.rdoPies2 = new System.Windows.Forms.RadioButton();
            this.rdoYardas3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca la longitud a convertir:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(282, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longitud Convertida:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtConver
            // 
            this.txtConver.Location = new System.Drawing.Point(209, 287);
            this.txtConver.Name = "txtConver";
            this.txtConver.Size = new System.Drawing.Size(100, 20);
            this.txtConver.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(82, 352);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(209, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoYardas);
            this.groupBox1.Controls.Add(this.rdoPies);
            this.groupBox1.Controls.Add(this.rdoPulgadas);
            this.groupBox1.Location = new System.Drawing.Point(60, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoYardas3);
            this.groupBox2.Controls.Add(this.rdoPies2);
            this.groupBox2.Controls.Add(this.rdoPulgadas1);
            this.groupBox2.Location = new System.Drawing.Point(324, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A:";
            // 
            // rdoPulgadas
            // 
            this.rdoPulgadas.AutoSize = true;
            this.rdoPulgadas.Location = new System.Drawing.Point(19, 19);
            this.rdoPulgadas.Name = "rdoPulgadas";
            this.rdoPulgadas.Size = new System.Drawing.Size(69, 17);
            this.rdoPulgadas.TabIndex = 8;
            this.rdoPulgadas.TabStop = true;
            this.rdoPulgadas.Text = "Pulgadas";
            this.rdoPulgadas.UseVisualStyleBackColor = true;
            // 
            // rdoPies
            // 
            this.rdoPies.AutoSize = true;
            this.rdoPies.Location = new System.Drawing.Point(19, 48);
            this.rdoPies.Name = "rdoPies";
            this.rdoPies.Size = new System.Drawing.Size(45, 17);
            this.rdoPies.TabIndex = 9;
            this.rdoPies.TabStop = true;
            this.rdoPies.Text = "Pies";
            this.rdoPies.UseVisualStyleBackColor = true;
            // 
            // rdoYardas
            // 
            this.rdoYardas.AutoSize = true;
            this.rdoYardas.Location = new System.Drawing.Point(19, 77);
            this.rdoYardas.Name = "rdoYardas";
            this.rdoYardas.Size = new System.Drawing.Size(58, 17);
            this.rdoYardas.TabIndex = 10;
            this.rdoYardas.TabStop = true;
            this.rdoYardas.Text = "Yardas";
            this.rdoYardas.UseVisualStyleBackColor = true;
            // 
            // rdoPulgadas1
            // 
            this.rdoPulgadas1.AutoSize = true;
            this.rdoPulgadas1.Location = new System.Drawing.Point(29, 19);
            this.rdoPulgadas1.Name = "rdoPulgadas1";
            this.rdoPulgadas1.Size = new System.Drawing.Size(69, 17);
            this.rdoPulgadas1.TabIndex = 0;
            this.rdoPulgadas1.TabStop = true;
            this.rdoPulgadas1.Text = "Pulgadas";
            this.rdoPulgadas1.UseVisualStyleBackColor = true;
            // 
            // rdoPies2
            // 
            this.rdoPies2.AutoSize = true;
            this.rdoPies2.Location = new System.Drawing.Point(29, 48);
            this.rdoPies2.Name = "rdoPies2";
            this.rdoPies2.Size = new System.Drawing.Size(45, 17);
            this.rdoPies2.TabIndex = 1;
            this.rdoPies2.TabStop = true;
            this.rdoPies2.Text = "Pies";
            this.rdoPies2.UseVisualStyleBackColor = true;
            // 
            // rdoYardas3
            // 
            this.rdoYardas3.AutoSize = true;
            this.rdoYardas3.Location = new System.Drawing.Point(29, 77);
            this.rdoYardas3.Name = "rdoYardas3";
            this.rdoYardas3.Size = new System.Drawing.Size(58, 17);
            this.rdoYardas3.TabIndex = 2;
            this.rdoYardas3.TabStop = true;
            this.rdoYardas3.Text = "Yardas";
            this.rdoYardas3.UseVisualStyleBackColor = true;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtConver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConver;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoYardas;
        private System.Windows.Forms.RadioButton rdoPies;
        private System.Windows.Forms.RadioButton rdoPulgadas;
        private System.Windows.Forms.RadioButton rdoYardas3;
        private System.Windows.Forms.RadioButton rdoPies2;
        private System.Windows.Forms.RadioButton rdoPulgadas1;
    }
}