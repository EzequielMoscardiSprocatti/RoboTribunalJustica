using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboTribunalJustica.Views.PopupAvisos
{
    public partial class FrmAvisoDoRobo : Form
    {
        public FrmAvisoDoRobo()
        {
            InitializeComponent();
        }

        public string Aviso { get; set; }

        public int IdAviso { get; set; }

        private void BtnAviso_Click(object sender, EventArgs e)
        {
            
            return;
        }

        private void MsgAvisoCursoDoMouse()
        {
            Aviso = "Olá, Esse é um evento de automação, preciso que você click no ok, deste pop-up, e após coloque o " +
                " ponteiro do seu mouse sobre o icone do cofre virtual, e não mexe no mouse, pois vou utilizar ele, obrigado!";
        }

        private void AvisoDeFaltaDeDados()
        {
            Aviso = "Olá, Parece que está faltando mais de um dados em sua requisição!";
        }

        private void FrmAvisoDoRobo_Load(object sender, EventArgs e)
        {
            if (IdAviso == 1)
            {
                MsgAvisoCursoDoMouse();
                TxtAvisoMsg.Text = Aviso;
            }

            if (IdAviso == 2)
            {
                AvisoDeFaltaDeDados();
                TxtAvisoMsg.Text = Aviso;
            }
        }
    }
}
