namespace pintar
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
            this.cmdGirarDerecha = new System.Windows.Forms.Button();
            this.cmdGirarIzquierda = new System.Windows.Forms.Button();
            this.cmdArriba = new System.Windows.Forms.Button();
            this.cmdAbajo = new System.Windows.Forms.Button();
            this.cmdAvanzar = new System.Windows.Forms.Button();
            this.txtOrientacion = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.cmdPosicionActual = new System.Windows.Forms.Button();
            this.cmdOrientacion = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(181, 180);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(516, 320);
            this.txtSalida.TabIndex = 0;
            // 
            // cmdGirarDerecha
            // 
            this.cmdGirarDerecha.AutoSize = true;
            this.cmdGirarDerecha.Location = new System.Drawing.Point(12, 65);
            this.cmdGirarDerecha.Name = "cmdGirarDerecha";
            this.cmdGirarDerecha.Size = new System.Drawing.Size(89, 23);
            this.cmdGirarDerecha.TabIndex = 1;
            this.cmdGirarDerecha.Text = "Girara Derecha";
            this.cmdGirarDerecha.UseVisualStyleBackColor = true;
            this.cmdGirarDerecha.Click += new System.EventHandler(this.cmdGirarDerecha_Click);
            // 
            // cmdGirarIzquierda
            // 
            this.cmdGirarIzquierda.AutoSize = true;
            this.cmdGirarIzquierda.Location = new System.Drawing.Point(12, 94);
            this.cmdGirarIzquierda.Name = "cmdGirarIzquierda";
            this.cmdGirarIzquierda.Size = new System.Drawing.Size(85, 23);
            this.cmdGirarIzquierda.TabIndex = 1;
            this.cmdGirarIzquierda.Text = "Girar Izquierda";
            this.cmdGirarIzquierda.UseVisualStyleBackColor = true;
            this.cmdGirarIzquierda.Click += new System.EventHandler(this.cmdGirarIzquierda_Click);
            // 
            // cmdArriba
            // 
            this.cmdArriba.AutoSize = true;
            this.cmdArriba.Location = new System.Drawing.Point(12, 180);
            this.cmdArriba.Name = "cmdArriba";
            this.cmdArriba.Size = new System.Drawing.Size(76, 23);
            this.cmdArriba.TabIndex = 1;
            this.cmdArriba.Text = "Pluma Arriba";
            this.cmdArriba.UseVisualStyleBackColor = true;
            this.cmdArriba.Click += new System.EventHandler(this.cmdArriba_Click);
            // 
            // cmdAbajo
            // 
            this.cmdAbajo.AutoSize = true;
            this.cmdAbajo.Location = new System.Drawing.Point(12, 209);
            this.cmdAbajo.Name = "cmdAbajo";
            this.cmdAbajo.Size = new System.Drawing.Size(76, 23);
            this.cmdAbajo.TabIndex = 1;
            this.cmdAbajo.Text = "Pluma Abajo";
            this.cmdAbajo.UseVisualStyleBackColor = true;
            this.cmdAbajo.Click += new System.EventHandler(this.cmdAbajo_Click);
            // 
            // cmdAvanzar
            // 
            this.cmdAvanzar.Location = new System.Drawing.Point(181, 46);
            this.cmdAvanzar.Name = "cmdAvanzar";
            this.cmdAvanzar.Size = new System.Drawing.Size(75, 23);
            this.cmdAvanzar.TabIndex = 1;
            this.cmdAvanzar.Text = "Avanzar";
            this.cmdAvanzar.UseVisualStyleBackColor = true;
            this.cmdAvanzar.Click += new System.EventHandler(this.cmdAvanzar_Click);
            // 
            // txtOrientacion
            // 
            this.txtOrientacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrientacion.Location = new System.Drawing.Point(338, 68);
            this.txtOrientacion.Name = "txtOrientacion";
            this.txtOrientacion.Size = new System.Drawing.Size(316, 22);
            this.txtOrientacion.TabIndex = 2;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(338, 117);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 3;
            // 
            // cmdPosicionActual
            // 
            this.cmdPosicionActual.Location = new System.Drawing.Point(181, 94);
            this.cmdPosicionActual.Name = "cmdPosicionActual";
            this.cmdPosicionActual.Size = new System.Drawing.Size(75, 23);
            this.cmdPosicionActual.TabIndex = 4;
            this.cmdPosicionActual.Text = "Posicion";
            this.cmdPosicionActual.UseVisualStyleBackColor = true;
            this.cmdPosicionActual.Click += new System.EventHandler(this.cmdPosicionActual_Click);
            // 
            // cmdOrientacion
            // 
            this.cmdOrientacion.AutoSize = true;
            this.cmdOrientacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdOrientacion.Location = new System.Drawing.Point(185, 137);
            this.cmdOrientacion.Name = "cmdOrientacion";
            this.cmdOrientacion.Size = new System.Drawing.Size(71, 23);
            this.cmdOrientacion.TabIndex = 5;
            this.cmdOrientacion.Text = "Orientacion";
            this.cmdOrientacion.UseVisualStyleBackColor = true;
            this.cmdOrientacion.Click += new System.EventHandler(this.cmdOrientacion_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(13, 265);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 6;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cmdOrientacion);
            this.Controls.Add(this.cmdPosicionActual);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtOrientacion);
            this.Controls.Add(this.cmdAvanzar);
            this.Controls.Add(this.cmdAbajo);
            this.Controls.Add(this.cmdArriba);
            this.Controls.Add(this.cmdGirarIzquierda);
            this.Controls.Add(this.cmdGirarDerecha);
            this.Controls.Add(this.txtSalida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button cmdGirarDerecha;
        private System.Windows.Forms.Button cmdGirarIzquierda;
        private System.Windows.Forms.Button cmdArriba;
        private System.Windows.Forms.Button cmdAbajo;
        private System.Windows.Forms.Button cmdAvanzar;
        private System.Windows.Forms.TextBox txtOrientacion;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button cmdPosicionActual;
        private System.Windows.Forms.Button cmdOrientacion;
        private System.Windows.Forms.Button cmdMostrar;
    }
}

