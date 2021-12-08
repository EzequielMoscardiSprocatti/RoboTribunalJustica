using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Ferramentas.Macros;
using Keys = OpenQA.Selenium.Keys;

namespace Selenium_API.TribunalJustica
{
    public class ProtocoloEsaj : IDisposable
    {
        //Construtor
        public ProtocoloEsaj()
        {
            //inicialização
        }
               

        /// <summary>
        /// Acessar a página de consulta do site de acordo com a UF informada
        /// </summary>
        private static void AcessarTribunal(IWebDriver Driver, string Uf)
        {
            try
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
            catch (Exception)
            {

            }
            
        }

        /// <summary>
        /// Método para acessar a página de login e efetuar o login do mesmo de acordo com os parêmetros passado
        /// </summary>
        private bool AcessaTelaLoginTj(IWebDriver Driver, string Uf, string Login, string Senha)
        {
            IWebElement CampoLogin, CampoSenha, BtnEntrar;
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

            if (LoginTj == true)
            {
                statusAcesso = AcessaTelaLoginTj(Driver, Uf, Login, Senha);

                System.Threading.Thread.Sleep(4000);

                //click no botaão da versão beta
                VersaoBeta(Driver);
            }

            if (LoginTj == false)
            {
                AcessarTribunal(Driver, Uf);
                statusAcesso = false;
            }

            return statusAcesso;
        }

        /// <summary>
        ///Função para clicar na versão beta do esaj
        /// </summary>
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

        /// <summary>
        ///Informe o Driver e array de dados, que neste caso tem que esta na seguinte forma (0-uf esaj,1-Numero de processo, 2-Caminho documentos Iguais
        ///3-Caminho doc diferentes
        ///4-Caminho das peticoes
        ///5-Tipo de Petição
        ///6-Nome Parte
        ///7-Senha Cofre)
        /// </summary>
        public string PeticionamentoIntemediario_1Grau(IWebDriver Driver, string[] Dados)
        {
            Driver.Navigate().GoToUrl("https://esaj.tjsp.jus.br/petpg/peticoes/intermediaria");

            string StatusProcesso = "";

            System.Threading.Thread.Sleep(4000);

            IWebElement NumProcesso, Classificacao, AddParte, BtnProtocolar;

            //Buscando Numero de Processo
            Driver.FindElement(By.Id("botaoEditarDadosBasicos")).Click();
            try
            {
                NumProcesso = Driver.FindElement(By.Id("processoNumero"));

                NumProcesso.SendKeys(Dados[4].ToString());
                System.Threading.Thread.Sleep(2000);
                NumProcesso = Driver.FindElement(By.Id("consultarProcessosEDependentesIntermediaria"));
                NumProcesso.Click();
                System.Threading.Thread.Sleep(8000);

            }
            catch (Exception)
            {
                StatusProcesso = "Erro ao inserir Processo";
            }


            /*Atenção nesta parte pois dependendo do processo o mesmo pode gerar um pop-up e qual tipo de processo
             deseja incluir*/

            /*
             * Criar lógica de importação de documento
             * 1-Localizar a pasta dos documento
             * 2-Abrir a pasta dos documento relacionados a petição
             * 3-subir todos os documento da petição no tj utilizando o botão "adicionar outros documento"
             */

            //Caso o processo venha estar com status de Extinto, se encerra o processo de consulta e segue para o próximo
            /*----------------inicio analise de status processo-----------------------*/
            try
            {
                IWebElement TestePopUp;

                TestePopUp = Driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div/div/article[1]/section/div"));

                StatusProcesso = TestePopUp.Text;

                if (!TestePopUp.Text.Contains("Extinto"))
                {
                    TestePopUp.Click();
                }
                else
                {
                    StatusProcesso = "Processo Extinto";
                    return StatusProcesso;
                }

            }
            catch (Exception ex)
            {

            }
            /*----------------fim analise de status processo-----------------------*/

            try
            {
                //Editando a Classificação do processo
                Classificacao = Driver.FindElement(By.Id("botaoEditarClassificacao"));


                /*Definir o tipo de Petições a serem usada*/
                Driver.FindElement(By.CssSelector(".selecao-classe > .ui-select-container .btn")).Click();
                System.Threading.Thread.Sleep(1000);

                /*Inserindo o tipo de petição*/
                Driver.FindElement(By.Id("selectClasseIntermediaria")).SendKeys(Dados[6]);
                System.Threading.Thread.Sleep(2000);

                /*Simulando o press Enter*/
                Driver.FindElement(By.Id("selectClasseIntermediaria")).SendKeys(Keys.Enter);


            }
            catch (Exception)
            {
                StatusProcesso = "Erro ao inserir classificação";
            }


            if (!StatusProcesso.Contains("Erro"))
            {
                //Inserindo o documento de peticionamento
                AdicionarDocumentoPeticao(Driver, Dados);


                //Inserindo Documentos Complementares
                AdicionarDocumentosComplementares(Driver, Dados);


                StatusProcesso = "Documentos Protocolado";
            }

            //IList<IWebElement> li = Driver.FindElements(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[1]/div/div/div/article/section[1]/footer/div/ul/li"));

            /*
             * /html/body/span/main/div/div/div/form/div/div/div[1]/div/div/div/article/section[1]/footer/div/ul/li[1]/div/nav/div/ul/li[3]/span/div/div[1]/span/span[1]
             */

            //adicionando parte ao processo
            StatusProcesso = AdicionarParte(Driver, Dados);

            /*Função inserir Protocolo*/
            string status = Protocola(Driver, Dados[3]);

            /*Informativo de Dare*/
            if (status == "Erro")
            {
                PopUpDare(Driver, Dados[3]);                
            }

            StatusProcesso = AlterarDocRecibo(Dados, StatusProcesso);

            return StatusProcesso;
        }

