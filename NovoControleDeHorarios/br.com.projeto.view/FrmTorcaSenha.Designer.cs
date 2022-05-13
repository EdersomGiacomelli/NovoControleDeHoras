
namespace NovoControleDeHorarios.br.com.projeto.view {
    partial class FrmTorcaSenha {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTorcaSenha));
            this.btn_TrocaSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.txt_Nova = new System.Windows.Forms.TextBox();
            this.txt_Atual = new System.Windows.Forms.TextBox();
            this.txt_Confirma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_TrocaSenha
            // 
            this.btn_TrocaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_TrocaSenha.Image = global::NovoControleDeHorarios.Properties.Resources.salvar__1_;
            this.btn_TrocaSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrocaSenha.Location = new System.Drawing.Point(103, 301);
            this.btn_TrocaSenha.Name = "btn_TrocaSenha";
            this.btn_TrocaSenha.Size = new System.Drawing.Size(89, 33);
            this.btn_TrocaSenha.TabIndex = 4;
            this.btn_TrocaSenha.Text = "Salvar";
            this.btn_TrocaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TrocaSenha.UseVisualStyleBackColor = true;
            this.btn_TrocaSenha.Click += new System.EventHandler(this.btn_TrocaSenha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(61, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nova Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(61, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(58, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirmar Nova Senha";
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cpf.Location = new System.Drawing.Point(64, 53);
            this.txt_Cpf.MaxLength = 11;
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(175, 24);
            this.txt_Cpf.TabIndex = 0;
            this.txt_Cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_Nova
            // 
            this.txt_Nova.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nova.Location = new System.Drawing.Point(64, 188);
            this.txt_Nova.MaxLength = 4;
            this.txt_Nova.Name = "txt_Nova";
            this.txt_Nova.PasswordChar = '*';
            this.txt_Nova.Size = new System.Drawing.Size(175, 24);
            this.txt_Nova.TabIndex = 2;
            this.txt_Nova.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nova.UseSystemPasswordChar = true;
            this.txt_Nova.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txt_Atual
            // 
            this.txt_Atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Atual.Location = new System.Drawing.Point(64, 120);
            this.txt_Atual.MaxLength = 4;
            this.txt_Atual.Name = "txt_Atual";
            this.txt_Atual.PasswordChar = '*';
            this.txt_Atual.Size = new System.Drawing.Size(175, 24);
            this.txt_Atual.TabIndex = 1;
            this.txt_Atual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Atual.UseSystemPasswordChar = true;
            this.txt_Atual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txt_Confirma
            // 
            this.txt_Confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirma.Location = new System.Drawing.Point(64, 256);
            this.txt_Confirma.MaxLength = 4;
            this.txt_Confirma.Name = "txt_Confirma";
            this.txt_Confirma.PasswordChar = '*';
            this.txt_Confirma.Size = new System.Drawing.Size(175, 24);
            this.txt_Confirma.TabIndex = 3;
            this.txt_Confirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Confirma.UseSystemPasswordChar = true;
            this.txt_Confirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // FrmTorcaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 380);
            this.Controls.Add(this.txt_Confirma);
            this.Controls.Add(this.txt_Atual);
            this.Controls.Add(this.txt_Nova);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TrocaSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTorcaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TrocaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.TextBox txt_Nova;
        private System.Windows.Forms.TextBox txt_Atual;
        private System.Windows.Forms.TextBox txt_Confirma;
    }
}