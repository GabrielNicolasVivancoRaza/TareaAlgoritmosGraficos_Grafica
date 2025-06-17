using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineasCicunferencias;

namespace LineasCicunferencias
{
    public partial class FrmBresenhamCirculo : Form
    {
        private FrmBresenhamCirculo()
        {
            InitializeComponent();
        }

        private static FrmBresenhamCirculo instance;

        public static FrmBresenhamCirculo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmBresenhamCirculo();
            }
            return instance;
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int radius = int.Parse(txtRadius.Text);
                List<Point> points = ClassBresenhamCirculo.GenerateCirclePoints(radius);

                int scale = 10;
                int pointSize = 3;

                Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.White);

                int centerX = bmp.Width / 2;
                int centerY = bmp.Height / 2;

                foreach (Point p in points)
                {
                    int px = centerX + (p.X * scale);
                    int py = centerY - (p.Y * scale);

                    if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                    {
                        g.FillRectangle(Brushes.Blue, px, py, pointSize, pointSize);
                        picCanvas.Image = bmp;
                        picCanvas.Refresh();
                        await Task.Delay(50); // Espera para la animación
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el círculo: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            picCanvas.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
