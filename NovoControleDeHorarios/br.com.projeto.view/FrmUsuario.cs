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
    public partial class FrmUsuario : Form {
        public FrmUsuario() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmLogin Login = new FrmLogin();
            Login.Show();
        }

        private void btn_Salvar_Click(object sender, EventArgs e) {
            //Recebe dados da tela e envia para o BD

            Usuarios obj = new Usuarios();

            obj.nome = txt_Nome.Text;
            obj.cpf = txt_CPF.Text;
            obj.permissao = cmb_Nivel.SelectedItem.ToString();
            obj.senha = int.Parse(txt_Senha.Text);

            //Envia para o Banco de dados (cria objeto classe UsuariosDao)

            UsuariosDao dao = new UsuariosDao();
            dao.CadastrarUsuario(obj);

            //atualizar a data grid view
            grid_Usuarios.DataSource = dao.ListarUsuarios();
        }

        private void FrmUsuario_Load(object sender, EventArgs e) {
            //implemntar o metodo de listar quando carrega essa tela
            UsuariosDao dao = new UsuariosDao();

            //usar em todos os botões para atualizar o grid view
            grid_Usuarios.DataSource = dao.ListarUsuarios();

        }

        private void btn_Alterar_Click(object sender, EventArgs e) {
            //Recebe dados da tela e envia para o BD

            Usuarios obj = new Usuarios();

            //recebe os campos de dados
            obj.nome = txt_Nome.Text;
            obj.cpf = txt_CPF.Text;
            obj.permissao = cmb_Nivel.SelectedItem.ToString();
            obj.senha = int.Parse(txt_Senha.Text);
            obj.id = int.Parse(txt_Id.Text);

            //Envia para o Banco de dados (cria objeto classe UsuariosDao)

            UsuariosDao dao = new UsuariosDao();
            dao.AlterarUsuario(obj);

            //atualizar a data grid view
            grid_Usuarios.DataSource = dao.ListarUsuarios();
        }

        private void grid_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e) {
            txt_Id.Text = grid_Usuarios.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = grid_Usuarios.CurrentRow.Cells[1].Value.ToString();
            txt_CPF.Text = grid_Usuarios.CurrentRow.Cells[2].Value.ToString();
            cmb_Nivel.Text = grid_Usuarios.CurrentRow.Cells[3].Value.ToString();
            txt_Senha.Text = grid_Usuarios.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_Excluir_Click(object sender, EventArgs e) {
            //cria o objeto usuário
            Usuarios obj = new Usuarios();
            //recebe os parÂmetros necessários
            obj.id = int.Parse(txt_Id.Text);
            //chama o método de exclusão
            UsuariosDao dao = new UsuariosDao();
            dao.ExcluirUsuario(obj);

            //atualizar a data grid view
            grid_Usuarios.DataSource = dao.ListarUsuarios();
        }

        private void grid_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
