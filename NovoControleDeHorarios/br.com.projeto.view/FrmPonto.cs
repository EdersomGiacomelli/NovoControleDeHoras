using NovoControleDeHorarios.br.com.projeto.dao;
using NovoControleDeHorarios.br.com.projeto.model;
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
using MySql.Data.MySqlClient;

namespace NovoControleDeHorarios.br.com.projeto.view {
    public partial class FrmPonto : Form {

        private MySqlConnection conexao;
        public FrmPonto() {
            InitializeComponent();
            //pega os dados da connectio factory e insere no conexao
            this.conexao = new ConnectionFactory().GetConnection();
        }

        

        #region Atualização de horários e tab automático

        private void txt_EntraSai_TextChanged(object sender, EventArgs e) {
            if (((TextBox)sender).Text.Length == 1) {
                SendKeys.Send("{TAB}");
               
            }
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e) {
            if (((TextBox)sender).Text.Length == 4) {
                SendKeys.Send("{TAB}");
                try {
                    //define comando sql
                    string consulta = @"select nome, cpf, id from tb_usuarios where senha=@senha";

                    //organização do comando e parametros
                    MySqlCommand executaCmd = new MySqlCommand(consulta, conexao);
                    executaCmd.Parameters.AddWithValue("@senha", txt_SenhaPonto.Text);

                    //abre a conexao e executa o comando
                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    //recebe o conteúdo do select do banco
                    MySqlDataReader dr;
                    dr = executaCmd.ExecuteReader();
                    dr.Read();

                    txt_Nome.Text = dr.GetString(0);
                    txt_Cpf.Text = dr.GetString(1);
                    txt_Id.Text = dr.GetString(2);
                    

                    //fecha a conexão
                    conexao.Close();

                    //if(txt_EntraSai.Text == "s" || txt_EntraSai.Text == "S") {
                        
                    //}
                } catch (Exception erro) {

                    MessageBox.Show("Erro ao buscar: " + erro);
                }
                
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e) {
            txt_Horario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
        private void FrmPonto_Load(object sender, EventArgs e) {
            txt_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        #endregion

        private void txt_SenhaPonto_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e) {
            if (txt_EntraSai.Text == "e" || txt_EntraSai.Text == "E") {
                //vai fazer um insert na tabela de horários com valores obtidos e saida como mesmo horário da entrada
                //Recebe dados da tela e envia para o BD

                Horarios obj = new Horarios();

                obj.cpf = txt_Cpf.Text;
                obj.nome = txt_Nome.Text;
                obj.data = txt_Data.Text;
                obj.entrada = txt_Horario.Text;
                obj.saida = txt_Horario.Text;
                obj.senha = int.Parse(txt_SenhaPonto.Text);
                obj.Fk_id = int.Parse(txt_Id.Text);

                //Envia para o Banco de dados (cria objeto classe UsuariosDao)

                HorariosDao dao = new HorariosDao();
                dao.NovoPonto(obj);

            } else if (txt_EntraSai.Text == "s" || txt_EntraSai.Text == "S") {

                try {
                    //define comando sql
                    string consulta = @"select Id_Reg from tb_horarios where Data_Reg =@Data_Reg and Senha_Reg =@Senha_Reg;";
                    //organização do comando e parametros
                    MySqlCommand executaCmd = new MySqlCommand(consulta, conexao);
                    executaCmd.Parameters.AddWithValue("@Data_Reg", txt_Data.Text);
                    executaCmd.Parameters.AddWithValue("@Senha_Reg", int.Parse(txt_SenhaPonto.Text));

                    //abre a conexao e executa o comando
                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    //recebe o conteúdo do select do banco
                    MySqlDataReader dr;
                    dr = executaCmd.ExecuteReader();
                    dr.Read();

                    txt_registro.Text = dr.GetString(0);

                    //fecha a conexão
                    conexao.Close();

                    if (txt_registro.Text.Length == 0)
                    {
                        MessageBox.Show("Não existe uma entrada para este usuário. Verifique!!!");
                        txt_EntraSai.Focus();
                    } else
                    {

                        // realiza um update na tabela de horários, alterando apenas o horário de saída
                        Horarios objt = new Horarios();
                        objt.id = int.Parse(txt_registro.Text);
                        objt.cpf = txt_Cpf.Text;
                        objt.nome = txt_Nome.Text;
                        objt.data = txt_Data.Text;
                        objt.entrada = txt_Horario.Text;
                        objt.saida = txt_Horario.Text;
                        objt.senha = int.Parse(txt_SenhaPonto.Text);
                        objt.Fk_id = int.Parse(txt_Id.Text);

                        //Envia para o Banco de dados (cria objeto classe UsuariosDao)

                        HorariosDao dao = new HorariosDao();
                        dao.NovaSaida(objt);

                    }
                } catch (Exception erro) {

                    MessageBox.Show("Erro:" + erro);
                }
                /*
                // realiza um update na tabela de horários, alterando apenas o horário de saída
                Horarios objt = new Horarios();
                objt.id = int.Parse(txt_registro.Text);
                objt.cpf = txt_Cpf.Text;
                objt.nome = txt_Nome.Text;
                objt.data = txt_Data.Text;
                objt.entrada = txt_Horario.Text;
                objt.saida = txt_Horario.Text;
                objt.senha = int.Parse(txt_SenhaPonto.Text);
                objt.Fk_id = int.Parse(txt_Id.Text);

                //Envia para o Banco de dados (cria objeto classe UsuariosDao)

                HorariosDao dao = new HorariosDao();
                dao.NovaSaida(objt);
                */
               

            } else {
                MessageBox.Show("Digite apenas E para entrada ou S para saída!");
            }
            txt_EntraSai.Text = string.Empty;
            txt_SenhaPonto.Text = string.Empty;
            txt_Id.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_Cpf.Text = string.Empty;
            txt_registro.Text = string.Empty;
            txt_EntraSai.Focus();
        }
    }
}
