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
    public partial class FrmMenu : Form {
        public FrmMenu() {
            InitializeComponent();
        }

        private void alterarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmUsuario User = new FrmUsuario();
            User.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void menu_Registro_Click(object sender, EventArgs e) {
            FrmPonto Ponto = new FrmPonto();
            Ponto.Show();
        }

        private void menu_RelatorioUser_Click(object sender, EventArgs e) {
            
        }

        private void btn_Registro_Click(object sender, EventArgs e) {
            FrmPonto Ponto = new FrmPonto();
            Ponto.Show();
        }

        private void menu_RelatorioAdmin_Click(object sender, EventArgs e) {
            FrmRelatorio Relatorio = new FrmRelatorio();
            Relatorio.Show();
        }
    }
}
