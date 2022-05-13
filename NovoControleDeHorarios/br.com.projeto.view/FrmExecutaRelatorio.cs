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
    public partial class FrmExecutaRelatorio : Form {
        DataTable dt = new DataTable();
        public FrmExecutaRelatorio(DataTable dt) {

            InitializeComponent();
            this.dt = dt;
        }

        private void FrmExecutaRelatorio_Load(object sender, EventArgs e) {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new
                Microsoft.Reporting.WinForms.ReportDataSource("RelatorioDados", dt));

            this.reportViewer1.RefreshReport();
        }
    }
}
