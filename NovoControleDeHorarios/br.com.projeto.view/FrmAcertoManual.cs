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
    public partial class FrmAcertoManual : Form {
        private MySqlConnection conexao;
        public FrmAcertoManual() {
            InitializeComponent();
            //pega os dados da connectio factory e insere no conexao
            this.conexao = new ConnectionFactory().GetConnection();
        }

        private void FrmAcertoManual_Load(object sender, EventArgs e) {
            //Recebe o nome do usuario no combobox e repassa o seu id
            UsuariosDao dao = new UsuariosDao();
            cmb_UserAcerto.DataSource = dao.ListarUsuarios();

            cmb_UserAcerto.DisplayMember = "nome";
            cmb_UserAcerto.ValueMember = "id";


        }

        private void btn_AcertoSalvar_Click(object sender, EventArgs e) {
            if (cmb_EntradaSaida.Text == "Entrada") {
                


                //puxa os dados do usuário para insert de novo horário de entrada manual
                try {
                    //define comando sql
                    string consulta = @"select nome, cpf, id from tb_usuarios where nome=@nome";

                    //organização do comando e parametros
                    MySqlCommand executaCmd = new MySqlCommand(consulta, conexao);
                    executaCmd.Parameters.AddWithValue("@nome", cmb_UserAcerto.Text);

                    //abre a conexao e executa o comando
                    conexao.Open();
                    executaCmd.ExecuteNonQuery();

                    //recebe o conteúdo do select do banco
                    MySqlDataReader dr;
                    dr = executaCmd.ExecuteReader();
                    dr.Read();

                    lb_cpf.Text = dr.GetString(1);
                    lb_Nome.Text = dr.GetString(0);
                    lb_Senha.Text = dr.GetString(2);


                    //fecha a conexão
                    conexao.Close();

                    //if(txt_EntraSai.Text == "s" || txt_EntraSai.Text == "S") {

                    //}
                } catch (Exception erro) {

                    MessageBox.Show("Erro ao buscar: " + erro);
                }

                //update no horario de entrada
                Horarios obj = new Horarios();

                obj.entrada = txt_HoraAcerto.Text;
                obj.Fk_id = int.Parse(cmb_UserAcerto.SelectedValue.ToString());
                obj.data = txt_DataAcerto.Text;
                obj.nome = lb_Nome.Text;
                obj.cpf = lb_cpf.Text;
                obj.senha = int.Parse(lb_Senha.Text);

                HorariosDao dao = new HorariosDao();
                dao.EntradaManual(obj);

            } else if (cmb_EntradaSaida.Text == "Saida") {
                //update no horario de saida
                Horarios obj = new Horarios();

                obj.saida = txt_HoraAcerto.Text;
                obj.Fk_id = int.Parse(cmb_UserAcerto.SelectedValue.ToString());
                obj.data = txt_DataAcerto.Text;

                HorariosDao dao = new HorariosDao();
                dao.SaidaManual(obj);
            }
        }

        private void cmb_UserAcerto_SelectedIndexChanged(object sender, EventArgs e) {
           
                
            
           
        }

    }
}
