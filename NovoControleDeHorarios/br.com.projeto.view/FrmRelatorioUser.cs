using MySql.Data.MySqlClient;
using NovoControleDeHorarios.br.com.projeto.conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoControleDeHorarios.br.com.projeto.view {
    public partial class FrmRelatorioUser : Form {
        private MySqlConnection conexao;
        public FrmRelatorioUser() {
            InitializeComponent();
            this.conexao = new ConnectionFactory().GetConnection();
        }

        private void txt_Cpf_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        private void btn_MostrarInfo_Click(object sender, EventArgs e) {
            string datain, datafim, cpf;
            
            datain = txt_DataInicial.Text;
            datafim = txt_DataFim.Text;
            cpf = txt_Cpf.Text;

            //criar a string do comando sql
            string sqlList = @"select Cpf_Reg, Nome_Reg, Data_Reg, Entrada, Saida
                            from tb_horarios WHERE Cpf_Reg=@cpf and Data_Reg between @datainicio and @datafim;";

            //organização do SQL (sem parâmetros não precisa, apenas executa o comando) 
            MySqlCommand executaCmd = new MySqlCommand(sqlList, conexao);

            executaCmd.Parameters.AddWithValue("@cpf", cpf);
            executaCmd.Parameters.AddWithValue("@datainicio", datain);
            executaCmd.Parameters.AddWithValue("@datafim", datafim);
            //Abre a conexão e executa o comando
            conexao.Open();
            executaCmd.ExecuteNonQuery();

            //criar o dataTable e MySqlDataAdapter (adaptador de dados do Mysql)
            DataTable tabelaFiltro = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

            //preenche o datatable com os dados

            da.Fill(tabelaFiltro);

            //fecha conexão
            conexao.Close();

            grid_Relatorio.DataSource = tabelaFiltro;
        }
    }
}
