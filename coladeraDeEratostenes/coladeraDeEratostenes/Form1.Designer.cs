namespace coladeraDeEratostenes
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
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.cmdCalcularPrimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(201, 74);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(220, 373);
            this.txtSalida.TabIndex = 0;
            // 
            // cmdCalcularPrimo
            // 
            this.cmdCalcularPrimo.Location = new System.Drawing.Point(201, 12);
            this.cmdCalcularPrimo.Name = "cmdCalcularPrimo";
            this.cmdCalcularPrimo.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcularPrimo.TabIndex = 1;
            this.cmdCalcularPrimo.Text = "Primos!!";
            this.cmdCalcularPrimo.UseVisualStyleBackColor = true;
            this.cmdCalcularPrimo.Click += new System.EventHandler(this.cmdCalcularPrimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCalcularPrimo);
            this.Controls.Add(this.txtSalida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button cmdCalcularPrimo;
    }
}

