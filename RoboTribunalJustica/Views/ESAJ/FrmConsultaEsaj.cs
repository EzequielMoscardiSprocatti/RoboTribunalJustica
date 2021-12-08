using System;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

using Selenium_API.TribunalJustica;
using RoboTribunalJustica.ClassArquivos;
using System.IO;

using RoboTribunalJustica.Views.PopupAvisos;
using RoboTribunalJustica.Ferramentas;


namespace RoboTribunalJustica.Views.ESAJ
{
    public partial class FrmConsultaEsaj : Form
    {
        public FrmConsultaEsaj()
        {
            InitializeComponent();
        }

        public string _Login { get; set; }
        public string _Senha { get; set; }
        public string _TipoPeticao { get; set; }
        public string CaminhDocIguais { get; set; }
        public string CaminhoDocDiferentes { get; set; }
        public string _SenhaCofre { get; set; }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            IWebDriver Driver = new ChromeDriver(Directory.GetCurrentDirectory());
            ConsultaTjEsaj consultaTj = new ConsultaTjEsaj();

            FrmLoginTj loginTj = new FrmLoginTj();

            loginTj.ShowDialog();

            if (loginTj.ChkPainel_LoginSenha == true)
            {
                //logar no tj
                consultaTj.AcessarSiteTj(Driver, loginTj.ChkPainel_LoginSenha, loginTj.Login, loginTj.Senha, Cbxtjsaj.Text);
            }

            if (loginTj.ChkPainel_Captcha == true)
            {
                //logar no tj
                consultaTj.AcessarSiteTj(Driver, false, loginTj.Login, loginTj.Senha, Cbxtjsaj.Text);
            }


            if (loginTj.ChkPainel_Cofre == true)
            {
                //logar no tj
                consultaTj.AcessarSiteTj(Driver, loginTj.ChkPainel_Cofre, loginTj.Login, loginTj.Senha, Cbxtjsaj.Text);

                MessageBox.Show("Por Favor Efetuar o Login via Cofre virtual, caso não seja feito, o sistema entenderá como consulta via CAPTCHA! ", "Robô Vilela e Batista");
            }

            for (int i = 0; i < DgvBase.Rows.Count; i++)
            {
                try
                {
                    //inicio consulta
                    consultaTj.Consulta(Driver, DgvBase[1, i].Value.ToString(), DgvBase, i, Cbxtjsaj.Text);
                    //fimconsulta                    
                }
                catch (Exception)
                {

                }

                this.Refresh();
                lblProcessado.Text = i.ToString();
            }

        }

        private void BtnImporta_Click(object sender, EventArgs e)
        {
            ImportExport import = new ImportExport();
            DGV_Importacao_Padronizada importacao_Padronizada = new DGV_Importacao_Padronizada();
            importacao_Padronizada.AndamentoProcessual(DgvBase);
            import.ImportarExcel(DgvBase, "Plan1");
            lblCarregado.Text = (DgvBase.Rows.Count - 1).ToString();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            ImportExport export = new ImportExport();
            export.ExportaExcel(DgvBase);
        }

        private void IconLogarAntes_Click(object sender, EventArgs e)
        {

        }

        private void BtnPeticionar_Click(object sender, EventArgs e)
        {
            //Chama o popup de peticionamento 
            FrmPeticionamentoEsaj peticionamentoEsaj = new FrmPeticionamentoEsaj();

            //Carrega as colunas de acordo com o processo a ser feito
            DGV_Importacao_Padronizada importacao_Padronizada = new DGV_Importacao_Padronizada();

            //Efetua a importação do excel para base
            ImportExport import = new ImportExport();



            //Efetua o processo instanciados acima
            importacao_Padronizada.PeticionamentoIntermediaria1Grau(DgvBase);
            peticionamentoEsaj.ShowDialog();

            if (peticionamentoEsaj.Cancelar == true)
            {
                return;
            }

            import.ImportarExcel(DgvBase, "Plan1");

            _Login = peticionamentoEsaj.Login;
            _Senha = peticionamentoEsaj.Senha;
            _TipoPeticao = peticionamentoEsaj.TipoPeticionamento;
            _SenhaCofre = peticionamentoEsaj.SenhaCofre;


            this.Refresh();
        }

        private void BtnPeticionamento_Click(object sender, EventArgs e)
        {

            string status = "";
            FrmTipoDeProtocolo tipoDeProtocolo = new FrmTipoDeProtocolo();
            tipoDeProtocolo.ShowDialog();
            var options = new ChromeOptions();
            options.AddUserProfilePreference("plugins.always_open_pdf_externally", true);
            options.AddUserProfilePreference("download.default_directory", @"C:\Robo_Juridico\");
            CaminhDocIguais = tipoDeProtocolo._CaminhoDocIguais;
            CaminhoDocDiferentes = tipoDeProtocolo._CAminhoDocDiferentes;
            ProtocoloEsaj esajPeticao = new ProtocoloEsaj();

            if (Cbxtjsaj.Text == "" || Cbxtjsaj.Text == "UF")
            {
                MessageBox.Show("Por favor informe a UF do TJ a ser acessado", "Bot Tribunal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }


            IWebDriver Driver = new ChromeDriver(Directory.GetCurrentDirectory(), options);


            try
            {
                System.Threading.Thread.Sleep(1500);

                Driver.Navigate().GoToUrl("https://chrome.google.com/webstore/detail/web-signer/bbafmabaelnnkondpfpjmdklbmfnbmol");

                System.Threading.Thread.Sleep(1500);

                MessageBox.Show("Olá Antes de prosseguir Add extensão do web-signer para dar continuidade ao processo de protocolo", "Bot Jurídico", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

            }



            //padrão array
            //0 uf esaj
            //1 Caminho documentos Iguais
            //2 Caminho doc diferentes
            //3 Senha Cofre
            //4 Processo
            //5 Localizacao das Peticoes
            //6 Tipo de Peticao
            //7 Categoria
            //8 PED. LIMINAR / TUTELA ANT / PED. URG
            //9 Parte Peticionante
            //10 Tipo de Pessoa
            //11 Cpf Cnpj
            //12 Nome da Parte
            //13 CEP
            //14 NumResd
            //15 Complemento

            int dgv = DgvBase.Rows.Count;
            bool key = false;

            for (int i = 0; i < dgv; i++)
            {
                string[] Dados = {Cbxtjsaj.Text, CaminhDocIguais, CaminhoDocDiferentes, _SenhaCofre,
                DgvBase[0, i].Value.ToString(), DgvBase[1, i].Value.ToString(),
                DgvBase[2, i].Value.ToString(), DgvBase[3, i].Value.ToString(),
                DgvBase[4, i].Value.ToString(), DgvBase[5, i].Value.ToString(),
                DgvBase[6, i].Value.ToString(), DgvBase[7, i].Value.ToString(),
                DgvBase[8, i].Value.ToString(), DgvBase[9, i].Value.ToString(),
                DgvBase[10, i].Value.ToString()};

                if (key == false)
                {
                    status = esajPeticao.PetcionamentoIntemediario_Login(Driver, _Login, _Senha, Dados);
                    key = true;
                }

                 status = esajPeticao.PeticionamentoIntemediario_1Grau(Driver, Dados);

                DgvBase[11, 1].Value = status;

            }

        }
    }
}
