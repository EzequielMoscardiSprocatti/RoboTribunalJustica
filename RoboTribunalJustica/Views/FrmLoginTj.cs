using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboTribunalJustica.Views.PopupAvisos;

namespace RoboTribunalJustica.Views
{
    public partial class FrmLoginTj : Form
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string IdCofre { get; set; }
        public bool ChkPainel_LoginSenha { get; set; }
        public bool ChkPainel_Cofre { get; set; }
        public bool ChkPainel_Captcha { get; set; }

        public FrmLoginTj()
        {
            InitializeComponent();
        }

        private void BtnProsseguir_Click(object sender, EventArgs e)
        {
            Login = TxtLogin.Text;
            Senha = TxtSenha.Text;
            IdCofre = txtIdCofre.Text;
            
            if(chkCaptcha.Checked == true && chkCofre.Checked == false && ChkLoginSenha.Checked == false)
            {
                ChkPainel_Captcha = true;
            }

            if(chkCaptcha.Checked == false && chkCofre.Checked == true && ChkLoginSenha.Checked == false)
            {
                ChkPainel_Cofre = true;
            }

            if(chkCaptcha.Checked == false && chkCofre.Checked == false && ChkLoginSenha.Checked == true)
            {
                ChkPainel_LoginSenha = true;
            }

            //if (chkCaptcha.Checked == false && chkCofre.Checked == false && ChkLoginSenha.Checked == false)
            //{
            //    if (Login == "" || Senha == "" || IdCofre == "")
            //    {
            //        FrmAvisoDoRobo frmAviso = new FrmAvisoDoRobo();
            //        frmAviso.IdAviso = 2;
            //        frmAviso.ShowDialog();
            //    }
            //}

            

            this.Close();
        }
    }
}
