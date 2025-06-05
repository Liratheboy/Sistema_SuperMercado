namespace Sistema_SuperMercado
{
    partial class tela_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            txtUserLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            label2 = new Label();
            btnAcessarSistema = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(357, 94);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(76, 30);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            lblLogin.Click += label1_Click;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(357, 191);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(136, 23);
            txtUserLogin.TabIndex = 2;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(357, 232);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(136, 23);
            txtSenhaLogin.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 235);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            // 
            // btnAcessarSistema
            // 
            btnAcessarSistema.Location = new Point(298, 285);
            btnAcessarSistema.Name = "btnAcessarSistema";
            btnAcessarSistema.Size = new Size(195, 47);
            btnAcessarSistema.TabIndex = 6;
            btnAcessarSistema.Text = "Acessar";
            btnAcessarSistema.UseVisualStyleBackColor = true;
            btnAcessarSistema.Click += btnAcessarSistema_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 194);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 7;
            label1.Text = "User:";
            // 
            // tela_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAcessarSistema);
            Controls.Add(label2);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUserLogin);
            Controls.Add(lblLogin);
            Name = "tela_login";
            Text = "Form1";
            Load += tela_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogin;
        private TextBox txtUserLogin;
        private TextBox txtSenhaLogin;
        private Label label2;
        private Button btnAcessarSistema;
        private Label label1;
    }
}
