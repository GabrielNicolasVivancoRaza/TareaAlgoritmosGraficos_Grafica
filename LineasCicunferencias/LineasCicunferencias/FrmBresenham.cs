using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineasCicunferencias;

namespace LineasCicunferencias
{
    public partial class FrmBresenham : Form
    {
        private FrmBresenham()
        {
            InitializeComponent();
        }

        private static FrmBresenham instance;
        public static FrmBresenham GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBresenham();
            }
            return instance;
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(txtInitialX.Text);
                int y1 = int.Parse(txtInitialY.Text);
                int x2 = int.Parse(txtFinalX.Text);
                int y2 = int.Parse(txtFinalY.Text);

                List<Point> points = ClassBrsenham.GenerateLinePoints(x1, y1, x2, y2);

                int scale = 20;
                int pointSize = 3;

                Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.White);

                foreach (Point p in points)
                {
                    int px = p.X * scale;
                    int py = bmp.Height - 1 - (p.Y * scale);

                    if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                    {
                        g.FillRectangle(Brushes.Black, px, py, pointSize, pointSize);
                        picCanvas.Image = bmp;
                        picCanvas.Refresh();
                        await Task.Delay(100); // Espera para animar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular la línea: " + ex.Message);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtInitialX.Clear();
            txtInitialY.Clear();
            txtFinalX.Clear();
            txtFinalY.Clear();
            picCanvas.Image = null;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
