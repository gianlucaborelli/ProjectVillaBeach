namespace ProjetoVillaBeach
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.bntConfiguracao = new System.Windows.Forms.Button();
            this.SubMenuCadastro = new System.Windows.Forms.Panel();
            this.btnCadastroDePessoas = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlMenuLateral.SuspendLayout();
            this.SubMenuCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1144, 84);
            this.pnlTitulo.TabIndex = 0;
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(93)))), ((int)(((byte)(124)))));
            this.pnlMenuLateral.Controls.Add(this.bntConfiguracao);
            this.pnlMenuLateral.Controls.Add(this.SubMenuCadastro);
            this.pnlMenuLateral.Controls.Add(this.btnCadastro);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 84);
            this.pnlMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(260, 661);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // bntConfiguracao
            // 
            this.bntConfiguracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntConfiguracao.FlatAppearance.BorderSize = 0;
            this.bntConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConfiguracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.bntConfiguracao.Location = new System.Drawing.Point(0, 181);
            this.bntConfiguracao.Margin = new System.Windows.Forms.Padding(4);
            this.bntConfiguracao.Name = "bntConfiguracao";
            this.bntConfiguracao.Size = new System.Drawing.Size(260, 53);
            this.bntConfiguracao.TabIndex = 2;
            this.bntConfiguracao.Text = "Configurações";
            this.bntConfiguracao.UseVisualStyleBackColor = true;
            this.bntConfiguracao.Click += new System.EventHandler(this.BtnConfiguracao_Click);
            // 
            // SubMenuCadastro
            // 
            this.SubMenuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.SubMenuCadastro.Controls.Add(this.btnCadastroDePessoas);
            this.SubMenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuCadastro.Location = new System.Drawing.Point(0, 53);
            this.SubMenuCadastro.Name = "SubMenuCadastro";
            this.SubMenuCadastro.Size = new System.Drawing.Size(260, 128);
            this.SubMenuCadastro.TabIndex = 1;
            // 
            // btnCadastroDePessoas
            // 
            this.btnCadastroDePessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnCadastroDePessoas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroDePessoas.FlatAppearance.BorderSize = 0;
            this.btnCadastroDePessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroDePessoas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnCadastroDePessoas.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroDePessoas.Name = "btnCadastroDePessoas";
            this.btnCadastroDePessoas.Size = new System.Drawing.Size(260, 52);
            this.btnCadastroDePessoas.TabIndex = 0;
            this.btnCadastroDePessoas.Text = "Pessoas";
            this.btnCadastroDePessoas.UseVisualStyleBackColor = false;
            this.btnCadastroDePessoas.Click += new System.EventHandler(this.btnCadastroDePessoas_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(260, 53);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(260, 84);
            this.pnlConteudo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(884, 661);
            this.pnlConteudo.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1144, 745);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Sistema Villa Beach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenuLateral.ResumeLayout(false);
            this.SubMenuCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlMenuLateral;
        public System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel SubMenuCadastro;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCadastroDePessoas;
        private System.Windows.Forms.Button bntConfiguracao;
    }
}