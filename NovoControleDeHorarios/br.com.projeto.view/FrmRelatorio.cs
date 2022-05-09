using MySql.Data.MySqlClient;
using NovoControleDeHorarios.br.com.projeto.conexao;
using NovoControleDeHorarios.br.com.projeto.dao;
using NovoControleDeHorarios.br.com.projeto.model;
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
    public partial class FrmRelatorio : Form {
        private MySqlConnection conexao;
        DataTable relatorio = new DataTable();
        DataTable tabelaFiltro = new DataTable();
        public FrmRelatorio() {
            InitializeComponent();
            this.conexao = new ConnectionFactory().GetConnection();
        }
        

        private void FrmRelatorio_Load(object sender, EventArgs e) {
            
            //Recebe o nome do usuario no combobox e repassa o seu id
            UsuariosDao dao = new UsuariosDao();
            cmb_UserRelatorio.DataSource = dao.ListarUsuarios();
            
            cmb_UserRelatorio.DisplayMember = "nome";
            cmb_UserRelatorio.ValueMember = "id";

            
            //carregar o datagriview
            HorariosDao daoHora = new HorariosDao();
            grid_Relatorio.DataSource = daoHora.ListarHorarios();
        }

        private void btn_MostrarInfo_Click(object sender, EventArgs e) {
            string datain, datafim;
            var id = cmb_UserRelatorio.Text;
            datain = txt_DataInicial.Text;
            datafim = txt_DataFim.Text;

            //criar a string do comando sql
            
            string sqlList = @"select a.Cpf_Reg, a.Nome_Reg, a.Data_Reg, a.Entrada, a.Saida, b.semanal
                            from tb_datas as b
                            inner join tb_horarios as a
                            on b.dia = a.Data_Reg
                            WHERE Nome_Reg=@id and Data_Reg between @datainicio and @datafim;" ;

            /*string sqlList = @"select Cpf_Reg, Nome_Reg, Data_Reg, Entrada, Saida
                            from tb_horarios WHERE Nome_Reg=@id and Data_Reg between @datainicio and @datafim;";
            */

            //organização do SQL (sem parâmetros não precisa, apenas executa o comando) 
            MySqlCommand executaCmd = new MySqlCommand(sqlList, conexao);

            executaCmd.Parameters.AddWithValue("@id", id);
            executaCmd.Parameters.AddWithValue("@datainicio", datain);
            executaCmd.Parameters.AddWithValue("@datafim", datafim);
            //Abre a conexão e executa o comando
            conexao.Open();
            executaCmd.ExecuteNonQuery();

            //criar o dataTable e MySqlDataAdapter (adaptador de dados do Mysql)
            //DataTable tabelaFiltro = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

            //preenche o datatable com os dados

            da.Fill(tabelaFiltro);

            //fecha conexão
            conexao.Close();

            grid_Relatorio.DataSource = tabelaFiltro;

            //relatorio = tabelaFiltro;

        }

        private void btn_GerarRelatorio_Click(object sender, EventArgs e) {
            var dt = GerarRelatorio();
            using(var frm = new FrmExecutaRelatorio(dt)) {
                frm.ShowDialog();
            }
        }

        private DataTable GerarRelatorio() {
            var dt = new DataTable();
            dt.Columns.Add("Cpf_Reg");
            dt.Columns.Add("Data_Reg");
            dt.Columns.Add("Entrada");
            dt.Columns.Add("Saida");

            //percorre o datagrid e preenche os dados no datatable
            
            foreach (DataGridViewRow item in grid_Relatorio.Rows) {
                dt.Rows.Add(item.Cells[0].Value.ToString(),
                item.Cells[1].Value.ToString(),
                item.Cells[2].Value.ToString(),
                item.Cells[3].Value.ToString());
            }
            return dt;
        } 
    }
}
