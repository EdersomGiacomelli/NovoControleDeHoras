using MySql.Data.MySqlClient;
using NovoControleDeHorarios.br.com.projeto.conexao;
using NovoControleDeHorarios.br.com.projeto.model;
using NovoControleDeHorarios.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoControleDeHorarios.br.com.projeto.dao {
    class HorariosDao {

        private MySqlConnection conexao;

        //pega os dados da connectio factory e insere no conexao
        public HorariosDao() {

            this.conexao = new ConnectionFactory().GetConnection();
        }


        #region Select dados da tb_usuarios
        public void ListarDados(Horarios obj) {
            // inserido diretamente no form
            //verificar posteriormente
        }
        #endregion

        #region Filtrar o relatorio
        /*public DataTable Filtrar() {
            //criar a string do comando sql
            string sqlList = @"select * from tb_horarios WHERE Data_Reg between '@datainicio' and '@datafim';";

            //organização do SQL (sem parâmetros não precisa, apenas executa o comando) 
            MySqlCommand executaCmd = new MySqlCommand(sqlList, conexao);

            executaCmd.Parameters.AddWithValue("@datafim", );
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

            //retornar datatable com os dados
            return tabelaFiltro;
        }*/

        #endregion

        #region Listar dados dos registros na tela relatorio
        public DataTable ListarHorarios() {

            //criar a string do comando sql
            string sqlList = @"select Cpf_Reg, Nome_Reg, Data_Reg, Entrada, Saida from tb_horarios";

            //organização do SQL (sem parâmetros não precisa, apenas executa o comando) 
            MySqlCommand executaCmd = new MySqlCommand(sqlList, conexao);

            //Abre a conexão e executa o comando
            conexao.Open();
            executaCmd.ExecuteNonQuery();

            //criar o dataTable e MySqlDataAdapter (adaptador de dados do Mysql)
            DataTable tabelaHorarios = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

            //preenche o datatable com os dados

            da.Fill(tabelaHorarios);

            //fecha conexão
            conexao.Close();

            //retornar datatable com os dados
            return tabelaHorarios;
            

        }

        #endregion

        #region Alterar a tabela de horários (Entrada)
        public void NovoPonto(Horarios obj) {
            try {

                //definir o comando a ser executado SQL
                string sqlinsert = @"insert ignore into tb_horarios (Cpf_Reg, Nome_Reg, Data_Reg,
                                    Entrada, Saida, Senha_Reg, Fk_Id) Values (@Cpf_Reg,
                                    @Nome_Reg, @Data_Reg, @Entrada, @Saida, @Senha_Reg, @Fk_Id);";
                //organização do comando SQL
                //recebe parâmetros para o insert
                MySqlCommand executaCmd = new MySqlCommand(sqlinsert, conexao);
                executaCmd.Parameters.AddWithValue("@Cpf_Reg", obj.cpf);
                executaCmd.Parameters.AddWithValue("@Nome_Reg", obj.nome);
                executaCmd.Parameters.AddWithValue("@Data_Reg", obj.data);
                executaCmd.Parameters.AddWithValue("@Entrada", obj.entrada);
                executaCmd.Parameters.AddWithValue("@Saida", obj.saida);
                executaCmd.Parameters.AddWithValue("@Senha_Reg", obj.senha);
                executaCmd.Parameters.AddWithValue("@Fk_Id", obj.Fk_id);

                //abre a conexão, executa o SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //fecha a conexão
                conexao.Close();

                //mostra a mensagem
                MessageBox.Show("Entrada registrada!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao cadastrar! -- Erro: " + erro); ;
            }
        }


        #endregion

        #region Alterar tabela horários (saída)

        public void NovaSaida(Horarios objt) {
            try {

                //definir o comando a ser executado SQL
                string sqlup = @"update tb_horarios set Saida=@Saida Where Id_Reg=@Id";
                //organização do comando SQL
                //recebe parâmetros para o update
                MySqlCommand executaCmd = new MySqlCommand(sqlup, conexao);
                executaCmd.Parameters.AddWithValue("@Id", objt.id);
                executaCmd.Parameters.AddWithValue("@Cpf_Reg", objt.cpf);
                executaCmd.Parameters.AddWithValue("@Nome_Reg", objt.nome);
                executaCmd.Parameters.AddWithValue("@Data_Reg", objt.data);
                executaCmd.Parameters.AddWithValue("@Entrada", objt.entrada);
                executaCmd.Parameters.AddWithValue("@Saida", objt.saida);
                executaCmd.Parameters.AddWithValue("@Senha_Reg", objt.senha);
                executaCmd.Parameters.AddWithValue("@Fk_Id", objt.Fk_id);

                //abre a conexão, executa o SQL
                conexao.Open();
                //ExecutarSafe.ExecuteNonQuery();
                executaCmd.ExecuteNonQuery();

                //fecha a conexão
                conexao.Close();

                //mostra a mensagem
                MessageBox.Show("Saída registrada!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao cadastrar! -- Erro: " + erro); ;
                
            }
        }

        #endregion


        #region Alteraçao de horario entrada e saida
        public void EntradaManual(Horarios obj) {
            try {

                //definir o comando a ser executado SQL
                string sqlinsert = @"insert into tb_horarios (Cpf_Reg, Nome_Reg, Data_Reg,
                                    Entrada, Saida, Senha_Reg, Fk_Id) values (@Cpf_Reg,
                                    @Nome_Reg, @Data_Reg, @Entrada, '00:00', @Senha_Reg, @Fk_Id);";
                //organização do comando SQL
                //recebe parâmetros para o update
                MySqlCommand executaCmd = new MySqlCommand(sqlinsert, conexao);
                executaCmd.Parameters.AddWithValue("@Entrada", obj.entrada);
                executaCmd.Parameters.AddWithValue("@Fk_Id", obj.Fk_id);
                executaCmd.Parameters.AddWithValue("@Data_Reg", obj.data);
                executaCmd.Parameters.AddWithValue("@Cpf_Reg", obj.cpf);
                executaCmd.Parameters.AddWithValue("@Senha_Reg", obj.senha);
                executaCmd.Parameters.AddWithValue("@Nome_Reg", obj.nome);
                

                //abre a conexão e executa o SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //fecha a conexão
                conexao.Close();

                //mostra a mensagem
                MessageBox.Show("Horario Alterado!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao Alterar! -- Erro: " + erro); ;
            }
        }

        public void SaidaManual(Horarios obj) {
            try {

                //definir o comando a ser executado SQL
                string sqlupdate = @"update tb_horarios set Saida=@saida where Fk_Id=@id and Data_Reg=@data;";
                //organização do comando SQL
                //recebe parâmetros para o update
                MySqlCommand executaCmd = new MySqlCommand(sqlupdate, conexao);
                executaCmd.Parameters.AddWithValue("@saida", obj.saida);
                executaCmd.Parameters.AddWithValue("@id", obj.Fk_id);
                executaCmd.Parameters.AddWithValue("@data", obj.data);


                //abre a conexão e executa o SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //fecha a conexão
                conexao.Close();

                //mostra a mensagem
                MessageBox.Show("Horario Alterado!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao Alterar! -- Erro: " + erro); ;
            }
        }
        #endregion
    }
}
