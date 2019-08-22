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

namespace capaPresentacion
{
    public partial class MDIRecursos : Form
    {
        logicaNegocioRespaldo x = new logicaNegocioRespaldo();

        private int childFormNumber = 0;

        public MDIRecursos()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            /* Form childForm = new Form();
             childForm.MdiParent = this;
             childForm.Text = "Ventana " + childFormNumber++;
             childForm.Show();*/

            if (Application.OpenForms["fRecursos"] != null)
            {
                Application.OpenForms["fRecursos"].Activate();
            }

            else
            {
                fRecursos x = new fRecursos();
                x.MdiParent = this;
                x.BringToFront();
                x.Show();
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = RespaldoStripMenuItem.Checked;

            try
            {
                if (x.respladarBD() > 0)
                {
                    MessageBox.Show("Respaldo realizado con exito");
                }
            }
            catch 
            {
                MessageBox.Show("Error al realizar el respaldo");
            }

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("¿Estas seguro que quieres cerrar la aplicacion?",
                                                                     "Cerrar la aplicacion", MessageBoxButtons.YesNo,
                                                                      MessageBoxIcon.Question);

            return res;
        }

        private void MDIRecursos_Load(object sender, EventArgs e)
        {

        }
    }
}
