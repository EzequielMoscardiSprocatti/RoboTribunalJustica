using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboTribunalJustica.Ferramentas
{
    public class DGV_Importacao_Padronizada
    {
        public void PeticionamentoIntermediaria1Grau(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            dataGridView.Columns.Add("NUM_PROCESSO", "NUM PROCESSO"); //0
            dataGridView.Columns.Add("LOCAL_ARQUIVO", "LOCAL DO ARQUIVO");//1
            dataGridView.Columns.Add("TIPO_PETICAO", "TIPO PETICÃO");//2
            dataGridView.Columns.Add("CATEGORIA", "CATEGORIA");//3
            dataGridView.Columns.Add("PED_LIMINAR_TUTELA_PED_URG", "PED. LIMINAR / TUTELA ANT / PED. URG");//4
            dataGridView.Columns.Add("PARTE_PETICIONANTE", "PARTE PETICIONANTE");//5
            dataGridView.Columns.Add("TIPO_PESSOA", "TIPO DE PESSOA");//6
            dataGridView.Columns.Add("CPF_CNPJ", "CPF OU CNPJ");//7
            dataGridView.Columns.Add("NOME_PARTE", "NOME PARTE");//8
            dataGridView.Columns.Add("CEP", "CEP");//9
            dataGridView.Columns.Add("NUMERO", "NÚMERO");//10
            dataGridView.Columns.Add("COMPLEMENTO", "COMPLEMENTO");//11
            dataGridView.Columns.Add("STATUS", "STATUS");//12

        }

        public void AndamentoProcessual(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear(); 

            dataGridView.Columns.Add("CONTRATO", "CONTRATO");
            dataGridView.Columns.Add("NUM_PROCESSO", "NUM PROCESSO");
            dataGridView.Columns.Add("DISTRIBUICAO", "DISTRIBUIÇÃO");
            dataGridView.Columns.Add("VARA", "VARA");
            dataGridView.Columns.Add("FORO", "FORO");
            dataGridView.Columns.Add("CLASSE", "CLASSE");
            dataGridView.Columns.Add("AREA", "ÁREA");
            dataGridView.Columns.Add("ASSUNTO", "ASSUNTO");
            dataGridView.Columns.Add("JUIZ", "JUIZ");
            dataGridView.Columns.Add("VALOR_ACAO", "VALOR DA AÇÃO");
            dataGridView.Columns.Add("DADOS_REQUERENTES", "DADOS REQUERENTES");
            dataGridView.Columns.Add("DADOS_REQUERIDOS", "DADOS REQUERIDOS");
            dataGridView.Columns.Add("PROCESSO_DIGITAL", "PROCESSO DIGITAL");
            dataGridView.Columns.Add("ANDAMENTO_1", "ANDAMENTO 1");
            dataGridView.Columns.Add("ANDAMENTO_2", "ANDAMENTO 2");
            dataGridView.Columns.Add("ANDAMENTO_3", "ANDAMENTO 3");
            dataGridView.Columns.Add("ANDAMENTO_4", "ANDAMENTO 4");
            dataGridView.Columns.Add("ANDAMENTO_5", "ANDAMENTO 5");
            dataGridView.Columns.Add("ANDAMENTO_6", "ANDAMENTO 6");
            dataGridView.Columns.Add("ANDAMENTO_7", "ANDAMENTO 7");
            dataGridView.Columns.Add("ANDAMENTO_8", "ANDAMENTO 8");
            dataGridView.Columns.Add("ANDAMENTO_9", "ANDAMENTO 9");
            dataGridView.Columns.Add("ANDAMENTO_10", "ANDAMENTO 10");
        }
    }
}
