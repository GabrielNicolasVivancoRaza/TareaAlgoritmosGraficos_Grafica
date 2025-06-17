using System;
using System.Drawing;
using System.Windows.Forms;

namespace LineasCicunferencias
{
    public partial class FrmSquare : Form
    {
        private Square ObjSquare = new Square();
        private FrmSquare()
        {
            InitializeComponent();
        }

        private static FrmSquare instance;

        public static FrmSquare GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmSquare();
            }
            return instance;
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            ObjSquare.initializeData(txtSide, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjSquare.ReadData(txtSide);
            ObjSquare.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.initializeData(txtSide, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (picCanvas.Image == null)
                return;

            Bitmap bmp = new Bitmap(picCanvas.Image);
            Color targetColor = bmp.GetPixel(e.X, e.Y);
            Color fillColor = Color.Red;

            ClassFloodFill.FloodFill(bmp, e.X, e.Y, targetColor, fillColor, picCanvas);
        }
    }
}
