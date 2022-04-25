using MySql.Data.MySqlClient;
using NovoControleDeHorarios.br.com.projeto.conexao;
using NovoControleDeHorarios.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoControleDeHorarios.br.com.projeto.dao {
    class HorariosDao {

        private MySqlConnection conexao;

        //pega os dados da connectio factory e insere no conexao
        public HorariosDao() {

            this.conexao = new ConnectionFactory().GetConnection();
        }


        #region Select dados da tb_usuarios
        public DataTable ListarDados(Horarios obj) {
            //define comando sql
            string consulta = @"select nome, cpf from tb_usuarios where senha=@senha";
            //organização do comando e parametros
            MySqlCommand executaCmd = new MySqlCommand(consulta, conexao);
            executaCmd.Parameters.AddWithValue("@senha", obj.senha);

            //abre a conexao e executa o comando
            conexao.Open();
            executaCmd.ExecuteNonQuery();
            DataTable tabelaHoras = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

            da.Fill(tabelaHoras);
            //fecha a conexão
            conexao.Close();

            return tabelaHoras;

        }

        #endregion

        #region Alterar a tabela de horários
        public void NovoPonto(Horarios obj) {
            /*
             * try {

                //definir o comando a ser executado SQL
                string sqlupdate = @"insert into tb_horarios (nome, cpf, permissao, senha) 
                                   values (@nome, @cpf, @permissao, @senha)";
                //organização do comando SQL
                //recebe parâmetros para o update
                MySqlCommand executaCmd = new MySqlCommand(sqlupdate, conexao);
                executaCmd.Parameters.AddWithValue("@nome", obj.nome);
                executaCmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executaCmd.Parameters.AddWithValue("@permissao", obj.permissao);
                executaCmd.Parameters.AddWithValue("@senha", obj.senha);
                executaCmd.Parameters.AddWithValue("@id", obj.id);

                //abre a conexão e executa o SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //fecha a conexão
                conexao.Close();

                //mostra a mensagem
                MessageBox.Show("Usuário Alterado!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao Alterar! -- Erro: " + erro); ;
            }
            
            */
        }
           

        #endregion
    }
}