        private static string AlterarDocRecibo(string[] Dados, string StatusProcesso)
        {
            System.Threading.Thread.Sleep(5000);

            try
            {
                
                File.Move(@"C:\Robo_Juridico\recibo.pdf", @"C:\Robo_Juridico\Comprovante de Protocolo - " + Dados[4] + ".pdf");

            }
            catch (Exception ex)
            {
                string erro = ex.ToString();
                StatusProcesso = "Arquivo já protocolado";
                File.Delete(@"C:\Robo_Juridico\recibo.pdf");
            }

            return StatusProcesso;
        }

        private static string PopUpDare(IWebDriver Driver, string SenhaCofre)
        {
            string statusprotocolo = "";
            System.Threading.Thread.Sleep(500);

            try
            {
                IWebElement PopUpDare, btnDare;

                PopUpDare = Driver.FindElement(By.XPath("//*[@id='mensagemGeral']/div"));

                if (PopUpDare.Text.Contains("DARE"))
                {
                    btnDare = Driver.FindElement(By.XPath("/html/body/div[1]"));
                    btnDare.Click();

                    btnDare = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[2]/div/div/section[4]/div/div[1]/div/button"));
                    btnDare.Click();

                    btnDare = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[2]/div/div/section[4]/div/div[2]/div/ng-include/checkbox/div/label"));
                    btnDare.Click();
                }

                statusprotocolo = "Dare ok";
            }
            catch (Exception)
            {
                statusprotocolo = "Sem dare";
            }

            if (statusprotocolo != "Sem dare")
            {
                /*Funcção inserir Protocolo*/
                Protocola(Driver, SenhaCofre);
            }


            return statusprotocolo;
        }

        private static string Protocola(IWebDriver Driver, string SenhaCofre)
        {
            GravarExecutarMacros macros = new GravarExecutarMacros();

            IWebElement BtnProtocolar;            
            
            string StatusProcolo = "";
            try
            {
                BtnProtocolar = Driver.FindElement(By.Id("botaoProtocolar"));
                BtnProtocolar.Click();

                System.Threading.Thread.Sleep(2000);

                BtnProtocolar = Driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/button"));
                BtnProtocolar.Click();

                System.Threading.Thread.Sleep(8000);

                if (Driver.PageSource.Contains("Não foi informado nenhum DARE -⁠ Documento de Arrecadação de Receitas Estaduais."))
                {
                    StatusProcolo = "Erro";
                    return StatusProcolo;
                }
            }
            catch (Exception ex)
            {
                string erro = ex.ToString();
                StatusProcolo = "Erro";
            }

            System.Threading.Thread.Sleep(500);

            if(StatusProcolo != "Erro")
            {
                System.Threading.Thread.Sleep(200);
                macros.SenhaCofre = SenhaCofre;
                macros.GravarExecutarMacro();

                System.Threading.Thread.Sleep(80000);

                try
                {
                    try
                    {
                        IWebElement baixarProtocolo = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[1]/div/div/section/div/div[1]/div/div/div/div/button"));
                        baixarProtocolo.Click();
                        System.Threading.Thread.Sleep(3000);
                    }
                    catch (Exception ex)
                    {
                        StatusProcolo = "Erro";
                    }
                }
                catch (Exception)
                {

                }
            }



            return StatusProcolo;
        }


