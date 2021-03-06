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
        DataTable tabelaFiltro = new DataTable();
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
            tabelaFiltro.Clear();
            var cpf = txt_Cpf.Text;

            //teste tb_data
            string select = @"select  a.Cpf_Reg, a.Nome_Reg, b.diastring, a.Entrada, a.Saida, b.semanal
                            from dias as b
                            left join tb_horarios as a
                            on a.Cpf_Reg=@cpf and diastring = Data_Reg;";

            //organização do SQL (sem parâmetros não precisa, apenas executa o comando) 
            MySqlCommand executaCmd = new MySqlCommand(select, conexao);

            executaCmd.Parameters.AddWithValue("@cpf", cpf);
            //Abre a conexão e executa o comando
            conexao.Open();
            executaCmd.ExecuteNonQuery();

            //criar o dataTable e MySqlDataAdapter (adaptador de dados do Mysql)
            MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

            //preenche o datatable com os dados

            da.Fill(tabelaFiltro);

            //fecha conexão
            conexao.Close();

            grid_Relatorio.DataSource = tabelaFiltro;
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            //Recebe as datas em formato padrão e modifica para date de uso do Mysql
            string datain = txt_DataInicial.Text;
            string[] diain = datain.Split('/');
            string inicial = diain[2] + '-' + diain[1] + '-' + diain[0];
            lbData1.Text = inicial;
            string datafim = txt_DataFim.Text;
            string[] diafim = datafim.Split('/');
            string final = diafim[2] + '-' + diafim[1] + '-' + diafim[0];
            lbData2.Text = final;

            string view = @"create or replace view dias as select diastring, semanal from tb_data
                            where dia between @datainicio and @datafim;";

            //organização do SQL (sem parâmetros não precisa, apenas executa o comando) 
            MySqlCommand executaCmd = new MySqlCommand(view, conexao);

            executaCmd.Parameters.AddWithValue("@datainicio", inicial);
            executaCmd.Parameters.AddWithValue("@datafim", final);
            //Abre a conexão e executa o comando
            conexao.Open();

            executaCmd.ExecuteNonQuery();

            conexao.Close();
        }

        private void btn_GerarRelatorio_Click(object sender, EventArgs e) {
            var dt = GerarRelatorio();
            using (var frm = new FrmExecutaRelatorio(dt)) {
                frm.ShowDialog();
            }
        }

        private DataTable GerarRelatorio() {
            var dt = new DataTable();
            dt.Columns.Add("nome");
            dt.Columns.Add("cpf");
            dt.Columns.Add("data");
            dt.Columns.Add("Entrada");
            dt.Columns.Add("Saida");
            dt.Columns.Add("semanal");

            //percorre o datagrid e preenche os dados no datatable
            int row = int.Parse(grid_Relatorio.Rows.Count.ToString()) - 1;

            foreach (DataGridViewRow item in grid_Relatorio.Rows) {


                dt.Rows.Add(
                item.Cells["Nome_Reg"].Value.ToString(),
                item.Cells["Cpf_Reg"].Value.ToString(),
                item.Cells["diastring"].Value.ToString(),
                item.Cells["Entrada"].Value.ToString(),
                item.Cells["Saida"].Value.ToString(),
                item.Cells["semanal"].Value.ToString());
                row--;
                if (row == 0) {
                    break;
                }


            }
            return dt;
        }
    }
}
