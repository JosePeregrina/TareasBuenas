using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_circulares
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            int telefono = Convert.ToInt32(txtTelefono.Text);
            int tiempo = Convert.ToInt32(txtTiempo.Text);

            Base objeto = new Base(nombre, apellido, edad, telefono, tiempo);
            agenda.Agregar(objeto);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Base mostrar = agenda.Buscar(nombre);
            txtSalida.Text = mostrar.ToString();
        }

        private void cmdEliminarUltimo_Click(object sender, EventArgs e)
        {
            agenda.EliminarFinal();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            agenda.Eliminar(nombre);
        }

        private void cmdEliminarPrimero_Click(object sender, EventArgs e)
        {
            agenda.EliminarInicio();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            txtSalida.Text = agenda.Listar();
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            int telefono = Convert.ToInt32(txtTelefono.Text);
            int tiempo = Convert.ToInt32(txtTiempo.Text);

            Base objeto = new Base(nombre, apellido, edad, telefono, tiempo);
            int posicion = Convert.ToInt32(txtHoraInicio.Text);
            agenda.Insertar(objeto, posicion);
        }

        private void cmdRuta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string horaFinal = dtpHoraFin.Text;
            string horaInicio = dtpHoraInicio.Text;
            horaFinal = horaFinal.Replace(":", "");
            horaInicio = horaInicio.Replace(":", "");
            //fracmentar en strings y eliminar los caracteres que creamos cinvenientes;
            txtSalida.Text = agenda.Ruta(nombre, Convert.ToInt32( horaInicio), Convert.ToInt32(horaFinal)) + "";

        }
    }
}
