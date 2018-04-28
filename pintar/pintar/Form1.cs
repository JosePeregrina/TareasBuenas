using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pintar
{
    public partial class Form1 : Form
    {
        Tortuga tortuga = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGirarDerecha_Click(object sender, EventArgs e)
        {
            tortuga.RotarDerecha();
            if (tortuga.Orientacion == 1)
                txtOrientacion.Text = "La tortuga esta mirando hacia arriba";
            else if (tortuga.Orientacion == 2)
                txtOrientacion.Text = "La tortuga es mirando haci la izquierda";
            else if (tortuga.Orientacion == 3)
                txtOrientacion.Text = "La tortuga esta mirando hacia abajo";
            else
                txtOrientacion.Text = "La tortuga esta mirando hacia la derecha";
        }

        private void cmdGirarIzquierda_Click(object sender, EventArgs e)
        {
            tortuga.RotarIzquierda();
            if (tortuga.Orientacion == 1)
                txtOrientacion.Text = "La tortuga esta mirando hacia arriba";
            else if (tortuga.Orientacion == 2)
                txtOrientacion.Text = "La tortuga es mirando haci la izquierda";
            else if (tortuga.Orientacion == 3)
                txtOrientacion.Text = "La tortuga esta mirando hacia abajo";
            else
                txtOrientacion.Text = "La tortuga esta mirando hacia la derecha";
        }

        private void cmdArriba_Click(object sender, EventArgs e)
        {
            if (tortuga.Pluma == false)
                MessageBox.Show("La pluma ya esta arriba", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tortuga.Pluma = false;
                MessageBox.Show("La pluma se ha levantado", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdAbajo_Click(object sender, EventArgs e)
        {
            if (tortuga.Pluma)
                MessageBox.Show("La pluma ya esta abajo", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tortuga.Pluma = true;
                tortuga.Pintar();
                MessageBox.Show("Listo para pintar", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdAvanzar_Click(object sender, EventArgs e)
        {
            
                tortuga.Avanzar();
            if(tortuga.Pluma)
                tortuga.Pintar();
            
        }

        private void cmdPosicionActual_Click(object sender, EventArgs e)
        {
            txtPosicion.Text = Convert.ToString(tortuga.EjeX);
            txtPosicion.Text += ", " + tortuga.EjeY;
        }

        private void cmdOrientacion_Click(object sender, EventArgs e)
        {
            txtOrientacion.Text = tortuga.Orientacion + "";
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            txtSalida.Text = tortuga.ToString();
        }
    }
}
