using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineasCicunferencias
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void renderForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.BringToFront();
            form.Show();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLineas frmLineas = FrmLineas.GetInstance();
            renderForm(frmLineas);
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresenham frmBresenham = FrmBresenham.GetInstance();
            renderForm(frmBresenham);

        }

        private void bresenhamCircunferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBresenhamCirculo frmBresenhamCirculo = FrmBresenhamCirculo.GetInstance();
            renderForm(frmBresenhamCirculo);
        }

        private void rellenoInundaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare frmSquare = FrmSquare.GetInstance();
            renderForm(frmSquare);
        }

        private void dDAToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.FromArgb(60, 130, 190);
            }
        }

        private void dDAToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                item.BackColor = Color.FromArgb(0, 100, 180);
            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            MostrarFormularioInicio();
        }

        private void MostrarFormularioInicio()
        {
            FrmWelcome FrmWelcome = FrmWelcome.GetInstance();
            renderForm(FrmWelcome);
        }
    }
}
