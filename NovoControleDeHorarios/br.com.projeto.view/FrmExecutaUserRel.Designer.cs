
namespace NovoControleDeHorarios.br.com.projeto.view {
    partial class FrmExecutaUserRel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dataInicial = new System.Windows.Forms.MaskedTextBox();
            this.txt_dataFim = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NovoControleDeHorarios.RelatorioUsuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(598, 362);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(421, 21);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar.TabIndex = 1;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(67, 23);
            this.txt_cpf.MaxLength = 11;
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // txt_dataInicial
            // 
            this.txt_dataInicial.Location = new System.Drawing.Point(223, 23);
            this.txt_dataInicial.Mask = "00/00/0000";
            this.txt_dataInicial.Name = "txt_dataInicial";
            this.txt_dataInicial.Size = new System.Drawing.Size(66, 20);
            this.txt_dataInicial.TabIndex = 6;
            this.txt_dataInicial.ValidatingType = typeof(System.DateTime);
            this.txt_dataInicial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txt_dataFim
            // 
            this.txt_dataFim.Location = new System.Drawing.Point(349, 23);
            this.txt_dataFim.Mask = "00/00/0000";
            this.txt_dataFim.Name = "txt_dataFim";
            this.txt_dataFim.Size = new System.Drawing.Size(66, 20);
            this.txt_dataFim.TabIndex = 7;
            this.txt_dataFim.ValidatingType = typeof(System.DateTime);
            // 
            // FrmExecutaUserRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.txt_dataFim);
            this.Controls.Add(this.txt_dataInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Filtrar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmExecutaUserRel";
            this.Text = "FrmExecutaUserRel";
            this.Load += new System.EventHandler(this.FrmExecutaUserRel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_dataInicial;
        private System.Windows.Forms.MaskedTextBox txt_dataFim;
    }
}