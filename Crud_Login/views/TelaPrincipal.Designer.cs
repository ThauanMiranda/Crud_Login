namespace Crud_Login.views {
    partial class TelaPrincipal {
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
            this.btnDeletarConta = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeletarConta
            // 
            this.btnDeletarConta.BackColor = System.Drawing.Color.Crimson;
            this.btnDeletarConta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarConta.ForeColor = System.Drawing.Color.White;
            this.btnDeletarConta.Location = new System.Drawing.Point(558, 16);
            this.btnDeletarConta.Name = "btnDeletarConta";
            this.btnDeletarConta.Size = new System.Drawing.Size(114, 40);
            this.btnDeletarConta.TabIndex = 0;
            this.btnDeletarConta.Text = "Encerar Conta";
            this.btnDeletarConta.UseVisualStyleBackColor = false;
            this.btnDeletarConta.Click += new System.EventHandler(this.btnDeletarConta_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo.Location = new System.Drawing.Point(12, 21);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(155, 25);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Olá, Bem-vindo!";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(13, 11);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(13, 57);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 17);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(13, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(13, 77);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(234, 23);
            this.txtSenha.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(13, 123);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(234, 40);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Location = new System.Drawing.Point(12, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 189);
            this.panel1.TabIndex = 7;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(558, 62);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 37);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnDeletarConta);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeletarConta;
        private Label lblBemVindo;
        private Label lblEmail;
        private Label lblSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEditar;
        private Panel panel1;
        private Button btnSair;
    }
}