﻿
namespace NovoControleDeHorarios.br.com.projeto.view {
    partial class FrmRelatorio {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DataFim = new System.Windows.Forms.MaskedTextBox();
            this.txt_DataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_UserRelatorio = new System.Windows.Forms.ComboBox();
            this.grid_Relatorio = new System.Windows.Forms.DataGridView();
            this.btn_GerarRelatorio = new System.Windows.Forms.Button();
            this.btn_MostrarInfo = new System.Windows.Forms.Button();
            this.lbData2 = new System.Windows.Forms.Label();
            this.lbData1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(487, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Até: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(332, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "De: ";
            // 
            // txt_DataFim
            // 
            this.txt_DataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_DataFim.Location = new System.Drawing.Point(528, 87);
            this.txt_DataFim.Mask = "00/00/0000";
            this.txt_DataFim.Name = "txt_DataFim";
            this.txt_DataFim.Size = new System.Drawing.Size(91, 24);
            this.txt_DataFim.TabIndex = 14;
            this.txt_DataFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DataFim.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DataInicial
            // 
            this.txt_DataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_DataInicial.Location = new System.Drawing.Point(373, 85);
            this.txt_DataInicial.Mask = "00/00/0000";
            this.txt_DataInicial.Name = "txt_DataInicial";
            this.txt_DataInicial.Size = new System.Drawing.Size(91, 24);
            this.txt_DataInicial.TabIndex = 13;
            this.txt_DataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(415, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selecione o Período:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Selecione o Usuário:";
            // 
            // cmb_UserRelatorio
            // 
            this.cmb_UserRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmb_UserRelatorio.FormattingEnabled = true;
            this.cmb_UserRelatorio.Location = new System.Drawing.Point(37, 85);
            this.cmb_UserRelatorio.Name = "cmb_UserRelatorio";
            this.cmb_UserRelatorio.Size = new System.Drawing.Size(283, 26);
            this.cmb_UserRelatorio.TabIndex = 11;
            // 
            // grid_Relatorio
            // 
            this.grid_Relatorio.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.grid_Relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Relatorio.Location = new System.Drawing.Point(12, 221);
            this.grid_Relatorio.Name = "grid_Relatorio";
            this.grid_Relatorio.Size = new System.Drawing.Size(647, 312);
            this.grid_Relatorio.TabIndex = 12;
            this.grid_Relatorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Relatorio_CellContentClick);
            // 
            // btn_GerarRelatorio
            // 
            this.btn_GerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_GerarRelatorio.Image = global::NovoControleDeHorarios.Properties.Resources.relatorio;
            this.btn_GerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GerarRelatorio.Location = new System.Drawing.Point(266, 539);
            this.btn_GerarRelatorio.Name = "btn_GerarRelatorio";
            this.btn_GerarRelatorio.Size = new System.Drawing.Size(144, 33);
            this.btn_GerarRelatorio.TabIndex = 20;
            this.btn_GerarRelatorio.Text = "Gerar Relatório";
            this.btn_GerarRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GerarRelatorio.UseVisualStyleBackColor = true;
            this.btn_GerarRelatorio.Click += new System.EventHandler(this.btn_GerarRelatorio_Click);
            // 
            // btn_MostrarInfo
            // 
            this.btn_MostrarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_MostrarInfo.Image = global::NovoControleDeHorarios.Properties.Resources.filtro;
            this.btn_MostrarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MostrarInfo.Location = new System.Drawing.Point(243, 172);
            this.btn_MostrarInfo.Name = "btn_MostrarInfo";
            this.btn_MostrarInfo.Size = new System.Drawing.Size(185, 33);
            this.btn_MostrarInfo.TabIndex = 15;
            this.btn_MostrarInfo.Text = "Mostrar Informações:";
            this.btn_MostrarInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MostrarInfo.UseVisualStyleBackColor = true;
            this.btn_MostrarInfo.Click += new System.EventHandler(this.btn_MostrarInfo_Click);
            // 
            // lbData2
            // 
            this.lbData2.AutoSize = true;
            this.lbData2.Location = new System.Drawing.Point(525, 114);
            this.lbData2.Name = "lbData2";
            this.lbData2.Size = new System.Drawing.Size(0, 13);
            this.lbData2.TabIndex = 33;
            // 
            // lbData1
            // 
            this.lbData1.AutoSize = true;
            this.lbData1.Location = new System.Drawing.Point(370, 114);
            this.lbData1.Name = "lbData1";
            this.lbData1.Size = new System.Drawing.Size(0, 13);
            this.lbData1.TabIndex = 32;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(626, 87);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(32, 23);
            this.btn_ok.TabIndex = 34;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 584);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbData2);
            this.Controls.Add(this.lbData1);
            this.Controls.Add(this.btn_GerarRelatorio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DataFim);
            this.Controls.Add(this.txt_DataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MostrarInfo);
            this.Controls.Add(this.cmb_UserRelatorio);
            this.Controls.Add(this.grid_Relatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Pontos";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
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
        private System.Windows.Forms.ComboBox cmb_UserRelatorio;
        private System.Windows.Forms.DataGridView grid_Relatorio;
        private System.Windows.Forms.Label lbData2;
        private System.Windows.Forms.Label lbData1;
        private System.Windows.Forms.Button btn_ok;
    }
}