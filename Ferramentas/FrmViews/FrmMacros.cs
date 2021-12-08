using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas.FrmViews
{
    public partial class FrmMacros : Form
    {
        public int Postion_X { get; set; }
        public int Postion_Y { get; set; }
        public bool StatusProc { get; set; }

        private void FrmGravacaoMacro_Load(object sender, EventArgs e)
        {
            lblX.Text = Postion_X.ToString();
            lblY.Text = Postion_Y.ToString();
        }

        public FrmMacros()
        {
            InitializeComponent();
        }

        private void FrmMacros_Load(object sender, EventArgs e)
        {
            lblX.Text = Postion_X.ToString();
            lblY.Text = Postion_Y.ToString();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatusProc = true;
            return;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatusProc = false;
            return;
        }
    }
}
