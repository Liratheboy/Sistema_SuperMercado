namespace Sistema_SuperMercado
{
    partial class tela_pagamento
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
            btnCancelarPagamento = new Button();
            label1 = new Label();
            btnPagCredito = new Button();
            label2 = new Label();
            lblSubtotal = new Label();
            btnPagDebito = new Button();
            btnPagVoucher = new Button();
            btnPagPix = new Button();
            btnPagDinheiro = new Button();
            SuspendLayout();
            // 
            // btnCancelarPagamento
            // 
            btnCancelarPagamento.Location = new Point(12, 368);
            btnCancelarPagamento.Name = "btnCancelarPagamento";
            btnCancelarPagamento.Size = new Size(125, 36);
            btnCancelarPagamento.TabIndex = 0;
            btnCancelarPagamento.Text = "Cancelar";
            btnCancelarPagamento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(112, 88);
            label1.Name = "label1";
            label1.Size = new Size(345, 30);
            label1.TabIndex = 1;
            label1.Text = "Escolha o método de pagamento: ";
            // 
            // btnPagCredito
            // 
            btnPagCredito.Location = new Point(282, 132);
            btnPagCredito.Name = "btnPagCredito";
            btnPagCredito.Size = new Size(175, 33);
            btnPagCredito.TabIndex = 2;
            btnPagCredito.Text = "Crédito";
            btnPagCredito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(205, 301);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 3;
            label2.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 16F);
            lblSubtotal.Location = new Point(293, 301);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 30);
            lblSubtotal.TabIndex = 4;
            // 
            // btnPagDebito
            // 
            btnPagDebito.Location = new Point(101, 132);
            btnPagDebito.Name = "btnPagDebito";
            btnPagDebito.Size = new Size(175, 33);
            btnPagDebito.TabIndex = 5;
            btnPagDebito.Text = "Debito";
            btnPagDebito.UseVisualStyleBackColor = true;
            // 
            // btnPagVoucher
            // 
            btnPagVoucher.Location = new Point(101, 180);
            btnPagVoucher.Name = "btnPagVoucher";
            btnPagVoucher.Size = new Size(175, 33);
            btnPagVoucher.TabIndex = 6;
            btnPagVoucher.Text = "Voucher";
            btnPagVoucher.UseVisualStyleBackColor = true;
            // 
            // btnPagPix
            // 
            btnPagPix.Location = new Point(282, 180);
            btnPagPix.Name = "btnPagPix";
            btnPagPix.Size = new Size(175, 33);
            btnPagPix.TabIndex = 7;
            btnPagPix.Text = "Pix";
            btnPagPix.UseVisualStyleBackColor = true;
            // 
            // btnPagDinheiro
            // 
            btnPagDinheiro.Location = new Point(187, 229);
            btnPagDinheiro.Name = "btnPagDinheiro";
            btnPagDinheiro.Size = new Size(175, 33);
            btnPagDinheiro.TabIndex = 8;
            btnPagDinheiro.Text = "Dinheiro";
            btnPagDinheiro.UseVisualStyleBackColor = true;
            btnPagDinheiro.Click += btnPagDinheiro_Click;
            // 
            // tela_pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 412);
            Controls.Add(btnPagDinheiro);
            Controls.Add(btnPagPix);
            Controls.Add(btnPagVoucher);
            Controls.Add(btnPagDebito);
            Controls.Add(lblSubtotal);
            Controls.Add(label2);
            Controls.Add(btnPagCredito);
            Controls.Add(label1);
            Controls.Add(btnCancelarPagamento);
            Name = "tela_pagamento";
            Text = "tela_pagamento";
            Load += tela_pagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarPagamento;
        private Label label1;
        private Button btnPagCredito;
        private Label label2;
        private Label lblSubtotal;
        private Button btnPagDebito;
        private Button btnPagVoucher;
        private Button btnPagPix;
        private Button btnPagDinheiro;
    }
}