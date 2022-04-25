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

        #region Alterar a tabela de horários
        public void NovoPonto(Horarios obj) {
            try {

                //definir o comando a ser executado SQL
                string sqlinsert = @"insert into tb_horarios (Cpf_Reg, Nome_Reg, Data_Reg,
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
                MessageBox.Show("Horário registrado!");
            } catch (Exception erro) {

                MessageBox.Show("Erro ao cadastrar! -- Erro: " + erro); ;
            }
        }
           

        #endregion
    }
}
