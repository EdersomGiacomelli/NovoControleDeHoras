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
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (int.Parse(txt_SenhaLogin.Text) == 1234) {
                FrmMenu Login = new FrmMenu();
                Login.Show();
            }
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
    }
}
