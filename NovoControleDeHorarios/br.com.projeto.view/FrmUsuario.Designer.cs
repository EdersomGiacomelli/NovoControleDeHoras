
namespace NovoControleDeHorarios.br.com.projeto.view {
    partial class FrmUsuario {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_Nivel = new System.Windows.Forms.ComboBox();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_Usuarios = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 37);
            this.panel2.TabIndex = 1;
            // 
            // cmb_Nivel
            // 
            this.cmb_Nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmb_Nivel.FormattingEnabled = true;
            this.cmb_Nivel.Items.AddRange(new object[] {
            "Usuario",
            "Admin"});
            this.cmb_Nivel.Location = new System.Drawing.Point(187, 176);
            this.cmb_Nivel.Name = "cmb_Nivel";
            this.cmb_Nivel.Size = new System.Drawing.Size(90, 26);
            this.cmb_Nivel.TabIndex = 11;
            this.cmb_Nivel.Text = "Selecione...";
            // 
            // txt_CPF
            // 
            this.txt_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CPF.Location = new System.Drawing.Point(43, 177);
            this.txt_CPF.Mask = "00000000000";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(115, 24);
            this.txt_CPF.TabIndex = 10;
            this.txt_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Senha.Location = new System.Drawing.Point(43, 241);
            this.txt_Senha.MaxLength = 4;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(115, 24);
            this.txt_Senha.TabIndex = 13;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Senha.TextChanged += new System.EventHandler(this.txt_Senha_TextChanged);
            this.txt_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Senha_KeyPress);
            // 
            // txt_Nome
            // 
            this.txt_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Nome.Location = new System.Drawing.Point(43, 112);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(351, 24);
            this.txt_Nome.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(40, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(40, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // grid_Usuarios
            // 
            this.grid_Usuarios.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Usuarios.Location = new System.Drawing.Point(12, 287);
            this.grid_Usuarios.Name = "grid_Usuarios";
            this.grid_Usuarios.ReadOnly = true;
            this.grid_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Usuarios.Size = new System.Drawing.Size(421, 228);
            this.grid_Usuarios.TabIndex = 17;
            this.grid_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Usuarios_CellClick);
            this.grid_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Usuarios_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(40, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "CPF";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_Id.Location = new System.Drawing.Point(187, 241);
            this.txt_Id.MaxLength = 4;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(72, 24);
            this.txt_Id.TabIndex = 20;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(184, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Alterar.Image = global::NovoControleDeHorarios.Properties.Resources.trocar;
            this.btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alterar.Location = new System.Drawing.Point(309, 200);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(85, 38);
            this.btn_Alterar.TabIndex = 15;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Excluir.Image = global::NovoControleDeHorarios.Properties.Resources.lixo;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excluir.Location = new System.Drawing.Point(309, 244);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(85, 37);
            this.btn_Excluir.TabIndex = 16;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Salvar.Image = global::NovoControleDeHorarios.Properties.Resources.salvar__1_;
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salvar.Location = new System.Drawing.Point(309, 156);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(85, 38);
            this.btn_Salvar.TabIndex = 14;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NovoControleDeHorarios.Properties.Resources.tecnologia;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 80);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cadastro de Usuários";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 558);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grid_Usuarios);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.cmb_Nivel);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.ComboBox cmb_Nivel;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_Usuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label3;
    }
}