        /// <summary>
        ///Informe o seguintes dados, Numero de Processo e Local onde se encontra as petições
        /// </summary>
        private static string AdicionarDocumentoPeticao(IWebDriver Driver, string[] Dados)
        {
            string status = "";
            bool Carregado = false;
            string[] arquivos = Directory.GetFiles(Dados[5]);
            Ferramentas.ManipularEventos.EventosMouseCofreTJ cofre = new Ferramentas.ManipularEventos.EventosMouseCofreTJ();

            IWebElement InserePdf;


            foreach(string file in arquivos)
            {
                if(file.Contains(Dados[4]) && Carregado == false)
                {
                    try
                    {
                        InserePdf = Driver.FindElement(By.XPath("//*[@id='botaoAdicionarDocumento']/input"));
                        InserePdf.SendKeys(file);
                        Carregado = true;
                        status = "Arquivo Inserido";
                    }
                    catch (WebDriverException)
                    {

                    }
                    catch (Exception)
                    {

                    }
                }
            }

            System.Threading.Thread.Sleep(4500);

            return status;
        }

        private static string AdicionarDocumentosComplementares(IWebDriver Driver, string[] Dados)
        {
            string status = "";
            IWebElement InserirDocumento, TipoDocumento;
            ArrayList documentosProcesso = new ArrayList();
            int Doc = 0;

            //Verifico o caminho que foi passado caso seja arquivos diferente segue a lógica abaixo
            try
            {
                if (Dados[2] != "")
                {
                    string[] arquivos = Directory.GetFiles(Dados[2]);


                    foreach (string file in arquivos)
                    {
                        if (file.Contains(Dados[3]))
                        {
                            if (!documentosProcesso.Contains(file))
                            {
                                documentosProcesso.Add(file);
                                status = "Arquivo Inserido";
                                System.Threading.Thread.Sleep(20000);
                            }
                        }
                    }

                    try
                    {
                        InserirDocumento = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[1]/div/div/div/article/section[2]/button/input"));

                        System.Threading.Thread.Sleep(5000);

                        foreach (string file in documentosProcesso)
                        {
                            InserirDocumento.SendKeys(file);

                            System.Threading.Thread.Sleep(20000);

                            status = "Arquivo Inserido";
                        }
                    }
                    catch (Exception)
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                status = ex.ToString();
            }

            //Caso seja para arquivos iguais segue a lógica montada abaixo
            try
            {
                if (Dados[1] != "")
                {
                    string[] arquivos = Directory.GetFiles(Dados[1]);
                    InserirDocumento = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[1]/div/div/div/article/section[2]/button/input"));

                    foreach (string file in arquivos)
                    {
                        Doc++;

                        try
                        {

                            InserirDocumento.SendKeys(file);

                            if (Doc == 3)
                            {
                                System.Threading.Thread.Sleep(40000);
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(15000);
                            }

                            TipoDocumento = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[1]/div/div/div/article/section[1]/footer/div/ul/li[" + Doc + "]/div/nav/div/ul/li[3]/span/div/div[1]/span/span[1]"));
                            
                            TipoDocumento.Click();

                            TipoDocumento = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[1]/div/div/div/article/section[1]/footer/div/ul/li[" + Doc + "]/div/nav/div/ul/li[3]/span/div/input[1]"));
                            
                            TipoDocumento.SendKeys("Documento " + Doc);

                            TipoDocumento.SendKeys(Keys.Enter);

                            System.Threading.Thread.Sleep(1000);

                            status = "Arquivo Inserido";
                        }
                        catch (Exception ex)
                        {
                            status = ex.ToString();
                        }
                    }


                }

            }
            catch (Exception ex)
            {
                status = ex.ToString();
            }


            return status;
        }

        /// <summary>
        ///Informe o Driver, o login e a senha, o array de dados, que neste caso tem que esta na seguinte forma (0-uf esaj,1-Numero de processo, 2-Caminho documentos Iguais, 
        ///3-Caminho doc diferentes, 4-Caminho das peticoes, 5-Tipo de Petição,6-Nome Parte, 7-Senha Cofre)
        /// </summary>
        public string PetcionamentoIntemediario_Login(IWebDriver Driver, string Login, string Senha, string[] DadosPeticao)
        {

        //criar função que instale o wensigner
        //https://chrome.google.com/webstore/detail/web-signer/bbafmabaelnnkondpfpjmdklbmfnbmol

            string statusPeticao = "";

            //Etapas a serem seguidas pelo robôs

            //1- Acessar o site do TJ
            AcessarTribunal(Driver, DadosPeticao[0]);

            //2- Logar no tj
            AcessaTelaLoginTj(Driver, DadosPeticao[0], Login, Senha);

            /*Criar Função via COfre virtual*/

            //3- Click versão beta
            VersaoBeta(Driver);
            
            return statusPeticao;
        }

        /// <summary>
        ///Efetua a inserção da parte no processo caso a parte seja polo ativo ou passivo, de acordo com as informações que 
        ///vem da array de dados, informações principais(PF/PJ, CPF_CNPJ, CEP, NUM, COMPLEMENTO)
        /// </summary>
        private string AdicionarParte(IWebDriver Driver, string[] Dados)
        {
            string status = "";
            IList<IWebElement> PoloAtivo, PoloPassivo = null;
            IWebElement CPF_CNPJ, Numero, TipoPessoa;
            string nome = Dados[12];
            string[] dados = Dados[12].Split();
            int i = 1;
            string erro = "";

            //Varrendo as tag para verificar onde se encontra polo ativo e passivo
            PoloAtivo = Driver.FindElements(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[2]/div/div/section[5]/div/div[2]/div/div/div[1]/div"));


            System.Threading.Thread.Sleep(6000);

            //Verificando se o nome da parte se encontra cadastrado
            foreach(IWebElement valor in PoloAtivo)
            {
                if(valor.Text.ToLower().Contains(dados[0].ToLower()))
                {

                    IWebElement btnIncluir = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[2]/div/div/section[5]/div/div[2]/div/div/div[1]/div[" + i + "]/div/div/div[2]/span/button"));
                    btnIncluir.Click();
                    return status;
                }

                i++;
            }

            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("window.scrollBy(950,0);");

                IJavaScriptExecutor jsi = (IJavaScriptExecutor)Driver;
                jsi.ExecuteScript("document.querySelector('#blocoParteDiversas > div > div.panel-heading.clearfix > div > button');");

                IWebElement bteteste = Driver.FindElement(By.CssSelector("#blocoParteDiversas > div > div.panel-heading.clearfix > div > button"));
                bteteste.Click();
            }
            catch (Exception ex)
            {

            }


            try
            {
                IWebElement rbPj = Driver.FindElement(By.CssSelector("#parteEditDadosPessoa > div:nth-child(3) > div:nth-child(1) > fieldset > radio-input:nth-child(3) > div"));
                //rbPj.Submit();
                rbPj.Click();
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception)
            {

            }

            try
            {
                if (Dados[10] == "PF")
                {
                    IWebElement txtCpfCnj = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[2]/div/div/section[5]/div/div[2]/div/div/div[1]/div/ng-if/div[1]/div[2]/div[2]/div[1]/div/input"));
                    txtCpfCnj.SendKeys(Dados[11]);
                    System.Threading.Thread.Sleep(6000);
                }

                if (Dados[10] == "PJ")
                {
                    IWebElement txtCpfCnj = Driver.FindElement(By.Id("inputCnpj"));
                    txtCpfCnj.SendKeys(Dados[11]);
                    System.Threading.Thread.Sleep(10000);
                }

            }
            catch (Exception ex)
            {
                 string erro_cnpj = ex.ToString();
            }

            try
            {
                IWebElement txtCEP = Driver.FindElement(By.Id("cep"));
                txtCEP.SendKeys(Dados[13]);
                System.Threading.Thread.Sleep(6000);
            }
            catch (Exception)
            {

            }


            try
            {
                IWebElement txtNumero = Driver.FindElement(By.Id("inputNumeroLogradouro"));
                txtNumero.SendKeys(Dados[14]);
            }
            catch (Exception)
            {

            }

            try
            {
                IWebElement btnAddSolcicitante = Driver.FindElement(By.XPath("/html/body/span/main/div/div/div/form/div/div/div[2]/div/div/section[5]/div/div[2]/div/div/div[1]/div/div/div/ul/li[2]/button"));
                btnAddSolcicitante.Click();
                System.Threading.Thread.Sleep(6000);
            }
            catch (Exception ex)
            {
                erro = "Erro ao Adicionar";
            }

            try
            {
                IWebElement BtnConf = Driver.FindElement(By.CssSelector("body > div:nth-child(15) > div.popover-content > div > div:nth-child(1) > button"));
                BtnConf.Click();
                System.Threading.Thread.Sleep(6000);
            }
            catch (Exception ex)
            {
                erro = "";
            }

            System.Threading.Thread.Sleep(3000);

            return status;
        }
        
        ~ProtocoloEsaj()
        {
            this.Dispose();
        }

        public void Dispose()
        {

        }
    }
}
