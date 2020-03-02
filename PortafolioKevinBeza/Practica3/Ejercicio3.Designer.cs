namespace Practica3
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
            this.lstTabla = new System.Windows.Forms.ListBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTabla
            // 
            this.lstTabla.FormattingEnabled = true;
            this.lstTabla.Location = new System.Drawing.Point(108, 49);
            this.lstTabla.Name = "lstTabla";
            this.lstTabla.Size = new System.Drawing.Size(120, 134);
            this.lstTabla.TabIndex = 0;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(124, 206);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lstTabla);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTabla;
        private System.Windows.Forms.Button btnLanzar;
    }
}