using MySql.Data.MySqlClient;
using NovoControleDeHorarios.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovoControleDeHorarios.br.com.projeto.conexao;
using System.Windows.Forms;
using System.Data;

namespace NovoControleDeHorarios.br.com.projeto.dao {
    public class UsuariosDao {

        private MySqlConnection conexao;
        
        //pega os dados da connectio factory e insere no conexao
        public UsuariosDao() {

            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra um Usuário
        public void CadastrarUsuario(Usuarios obj) {
            try {

                //definir o comando a ser executado SQL
                string sqlinsert = @"insert into tb_usuarios (nome, cpf, permissao, senha) 
                                   values (@nome, @cpf, @permissao, @senha)";
                //organização do comando SQL
                //recebe parâmetros para o insert
                MySqlCommand executaCmd = new MySqlCommand(sqlinsert, conexao);
                executaCmd.Parameters.AddWithValue("@nome", obj.nome);
                executaCmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executaCmd.Parameters.AddWithValue("@permissao", obj.permissao);
                executaCmd.Parameters.AddWithValue("@senha", obj.senha);
                
                //abre a conexão, executa o SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();
                
                //fecha a conexão
                conexao.Close();

                //mostra a mensagem
                MessageBox.Show("Usuário Cadastrado!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao cadastrar! -- Erro: " + erro); ;
            }
        }

        #endregion

        #region Método que lista os usuários
        //Datatable porque ele vai retornar os dados cadastrados
        public DataTable ListarUsuarios() {
        
            //criar a string do comando sql
            string sqlList = @"select * from tb_usuarios";

            //organização do SQL (sem parâmetros não precisa, apenas executa o comando) 
            MySqlCommand executaCmd = new MySqlCommand(sqlList, conexao);

            //Abre a conexão e executa o comando
            conexao.Open();
            executaCmd.ExecuteNonQuery();

            //criar o dataTable e MySqlDataAdapter (adaptador de dados do Mysql)
            DataTable tabelaUsuarios = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(executaCmd);

            //preenche o datatable com os dados
            
            da.Fill(tabelaUsuarios);

            //fecha conexão
            conexao.Close();

            //retornar datatable com os dados
            return tabelaUsuarios;


        }

        #endregion

        #region Método de Exclusão de usuários

        public void ExcluirUsuario(Usuarios obj) {
            try {

                //definir o comando a ser executado SQL
                string sqldelete = @"delete from tb_usuarios where id = @id;";
                //organização do comando SQL
                //recebe parâmetros para o delete
                MySqlCommand executaCmd = new MySqlCommand(sqldelete, conexao);
                executaCmd.Parameters.AddWithValue("@id", obj.id);

                //abre a conexão, executa o SQL
                conexao.Open();
                executaCmd.ExecuteNonQuery();

                //fecha a conexão
                conexao.Close();

                //mostra a mensagem
                MessageBox.Show("Usuário Excluido!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao Excluir! -- Erro: " + erro); ;
            }
        }

        #endregion

        #region Método de Alteração de usuário

        public void AlterarUsuario(Usuarios obj) {
            try {

                    //definir o comando a ser executado SQL
                    string sqlupdate = @"update tb_usuarios set nome=@nome, 
                                       cpf=@cpf, permissao=@permissao, senha=@senha where id = @id;";
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
            }

        #endregion
    }
}
