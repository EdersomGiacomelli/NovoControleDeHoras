
namespace NovoControleDeHorarios.br.com.projeto.view {
    partial class FrmMenu {
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menu_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_RelatorioAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ControleUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Manual = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Registro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_RelatorioUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Senha = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TrocaUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Registro = new System.Windows.Forms.Button();
            this.btn_Troca = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Admin,
            this.menu_Usuarios,
            this.menu_Config});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(265, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // menu_Admin
            // 
            this.menu_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_RelatorioAdmin,
            this.menu_ControleUser,
            this.menu_Manual});
            this.menu_Admin.Name = "menu_Admin";
            this.menu_Admin.Size = new System.Drawing.Size(55, 20);
            this.menu_Admin.Text = "Admin";
            // 
            // menu_RelatorioAdmin
            // 
            this.menu_RelatorioAdmin.Name = "menu_RelatorioAdmin";
            this.menu_RelatorioAdmin.Size = new System.Drawing.Size(184, 22);
            this.menu_RelatorioAdmin.Text = "Relatório";
            this.menu_RelatorioAdmin.Click += new System.EventHandler(this.menu_RelatorioAdmin_Click);
            // 
            // menu_ControleUser
            // 
            this.menu_ControleUser.Name = "menu_ControleUser";
            this.menu_ControleUser.Size = new System.Drawing.Size(184, 22);
            this.menu_ControleUser.Text = "Controle de Usuários";
            this.menu_ControleUser.Click += new System.EventHandler(this.alterarUsuáriosToolStripMenuItem_Click);
            // 
            // menu_Manual
            // 
            this.menu_Manual.Name = "menu_Manual";
            this.menu_Manual.Size = new System.Drawing.Size(184, 22);
            this.menu_Manual.Text = "Acerto Manual";
            this.menu_Manual.Click += new System.EventHandler(this.menu_Manual_Click);
            // 
            // menu_Usuarios
            // 
            this.menu_Usuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Registro,
            this.menu_RelatorioUser,
            this.menu_Senha});
            this.menu_Usuarios.Name = "menu_Usuarios";
            this.menu_Usuarios.Size = new System.Drawing.Size(64, 20);
            this.menu_Usuarios.Text = "Usuários";
            // 
            // menu_Registro
            // 
            this.menu_Registro.Name = "menu_Registro";
            this.menu_Registro.Size = new System.Drawing.Size(141, 22);
            this.menu_Registro.Text = "Registro";
            this.menu_Registro.Click += new System.EventHandler(this.menu_Registro_Click);
            // 
            // menu_RelatorioUser
            // 
            this.menu_RelatorioUser.Name = "menu_RelatorioUser";
            this.menu_RelatorioUser.Size = new System.Drawing.Size(141, 22);
            this.menu_RelatorioUser.Text = "Relatório";
            this.menu_RelatorioUser.Click += new System.EventHandler(this.menu_RelatorioUser_Click);
            // 
            // menu_Senha
            // 
            this.menu_Senha.Name = "menu_Senha";
            this.menu_Senha.Size = new System.Drawing.Size(141, 22);
            this.menu_Senha.Text = "Trocar Senha";
            this.menu_Senha.Click += new System.EventHandler(this.menu_Senha_Click);
            // 
            // menu_Config
            // 
            this.menu_Config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TrocaUser,
            this.menu_Fechar});
            this.menu_Config.Name = "menu_Config";
            this.menu_Config.Size = new System.Drawing.Size(55, 20);
            this.menu_Config.Text = "Config";
            // 
            // menu_TrocaUser
            // 
            this.menu_TrocaUser.Name = "menu_TrocaUser";
            this.menu_TrocaUser.Size = new System.Drawing.Size(190, 22);
            this.menu_TrocaUser.Text = "Trocar Usuário (Login)";
            this.menu_TrocaUser.Click += new System.EventHandler(this.menu_TrocaUser_Click);
            // 
            // menu_Fechar
            // 
            this.menu_Fechar.Name = "menu_Fechar";
            this.menu_Fechar.Size = new System.Drawing.Size(190, 22);
            this.menu_Fechar.Text = "Fechar";
            this.menu_Fechar.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btn_Registro
            // 
            this.btn_Registro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro.Location = new System.Drawing.Point(12, 38);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(241, 48);
            this.btn_Registro.TabIndex = 1;
            this.btn_Registro.Text = "REGISTRAR PONTO";
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
            // 
            // btn_Troca
            // 
            this.btn_Troca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Troca.Location = new System.Drawing.Point(12, 107);
            this.btn_Troca.Name = "btn_Troca";
            this.btn_Troca.Size = new System.Drawing.Size(241, 48);
            this.btn_Troca.TabIndex = 2;
            this.btn_Troca.Text = "TROCAR USUÁRIO";
            this.btn_Troca.UseVisualStyleBackColor = true;
            this.btn_Troca.Click += new System.EventHandler(this.btn_Troca_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 222);
            this.Controls.Add(this.btn_Troca);
            this.Controls.Add(this.btn_Registro);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menu_RelatorioAdmin;
        private System.Windows.Forms.ToolStripMenuItem menu_ControleUser;
        private System.Windows.Forms.ToolStripMenuItem menu_Manual;
        private System.Windows.Forms.ToolStripMenuItem menu_Registro;
        private System.Windows.Forms.ToolStripMenuItem menu_RelatorioUser;
        private System.Windows.Forms.ToolStripMenuItem menu_Senha;
        private System.Windows.Forms.ToolStripMenuItem menu_TrocaUser;
        private System.Windows.Forms.ToolStripMenuItem menu_Fechar;
        public System.Windows.Forms.ToolStripMenuItem menu_Admin;
        public System.Windows.Forms.ToolStripMenuItem menu_Usuarios;
        public System.Windows.Forms.ToolStripMenuItem menu_Config;
        public System.Windows.Forms.Button btn_Registro;
        public System.Windows.Forms.Button btn_Troca;
    }
}