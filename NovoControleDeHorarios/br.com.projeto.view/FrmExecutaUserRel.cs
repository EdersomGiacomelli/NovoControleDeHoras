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
    public partial class FrmExecutaUserRel : Form {
        public FrmExecutaUserRel() {
            InitializeComponent();
        }

        private void FrmExecutaUserRel_Load(object sender, EventArgs e) {

            this.reportViewer1.RefreshReport();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
    }
}
