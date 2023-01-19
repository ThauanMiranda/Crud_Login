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
            this.SuspendLayout();
            // 
            // btnDeletarConta
            // 
            this.btnDeletarConta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarConta.Location = new System.Drawing.Point(572, 16);
            this.btnDeletarConta.Name = "btnDeletarConta";
            this.btnDeletarConta.Size = new System.Drawing.Size(100, 40);
            this.btnDeletarConta.TabIndex = 0;
            this.btnDeletarConta.Text = "Encerar Conta";
            this.btnDeletarConta.UseVisualStyleBackColor = true;
            this.btnDeletarConta.Click += new System.EventHandler(this.btnDeletarConta_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBemVindo.Location = new System.Drawing.Point(12, 21);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(221, 25);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Olá, Bem-vindo usuário";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnDeletarConta);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeletarConta;
        private Label lblBemVindo;
    }
}