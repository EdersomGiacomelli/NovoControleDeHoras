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
    public partial class FrmTorcaSenha : Form {
        public FrmTorcaSenha() {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        private void btn_TrocaSenha_Click(object sender, EventArgs e) {
            int senhaatual, senhanova, confirma;

            senhaatual = int.Parse(txt_Atual.Text);
            senhanova = int.Parse(txt_Nova.Text);
            confirma = int.Parse(txt_Confirma.Text);

            if(senhaatual == senhanova) {
                MessageBox.Show("Utilize uma nova senha diferente da atual!");
            } else {
                if (senhanova == confirma) {
                    //faz a alteração da senha
                    //Recebe dados da tela e envia para o BD

                    Usuarios obj = new Usuarios();

                    //recebe os campos de dados
                    obj.cpf = txt_Cpf.Text;
                    obj.senha = int.Parse(txt_Atual.Text); 
                    obj.novasenha = int.Parse(txt_Confirma.Text);

                    //Envia para o Banco de dados (cria objeto classe UsuariosDao)

                    UsuariosDao dao = new UsuariosDao();
                    dao.AlterarSenha(obj);
                }
                else {
                    MessageBox.Show("Os campos nova senha e confirmação estão diferentes! Verifique e tente novamente!");
                }
            }
        }
    }
}
