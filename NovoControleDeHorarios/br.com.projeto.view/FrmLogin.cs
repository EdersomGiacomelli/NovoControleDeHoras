using NovoControleDeHorarios.br.com.projeto.conexao;
using NovoControleDeHorarios.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NovoControleDeHorarios.br.com.projeto.view {
    public partial class FrmLogin : Form {
        
        public FrmLogin() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            string cpf, senha;

            cpf = txt_CpfLogin.Text;
            senha = txt_SenhaLogin.Text;

            UsuariosDao dao = new UsuariosDao();
            dao.EfetuarLogin(cpf, senha);

            //fecha tela de login
            this.Hide();
            
        }

        

        private void txt_SenhaLogin_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        private void txt_CpfLogin_KeyPress(object sender, KeyPressEventArgs e) {
            //permite apenas números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) {

                e.Handled = true;

            }
        }

        //carregar bd quando inicia o programa
        private void FrmLogin_Load(object sender, EventArgs e) {
            Mysql.conectar();
        }
    }
}
