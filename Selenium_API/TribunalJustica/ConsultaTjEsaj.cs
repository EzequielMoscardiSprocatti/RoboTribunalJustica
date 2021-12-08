using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Selenium_API.TribunalJustica
{
    public class ConsultaTjEsaj : IDisposable
    {

        //Construtor
        public ConsultaTjEsaj()
        {
            //inicialização
        }



        /// <summary>
        /// Acessar a página de consulta do site de acordo com a UF informada
        /// </summary>
        private static void AcessarTribunal(IWebDriver Driver, string Uf)
        {
            switch (Uf)
            {
                case "SP":
                    Driver.Navigate().GoToUrl("https://esaj.tjsp.jus.br/cpopg/open.do");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "SC":
                    Driver.Navigate().GoToUrl("https://esaj.tjsc.jus.br/cpopg/open.do?gateway=true");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "AC":
                    Driver.Navigate().GoToUrl("https://esaj.tjac.jus.br/cpopg/open.do");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "AM":
                    Driver.Navigate().GoToUrl("https://consultasaj.tjam.jus.br/cpopg/open.do");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "AL":
                    Driver.Navigate().GoToUrl("https://www2.tjal.jus.br/cpopg/open.do");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "CE":
                    Driver.Navigate().GoToUrl("https://esaj.tjce.jus.br/cpopg/open.do?gateway=true");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "MS":
                    Driver.Navigate().GoToUrl("https://esaj.tjms.jus.br/cpopg5/open.do?gateway=true");
                    System.Threading.Thread.Sleep(4000);
                    break;


                case "RN":
                    Driver.Navigate().GoToUrl("http://esaj.tjrn.jus.br/cpo/pg/open.do");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "BA":
                    Driver.Navigate().GoToUrl("http://esaj.tjba.jus.br/cpopg/open.do");
                    System.Threading.Thread.Sleep(4000);
                    break;


            }
        }


        /// <summary>
        /// Método para acessar a página de login e efetuar o login do mesmo de acordo com os parêmetros passado
        /// </summary>
        private bool AcessaTelaLoginTj(IWebDriver Driver, string Uf, string Login, string Senha)
        {
            IWebElement CampoLogin,CampoSenha,BtnEntrar;
            bool statusAcesso = false;

            switch (Uf)
            {
                case "BA":
                    Driver.Navigate().GoToUrl("http://esaj.tjba.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(8000);
                    break;

                case "SP":
                    Driver.Navigate().GoToUrl("https://esaj.tjsp.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(8000);
                    break;

                case "SC":
                    Driver.Navigate().GoToUrl("https://esaj.tjsc.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(8000);
                    break;

                case "AC":
                    Driver.Navigate().GoToUrl("https://esaj.tjac.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(8000);
                    break;

                case "AM":
                    Driver.Navigate().GoToUrl("https://consultasaj.tjam.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(8000);
                    break;

                case "AL":
                    Driver.Navigate().GoToUrl("https://www2.tjal.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(8000);
                    break;

                case "CE":
                    Driver.Navigate().GoToUrl("https://esaj.tjce.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "MS":
                    Driver.Navigate().GoToUrl("https://esaj.tjms.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(4000);
                    break;

                case "RN":
                    Driver.Navigate().GoToUrl("http://esaj.tjrn.jus.br/sajcas/login");
                    System.Threading.Thread.Sleep(4000);
                    break;

            }

            try
            {
                CampoLogin = Driver.FindElement(By.Id("usernameForm"));
                CampoSenha = Driver.FindElement(By.Id("passwordForm"));
                BtnEntrar = Driver.FindElement(By.Id("pbEntrar"));

                CampoLogin.SendKeys(Login);
                CampoSenha.SendKeys(Senha);
                BtnEntrar.Click();

                System.Threading.Thread.Sleep(10000);

                statusAcesso = true;
            }
            catch (Exception)
            {
                statusAcesso = false;
            }

            return statusAcesso;
        }

        /// <summary>
        /// Efetua o login e o acesso o tj
        /// </summary>
        public bool AcessarSiteTj(IWebDriver Driver, bool LoginTj, string Login, string Senha, string Uf)
        {
            bool statusAcesso = false;

            if(LoginTj == true)
            {
                statusAcesso = AcessaTelaLoginTj(Driver, Uf, Login, Senha);

                System.Threading.Thread.Sleep(4000);

                //click no botaão da versão beta
                VersaoBeta(Driver);
            }

            if(LoginTj == false)
            {
               AcessarTribunal(Driver, Uf);
                statusAcesso = false;
            }

            return statusAcesso;
        }



        /// <summary>
        /// Função para capturar dados do processo, o mesmo possui dois métodos distintos, Consultar e Capturar o processo
        /// Passar os seguintes parâmetros (Driver Selenium, Número do Processo CNJ, DataGridView para alocar os resultados)
        /// </summary>
        public string Consulta(IWebDriver Driver, string NumProcesso, DataGridView DatagridView, int LinhaDoDataGridView, string uf)
        {
            string StatusConsulta = "";

            //1- Etapa Consulta o número de prcesso
            ConsultarProcesso(Driver, NumProcesso, uf);

            //2- click no botão da versão beta
            VersaoBeta(Driver);

            //3-Etapa Captura dos dados
            CapturarDadosProcesso(Driver, DatagridView, LinhaDoDataGridView);

            return StatusConsulta;
        }



        /// <summary>
        /// Consultando o número de processo no tj, caso positivo o método retorna true, caso haja falha o mesmo retorna o erro
        /// </summary>
        private string ConsultarProcesso(IWebDriver Driver, string NumProcesso, string UF)
        {
            string statusConsulta = "";

            IWebElement RbOutros;
            IWebElement CampoProcesso;
            IWebElement BtnConsultar;

            AcessarTribunal(Driver, UF);

            System.Threading.Thread.Sleep(2000);

            //Preenchendo os campo para efetuar o processo
            try
            {
                RbOutros = Driver.FindElement(By.Id("radioNumeroAntigo"));
                CampoProcesso = Driver.FindElement(By.Id("nuProcessoAntigoFormatado"));
                BtnConsultar = Driver.FindElement(By.Id("botaoConsultarProcessos"));


                RbOutros.Click();
                CampoProcesso.Clear();
                CampoProcesso.Click();
                CampoProcesso.SendKeys(NumProcesso);

                //validando a tela de consulta
                PopUpCatcha(Driver);

                BtnConsultar.Click();

                System.Threading.Thread.Sleep(4000);
                

                statusConsulta = "true";
            }
            catch (Exception)
            {
                statusConsulta = "erro";
            }

            if(statusConsulta == "erro")
            {
                //Preenchendo os campo para efetuar o processo
                try
                {
                    try
                    {
                        RbOutros = Driver.FindElement(By.Id("radioNumeroAntigo"));
                    }
                    catch (Exception)
                    {
                        RbOutros = null;
                    }

                    try
                    {
                        CampoProcesso = Driver.FindElement(By.Id("nuProcessoAntigoFormatado"));

                    }
                    catch (Exception)
                    {
                        CampoProcesso = null;
                    }

                    try
                    {
                        BtnConsultar = Driver.FindElement(By.XPath("/html/body/div[2]/form/section/div[4]"));

                    }
                    catch (Exception)
                    {
                        BtnConsultar = null;

                    }


                    RbOutros.Click();
                    CampoProcesso.Clear();
                    CampoProcesso.Click();
                    CampoProcesso.SendKeys(NumProcesso);

                    //validando a tela de consulta
                    PopUpCatcha(Driver);

                    BtnConsultar.Click();

                    System.Threading.Thread.Sleep(4000);


                    statusConsulta = "true";
                }
                catch (Exception ex)
                {
                    statusConsulta = "Falha ao consultar o processo " + ex.ToString();
                }
            }

            

            return statusConsulta;
        }

        

        /// <summary>
        /// Método para capturar os dados do processo, este método engloba outros metodos juntos
        /// </summary>
        private void CapturarDadosProcesso(IWebDriver Driver, DataGridView dataGridView, int LinhaDoDataGridView)
        {
            if (Driver.PageSource.Contains("Senha do processo"))
            {
                dataGridView[2, LinhaDoDataGridView].Value = "Processo em Segredo de Justiça";
               
            }

            //1- Etapa de Capturar dados do processos
            InfoProcesso(Driver, dataGridView, LinhaDoDataGridView);

            //2-  Captura das partes do processo
            PartesProcesso(Driver, dataGridView, LinhaDoDataGridView);

            //3- Capturar Movimentação do processo
            AndamentoProcessual(Driver, dataGridView, LinhaDoDataGridView);

        }

        /// <summary>
        /// Método para capturar informações do processo
        /// </summary>
        private string InfoProcesso(IWebDriver Driver, DataGridView dataGridView, int LinhaDoDataGridView)
        {
            string StatusDados = "";
            string[] DadosPrin1 = { };
            string[] DadosPrin2 = { };

            IWebElement ProcDigital;
            IList<IWebElement> DadosPrincipais_1;
            IList<IWebElement> DadosPrincipais_2;
            IWebElement LinkMais = null;

            try
            {
                LinkMais = Driver.FindElement(By.Id("botaoExpandirDadosSecundarios"));

            }
            catch (Exception)
            {
                try
                {
                    LinkMais = Driver.FindElement(By.Id("maisDetalhes"));

                }
                catch (Exception)
                {
                    LinkMais = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[1]/a"));
                }
            }

            try
            {
                LinkMais.Click();

            }
            catch (Exception)
            {
                LinkMais = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[1]/a"));
                LinkMais.Click();
            }

            System.Threading.Thread.Sleep(2000);

            try
            {
                DadosPrincipais_1 = Driver.FindElements(By.Id("containerDadosPrincipaisProcesso"));
                DadosPrincipais_2 = Driver.FindElements(By.Id("maisDetalhes"));

                DadosPrin1 = DadosPrincipais_1[0].Text.Replace("\n", "").Split('\r');
                DadosPrin2 = DadosPrincipais_2[0].Text.Replace("\n", "").Split('\r');
            }
            catch (Exception)
            {
                try
                {
                    DadosPrincipais_1 = Driver.FindElements(By.XPath("/html/body/div[1]/div[2]/div/div"));
                    DadosPrincipais_2 = Driver.FindElements(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div"));

                    DadosPrin1 = DadosPrincipais_1[1].Text.Replace("\n", "").Split('\r');
                    DadosPrin2 = DadosPrincipais_2[0].Text.Replace("\n", "").Split('\r');
                }
                catch (Exception)
                {
                    StatusDados = "Erro na captura de dados";
                }
            }




            for(int i = 0; i < 12; i++)
            {
                try
                {
                    if (DadosPrin1[i] == "Classe")
                    {
                        dataGridView[5, LinhaDoDataGridView].Value = DadosPrin1[i + 1];
                    }
                }
                catch (Exception)
                {
                    //dataGridView[5, LinhaDoDataGridView].Value = "Erro na Obtenção dos dados";
                }


                try
                {
                    if (DadosPrin1[i] == "Assunto")
                    {
                        dataGridView[7, LinhaDoDataGridView].Value = DadosPrin1[i + 1];
                    }
                }
                catch (Exception)
                {
                    //dataGridView[7, LinhaDoDataGridView].Value = "Erro na Obtenção dos dados";
                }

                try
                {
                    if (DadosPrin1[i] == "Foro")
                    {
                        dataGridView[4, LinhaDoDataGridView].Value = DadosPrin1[i + 1];
                    }
                }
                catch (Exception)
                {
                    //dataGridView[4, LinhaDoDataGridView].Value = "Erro na Obtenção dos dados";
                }

                try
                {
                    if (DadosPrin1[i] == "Vara")
                    {
                        dataGridView[3, LinhaDoDataGridView].Value = DadosPrin1[i + 1];
                    }
                }

                catch (Exception)
                {
                    //dataGridView[3, LinhaDoDataGridView].Value = "Erro na Obtenção dos dados";
                }

                try
                {
                    if (DadosPrin1[i] == "Juiz")
                    {
                        dataGridView[8, LinhaDoDataGridView].Value = DadosPrin1[i + 1];
                    }
                }
                catch (Exception)
                {
                    //dataGridView[8, LinhaDoDataGridView].Value = "Erro na Obtenção dos dados";
                }



                //outros dados do processo
                try
                {
                    if (DadosPrin2[i] == "Distribuição")
                    {
                        dataGridView[2, LinhaDoDataGridView].Value = DadosPrin2[i + 1];
                    }
                }
                catch (Exception)
                {
                    
                }

                try
                {
                    if (DadosPrin2[i] == "Área")
                    {
                        dataGridView[6, LinhaDoDataGridView].Value = DadosPrin2[i + 1];
                    }
                }
                catch (Exception)
                {

                }

                try
                {
                    if (DadosPrin2[i] == "Valor da ação")
                    {
                        dataGridView[9, LinhaDoDataGridView].Value = DadosPrin2[i + 1];
                    }
                }
                catch (Exception)
                {

                }

            }

            try
            {
                ProcDigital = Driver.FindElement(By.Id("linkPasta"));
                dataGridView[12, LinhaDoDataGridView].Value = "Digital";
            }
            catch (Exception)
            {
                dataGridView[12, LinhaDoDataGridView].Value = "Físico";
            }
            


            return StatusDados;
        }

        /// <summary>
        /// Método para capturar partes do processo
        /// </summary>
        private string PartesProcesso(IWebDriver Driver, DataGridView dataGridView, int LinhaDoDataGridView)
        {
            string StatusCaptura = "";
            string[] ativo = { };
            string[] contra = { };
            string ParteAtivas = "";
            string ParteContra = "";

            IList<IWebElement> PartesEAdvogado_Ativo;
            IList<IWebElement> PartesEAdvogado_Contra;

            try
            {
                PartesEAdvogado_Ativo = Driver.FindElements(By.XPath("//*[@id='tablePartesPrincipais']/tbody/tr[1]/td[2]"));
                PartesEAdvogado_Contra = Driver.FindElements(By.XPath("//*[@id='tablePartesPrincipais']/tbody/tr[2]/td[2]"));

                ativo = PartesEAdvogado_Ativo[0].Text.Replace("\n", "").Split('\r');
                contra = PartesEAdvogado_Contra[0].Text.Replace("\n", "").Split('\r');
            }
            catch (Exception)
            {
                try
                {
                    PartesEAdvogado_Ativo = Driver.FindElements(By.XPath("//*[@id='tablePartesPrincipais']/tbody/tr[1]/td[2]"));
                    PartesEAdvogado_Contra = Driver.FindElements(By.XPath("//*[@id='tablePartesPrincipais']/tbody/tr[2]/td[2]"));

                    ativo = PartesEAdvogado_Ativo[1].Text.Replace("\n", "").Split('\r');
                    contra = PartesEAdvogado_Contra[1].Text.Replace("\n", "").Split('\r');
                }
                catch (Exception)
                {
                    StatusCaptura = "Erro na Captura de partes do processo";
                }
            }

            //Preenchendo o DataGridView com dados da partes do processo
            foreach (string partes in ativo)
            { 
           
                ParteAtivas += partes + ", ";
            }
            dataGridView[10, LinhaDoDataGridView].Value = ParteAtivas;

            foreach (string partes in contra)
            {
                ParteContra += partes + ", ";
            }
            dataGridView[11, LinhaDoDataGridView].Value = ParteContra;


            return StatusCaptura;
        }

        private string AndamentoProcessual(IWebDriver Driver, DataGridView dataGridView, int LinhaDoDataGridView)
        {
            string StatusConsulta = "";

            System.Threading.Thread.Sleep(1000);

            IWebElement CarregarMaisAndamentos;
            IList<IWebElement> Andamento = null;            

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0,550)");


            try
            {
                CarregarMaisAndamentos = Driver.FindElement(By.Id("linkmovimentacoes"));
                CarregarMaisAndamentos.Click();
            }
            catch (Exception)
            {


            }

            try
            {
                Andamento = Driver.FindElements(By.XPath("//*[@id='tabelaTodasMovimentacoes']/tr"));
                
            }
            catch (Exception)
            {
                try
                {
                    Andamento = Driver.FindElements(By.Id("//*[@id='tabelaTodasMovimentacoes']/tr"));
                    
                }
                catch (Exception)
                {
                    StatusConsulta = "Erro na consulta";
                }
               
            }

            if(Andamento.Count <= 0)
            {
                try
                {
                    Andamento = Driver.FindElements(By.XPath("/html/body/div[2]/table[2]/tbody[2]/tr"));

                }
                catch (Exception)
                {
                    try
                    {
                        Andamento = Driver.FindElements(By.Id("tabelaTodasMovimentacoes"));

                    }
                    catch (Exception)
                    {
                        StatusConsulta = "Erro na consulta";
                    }

                }
            }

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    dataGridView[13 + i, LinhaDoDataGridView].Value = Andamento[i].Text;
                }
            }
            catch (Exception)
            {

            }


            return StatusConsulta;
        }


        private static void VersaoBeta(IWebDriver Driver)
        {
            IWebElement BtnVersaoBeta;

            try
            {
                BtnVersaoBeta = Driver.FindElement(By.CssSelector(".escolhaBeta"));
                BtnVersaoBeta.Click();
                System.Threading.Thread.Sleep(4000);

            }
            catch (Exception)
            {

            }

            try
            {
                BtnVersaoBeta = Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[2]/table/tbody/tr[2]/td/button"));
                BtnVersaoBeta.Click();
                System.Threading.Thread.Sleep(4000);

            }
            catch (Exception)
            {

            }

            try
            {
                BtnVersaoBeta = Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[2]/table/tbody/tr[2]/td/button"));
                BtnVersaoBeta.Click();
                System.Threading.Thread.Sleep(4000);
            }
            catch (Exception)
            {

            }

        }

        private void PopUpCatcha(IWebDriver Driver)
        {
            if(Driver.PageSource.Contains("Não sou um robô") || Driver.PageSource.Contains("not a robot"))
            {
                MessageBox.Show("Robô de Consulta TJ", "Por Favor Valide o Captcha ou Recaptcha após resolver o mesmo click em ok deste pop-up");
            }
        }

        ~ConsultaTjEsaj()
        {
            this.Dispose();
        }

        public void Dispose()
        {
            
        }
    }
}
