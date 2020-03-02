namespace Practica2
{
    partial class Ejercicio2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDescuento1 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento2 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento3 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento4 = new System.Windows.Forms.RadioButton();
            this.rdoDescuento5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(168, 32);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(168, 70);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(156, 119);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(168, 207);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(168, 246);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(80, 344);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(214, 344);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDescuento5);
            this.groupBox1.Controls.Add(this.rdoDescuento4);
            this.groupBox1.Controls.Add(this.rdoDescuento3);
            this.groupBox1.Controls.Add(this.rdoDescuento2);
            this.groupBox1.Controls.Add(this.rdoDescuento1);
            this.groupBox1.Location = new System.Drawing.Point(453, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuento:";
            // 
            // rdoDescuento1
            // 
            this.rdoDescuento1.AutoSize = true;
            this.rdoDescuento1.Location = new System.Drawing.Point(22, 19);
            this.rdoDescuento1.Name = "rdoDescuento1";
            this.rdoDescuento1.Size = new System.Drawing.Size(39, 17);
            this.rdoDescuento1.TabIndex = 0;
            this.rdoDescuento1.TabStop = true;
            this.rdoDescuento1.Text = "0%";
            this.rdoDescuento1.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento2
            // 
            this.rdoDescuento2.AutoSize = true;
            this.rdoDescuento2.Location = new System.Drawing.Point(22, 42);
            this.rdoDescuento2.Name = "rdoDescuento2";
            this.rdoDescuento2.Size = new System.Drawing.Size(39, 17);
            this.rdoDescuento2.TabIndex = 1;
            this.rdoDescuento2.TabStop = true;
            this.rdoDescuento2.Text = "5%";
            this.rdoDescuento2.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento3
            // 
            this.rdoDescuento3.AutoSize = true;
            this.rdoDescuento3.Location = new System.Drawing.Point(22, 65);
            this.rdoDescuento3.Name = "rdoDescuento3";
            this.rdoDescuento3.Size = new System.Drawing.Size(45, 17);
            this.rdoDescuento3.TabIndex = 2;
            this.rdoDescuento3.TabStop = true;
            this.rdoDescuento3.Text = "10%";
            this.rdoDescuento3.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento4
            // 
            this.rdoDescuento4.AutoSize = true;
            this.rdoDescuento4.Location = new System.Drawing.Point(22, 88);
            this.rdoDescuento4.Name = "rdoDescuento4";
            this.rdoDescuento4.Size = new System.Drawing.Size(45, 17);
            this.rdoDescuento4.TabIndex = 3;
            this.rdoDescuento4.TabStop = true;
            this.rdoDescuento4.Text = "15%";
            this.rdoDescuento4.UseVisualStyleBackColor = true;
            // 
            // rdoDescuento5
            // 
            this.rdoDescuento5.AutoSize = true;
            this.rdoDescuento5.Location = new System.Drawing.Point(22, 111);
            this.rdoDescuento5.Name = "rdoDescuento5";
            this.rdoDescuento5.Size = new System.Drawing.Size(45, 17);
            this.rdoDescuento5.TabIndex = 4;
            this.rdoDescuento5.TabStop = true;
            this.rdoDescuento5.Text = "20%";
            this.rdoDescuento5.UseVisualStyleBackColor = true;
            this.rdoDescuento5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDescuento5;
        private System.Windows.Forms.RadioButton rdoDescuento4;
        private System.Windows.Forms.RadioButton rdoDescuento3;
        private System.Windows.Forms.RadioButton rdoDescuento2;
        private System.Windows.Forms.RadioButton rdoDescuento1;
    }
}