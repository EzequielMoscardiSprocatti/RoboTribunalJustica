using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboTribunalJustica.ClassArquivos
{
    public class ImportExport
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;


        public void ImportarExcel(DataGridView datagridview, String Nome_Arquivo)
        {
            string rota = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files | *.xlsx";
                openfile1.Title = "Selecione o arquivo Excel base";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        rota = openfile1.FileName;
                    }
                }

                System.Threading.Thread.Sleep(3000);

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + rota + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + Nome_Arquivo + "$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);

                
                //datagridview.DataSource = dt;

                foreach (DataRow dados in dt.Rows)
                {
                    datagridview.Rows.Add(dados.ItemArray);
                }

                System.Threading.Thread.Sleep(3000);
            }

            catch (Exception e)
            {
                MessageBox.Show("Erro ao Subir Arquivo Excel " + e.ToString(), "Erro de Importação");
            }

        }

        public void ExportaExcel(DataGridView datagridview)
        {
            int Colunas = 0;
            int Linhas = 0;

            Colunas = datagridview.Columns.Count;
            Linhas = datagridview.Rows.Count;

            for (int i = 0; i < Linhas; i++)
            {
                {
                    for (int ii = 0; ii < Colunas; ii++)
                        if (datagridview[ii, i].Value == null)
                        {
                            try
                            {
                                datagridview[ii, i].Value = "-";

                            }
                            catch (FormatException)
                            {

                            }
                        }
                }
            }

            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

                if (datagridview.Rows.Count > 0)
                {
                    try
                    {
                        XcelApp.Application.Workbooks.Add(Type.Missing);

                        //Adiona o titulo da planilha
                        for (int i = 1; i < datagridview.Columns.Count + 1; i++)
                        {
                            XcelApp.Cells[1, i] = datagridview.Columns[i - 1].HeaderText;
                        }

                        for (int i = 0; i < datagridview.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < datagridview.Columns.Count; j++)
                            {
                                XcelApp.Cells[i + 2, j + 1] = datagridview.Rows[i].Cells[j].Value.ToString();

                            }
                        }



                        XcelApp.Columns.AutoFit();
                        XcelApp.Visible = true;
                    }

                    catch (Exception)
                    {
                        //MessageBox.Show("Erro ao exporta : " + ex.Message);
                        XcelApp.Quit();
                    }

                }
            }

            MessageBox.Show("Relatório Exportado", "Sistema - Robo");
        }
    }
}
