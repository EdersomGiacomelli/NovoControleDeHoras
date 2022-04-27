using NovoControleDeHorarios.br.com.projeto.dao;
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
        public FrmAcertoManual() {
            InitializeComponent();
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
                //update no horario de entrada

            } else if (cmb_EntradaSaida.Text == "Saida") {
                //update no horario de saida

            }
        }
    }
}
