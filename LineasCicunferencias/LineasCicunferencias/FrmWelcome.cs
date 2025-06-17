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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }
        private static FrmWelcome instance;
        public static FrmWelcome GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmWelcome();
            }
            return instance;
        }
    }
}
