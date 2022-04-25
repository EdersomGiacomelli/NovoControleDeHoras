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
                    string consulta = @"select nome, cpf from tb_usuarios where senha=@senha";
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
                    

                    //fecha a conexão
                    conexao.Close();
                } catch (Exception erro) {

                    MessageBox.Show("Erro ao buscar: ");
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
    }
}
