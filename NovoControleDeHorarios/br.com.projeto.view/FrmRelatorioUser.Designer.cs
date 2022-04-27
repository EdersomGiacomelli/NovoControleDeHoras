
namespace NovoControleDeHorarios.br.com.projeto.view {
    partial class FrmRelatorioUser {
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
            this.btn_GerarRelatorio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DataFim = new System.Windows.Forms.MaskedTextBox();
            this.txt_DataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MostrarInfo = new System.Windows.Forms.Button();
            this.grid_Relatorio = new System.Windows.Forms.DataGridView();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GerarRelatorio
            // 
            this.btn_GerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_GerarRelatorio.Location = new System.Drawing.Point(205, 469);
            this.btn_GerarRelatorio.Name = "btn_GerarRelatorio";
            this.btn_GerarRelatorio.Size = new System.Drawing.Size(156, 33);
            this.btn_GerarRelatorio.TabIndex = 4;
            this.btn_GerarRelatorio.Text = "Gerar Relatório";
            this.btn_GerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(393, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Até: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(238, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "De: ";
            // 
            // txt_DataFim
            // 
            this.txt_DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_DataFim.Location = new System.Drawing.Point(434, 38);
            this.txt_DataFim.Mask = "00/00/0000";
            this.txt_DataFim.Name = "txt_DataFim";
            this.txt_DataFim.Size = new System.Drawing.Size(91, 24);
            this.txt_DataFim.TabIndex = 2;
            this.txt_DataFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DataFim.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DataInicial
            // 
            this.txt_DataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_DataInicial.Location = new System.Drawing.Point(279, 36);
            this.txt_DataInicial.Mask = "00/00/0000";
            this.txt_DataInicial.Name = "txt_DataInicial";
            this.txt_DataInicial.Size = new System.Drawing.Size(91, 24);
            this.txt_DataInicial.TabIndex = 1;
            this.txt_DataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(321, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Selecione o Período:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Digite seu CPF:";
            // 
            // btn_MostrarInfo
            // 
            this.btn_MostrarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_MostrarInfo.Location = new System.Drawing.Point(189, 99);
            this.btn_MostrarInfo.Name = "btn_MostrarInfo";
            this.btn_MostrarInfo.Size = new System.Drawing.Size(181, 33);
            this.btn_MostrarInfo.TabIndex = 3;
            this.btn_MostrarInfo.Text = "Mostrar Informações:";
            this.btn_MostrarInfo.UseVisualStyleBackColor = true;
            this.btn_MostrarInfo.Click += new System.EventHandler(this.btn_MostrarInfo_Click);
            // 
            // grid_Relatorio
            // 
            this.grid_Relatorio.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_Relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Relatorio.Location = new System.Drawing.Point(12, 151);
            this.grid_Relatorio.Name = "grid_Relatorio";
            this.grid_Relatorio.Size = new System.Drawing.Size(543, 312);
            this.grid_Relatorio.TabIndex = 22;
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cpf.Location = new System.Drawing.Point(36, 35);
            this.txt_Cpf.MaxLength = 11;
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(177, 24);
            this.txt_Cpf.TabIndex = 0;
            this.txt_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cpf_KeyPress);
            // 
            // FrmRelatorioUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 506);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.btn_GerarRelatorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DataFim);
            this.Controls.Add(this.txt_DataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MostrarInfo);
            this.Controls.Add(this.grid_Relatorio);
            this.Name = "FrmRelatorioUser";
            this.Text = "Relatorio de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Relatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GerarRelatorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_DataFim;
        private System.Windows.Forms.MaskedTextBox txt_DataInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MostrarInfo;
        private System.Windows.Forms.DataGridView grid_Relatorio;
        private System.Windows.Forms.TextBox txt_Cpf;
    }
}