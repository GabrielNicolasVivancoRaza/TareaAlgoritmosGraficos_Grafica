using System;
using System.Drawing;
using System.Windows.Forms;

namespace LineasCicunferencias
{
    internal class Square
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private float mAngle = 0.0f;
        private Bitmap mBitmap;

        public Square()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void initializeData(TextBox txtSide, PictureBox picCanvas)
        {
            mSide = 0.0f;
            txtSide.Clear();
            txtSide.Focus();
            picCanvas.Image = null;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mPen = new Pen(Color.Blue, 3);
            float side = mSide;

            // 1. Crear un Bitmap del tamaño del PictureBox
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);

            // 2. Crear el objeto Graphics desde el Bitmap
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(picCanvas.BackColor);

                float cx = picCanvas.Width / 2;
                float cy = picCanvas.Height / 2;
                float x = cx - (side / 2);
                float y = cy - (side / 2);

                g.DrawRectangle(mPen, x, y, side, side);
            }

            // 3. Asignar el Bitmap al PictureBox
            picCanvas.Image = bmp;
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
