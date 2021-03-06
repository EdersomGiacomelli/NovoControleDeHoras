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
            FrmRelatorioUser rel = new FrmRelatorioUser();
            rel.Show();
        }

        private void btn_Registro_Click(object sender, EventArgs e) {
            FrmPonto Ponto = new FrmPonto();
            Ponto.Show();
        }

        private void menu_RelatorioAdmin_Click(object sender, EventArgs e) {
            FrmRelatorio Relatorio = new FrmRelatorio();
            Relatorio.Show();
        }

        private void btn_Troca_Click(object sender, EventArgs e) {
            FrmRelatorio Relatorio = new FrmRelatorio();
            Relatorio.Show();

        }

        private void menu_TrocaUser_Click(object sender, EventArgs e) {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        private void menu_Manual_Click(object sender, EventArgs e) {
            FrmAcertoManual acerto = new FrmAcertoManual();
            acerto.Show();
            
        }

        private void menu_Senha_Click(object sender, EventArgs e) {
            FrmTorcaSenha senha = new FrmTorcaSenha();
            senha.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e) {
            Mysql.conectar();
        }
    }
}
