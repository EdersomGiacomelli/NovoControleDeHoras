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
    public partial class FrmPonto : Form {
        public FrmPonto() {
            InitializeComponent();
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

                Horarios obj = new Horarios();
                HorariosDao dao = new HorariosDao();
                obj.senha = int.Parse(txt_SenhaPonto.Text);
                
                dao.ListarDados(obj);

                
                //recebe os campos de dados
                txt_Nome.Text = obj.nome;
                txt_Cpf.Text = obj.cpf;
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e) {
            txt_Horario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
        private void FrmPonto_Load(object sender, EventArgs e) {
            txt_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        #endregion

        
    }
}
