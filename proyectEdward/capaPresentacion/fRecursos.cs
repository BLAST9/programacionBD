using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaEntidades;

namespace capaPresentacion
{
    public partial class fRecursos : Form
    {
        logicaDatoRecursos logicaR = new logicaDatoRecursos();

        public fRecursos()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text.Equals("Guardar"))
                {
                    clsRecursosEntity objetoRecurso = new clsRecursosEntity();
                    objetoRecurso.nombre = textBoxNombre.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;

                    if (logicaR.insertarRecurso(objetoRecurso)>0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewRecursos.DataSource = logicaR.listarRecurso();
                        textBoxNombre.Clear();
                        textBoxCodigo.Clear();
                        textBoxDescripcion.Clear();
                        tabRecursos.SelectedTab = tabDetalle;
                    }

                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }
                }

                if (buttonGuardar.Text.Equals("Actualizar"))
                {
                    clsRecursosEntity objetoRecurso = new clsRecursosEntity();
                    objetoRecurso.idRecursos = Convert.ToInt32(textBoxId.Text);
                    objetoRecurso.nombre = textBoxNombre.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;

                    if (logicaR.editarRecurso(objetoRecurso) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dataGridViewRecursos.DataSource = logicaR.listarRecurso();
                        textBoxNombre.Clear();
                        textBoxCodigo.Clear();
                        textBoxDescripcion.Clear();
                        tabRecursos.SelectedTab = tabDetalle;
                    }

                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }

                    buttonGuardar.Text = "Guardar";
                }
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fRecursos_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            textBoxId.Visible = false;
            dataGridViewRecursos.DataSource = logicaR.listarRecurso();
        }

      
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<clsRecursosEntity> listaRecursos = logicaR.buscarRecurso(textBoxBuscar.Text);
            dataGridViewRecursos.DataSource = listaRecursos;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            lblId.Visible = true;

            textBoxId.Text = dataGridViewRecursos.CurrentRow.Cells["idRecursos"].Value.ToString();
            textBoxNombre.Text = dataGridViewRecursos.CurrentRow.Cells["nombre"].Value.ToString();
            textBoxCodigo.Text = dataGridViewRecursos.CurrentRow.Cells["codigo"].Value.ToString();
            textBoxDescripcion.Text = dataGridViewRecursos.CurrentRow.Cells["descripcion"].Value.ToString();

            tabRecursos.SelectedTab = tabNuevo;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoR = Convert.ToInt32(dataGridViewRecursos.CurrentRow.Cells["idRecursos"].Value.ToString());

            try
            {
                if (logicaR.eliminarRecurso(codigoR)> 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dataGridViewRecursos.DataSource = logicaR.listarRecurso();
                }
            }
            catch
            {
                MessageBox.Show("Error al aliminar recurso");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonsal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
