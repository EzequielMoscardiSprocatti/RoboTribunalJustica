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
    public partial class FrmTipoDeProtocolo : Form
    {
        FolderBrowserDialog fbd;
        public string _CaminhoDocIguais { get; set; }
        public string _CAminhoDocDiferentes { get; set; }
        public string _PeticionamentoSemDoc { get; set; }

        public FrmTipoDeProtocolo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPeticionar_Click(object sender, EventArgs e)
        {
            _CAminhoDocDiferentes = txtDocumentosDiferentes.Text;
            _CaminhoDocIguais = txtCaminhoDocIguais.Text;

            if (chkPeticaoSemDocumentos.Equals(true))
            {
                _PeticionamentoSemDoc = "Sem documentos";
            }

            this.Close();
        }

        private void BtnAbrirPastaDocumentosIguais_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                _CaminhoDocIguais = fbd.SelectedPath;
                txtCaminhoDocIguais.Text = fbd.SelectedPath;
            }
        }

        private void BtnPastaComDocumentosDiferentes_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                _CAminhoDocDiferentes = fbd.SelectedPath;
                txtDocumentosDiferentes.Text = fbd.SelectedPath;
            }
        }
    }
}
