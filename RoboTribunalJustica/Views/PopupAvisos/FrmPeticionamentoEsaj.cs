using System;
using System.Windows.Forms;

namespace RoboTribunalJustica.Views.PopupAvisos
{
    public partial class FrmPeticionamentoEsaj : Form
    {

        public string Login { get; set; }
        public string Senha { get; set; }
        public string SenhaCofre { get; set; }
        public string TipoPeticionamento { get; set; }
        public bool Cancelar { get; set; }

        public FrmPeticionamentoEsaj()
        {
            InitializeComponent();
        }

        private void BtnPeticionar_Click(object sender, EventArgs e)
        {
            Login = TxtLogin.Text;
            Senha = TxtSenha.Text;
            TipoPeticionamento = CbxTipoPeticionamento1Grau.Text;
            SenhaCofre = txtCofre.Text;
            Cancelar = false;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Login = "";
            Senha = "";
            TipoPeticionamento = "";
            Cancelar = true;
            this.Close();
        }
    }
}
