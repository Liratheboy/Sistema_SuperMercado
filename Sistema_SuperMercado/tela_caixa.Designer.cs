namespace Sistema_SuperMercado
{
    partial class tela_caixa
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
            label1 = new Label();
            txtInserirCodigoProduto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            lblValorUnitarioItem = new Label();
            lblValorTotaldoItem = new Label();
            label6 = new Label();
            txtInserirQuantidadeProduto = new TextBox();
            btnInserirProdutoGrid = new Button();
            label4 = new Label();
            lblValorSubtotalCompra = new Label();
            btnTelaRemoverItem = new Button();
            btnTelaPagamento = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 114);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 0;
            label1.Text = "Insira o Código do Produto:";
            label1.Click += label1_Click;
            // 
            // txtInserirCodigoProduto
            // 
            txtInserirCodigoProduto.Location = new Point(174, 111);
            txtInserirCodigoProduto.Name = "txtInserirCodigoProduto";
            txtInserirCodigoProduto.Size = new Size(153, 23);
            txtInserirCodigoProduto.TabIndex = 1;
            txtInserirCodigoProduto.TextChanged += txtInserirCodigoProduto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 246);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor Unitário (Em R$):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 291);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Total do item (Em R$):";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(348, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 179);
            panel1.TabIndex = 7;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(348, 38);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(652, 372);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblValorUnitarioItem
            // 
            lblValorUnitarioItem.AutoSize = true;
            lblValorUnitarioItem.Location = new Point(156, 246);
            lblValorUnitarioItem.Name = "lblValorUnitarioItem";
            lblValorUnitarioItem.Size = new Size(0, 15);
            lblValorUnitarioItem.TabIndex = 9;
            lblValorUnitarioItem.Click += label4_Click;
            // 
            // lblValorTotaldoItem
            // 
            lblValorTotaldoItem.AutoSize = true;
            lblValorTotaldoItem.Location = new Point(150, 291);
            lblValorTotaldoItem.Name = "lblValorTotaldoItem";
            lblValorTotaldoItem.Size = new Size(0, 15);
            lblValorTotaldoItem.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 153);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 11;
            label6.Text = "Insira a Quantidade:";
            label6.Click += label6_Click;
            // 
            // txtInserirQuantidadeProduto
            // 
            txtInserirQuantidadeProduto.Location = new Point(174, 150);
            txtInserirQuantidadeProduto.Name = "txtInserirQuantidadeProduto";
            txtInserirQuantidadeProduto.Size = new Size(100, 23);
            txtInserirQuantidadeProduto.TabIndex = 12;
            // 
            // btnInserirProdutoGrid
            // 
            btnInserirProdutoGrid.Location = new Point(88, 190);
            btnInserirProdutoGrid.Name = "btnInserirProdutoGrid";
            btnInserirProdutoGrid.Size = new Size(154, 24);
            btnInserirProdutoGrid.TabIndex = 13;
            btnInserirProdutoGrid.Text = "Inserir";
            btnInserirProdutoGrid.UseVisualStyleBackColor = true;
            btnInserirProdutoGrid.Click += btnInserirProdutoGrid_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(517, 470);
            label4.Name = "label4";
            label4.Size = new Size(221, 37);
            label4.TabIndex = 14;
            label4.Text = "Subtotal (Em R$):";
            // 
            // lblValorSubtotalCompra
            // 
            lblValorSubtotalCompra.AutoSize = true;
            lblValorSubtotalCompra.Font = new Font("Segoe UI", 20F);
            lblValorSubtotalCompra.Location = new Point(744, 470);
            lblValorSubtotalCompra.Name = "lblValorSubtotalCompra";
            lblValorSubtotalCompra.Size = new Size(0, 37);
            lblValorSubtotalCompra.TabIndex = 15;
            // 
            // btnTelaRemoverItem
            // 
            btnTelaRemoverItem.Location = new Point(88, 336);
            btnTelaRemoverItem.Name = "btnTelaRemoverItem";
            btnTelaRemoverItem.Size = new Size(138, 40);
            btnTelaRemoverItem.TabIndex = 16;
            btnTelaRemoverItem.Text = "Remover Item";
            btnTelaRemoverItem.UseVisualStyleBackColor = true;
            btnTelaRemoverItem.Click += button1_Click;
            // 
            // btnTelaPagamento
            // 
            btnTelaPagamento.Location = new Point(878, 467);
            btnTelaPagamento.Name = "btnTelaPagamento";
            btnTelaPagamento.Size = new Size(122, 40);
            btnTelaPagamento.TabIndex = 17;
            btnTelaPagamento.Text = "Pagamento";
            btnTelaPagamento.UseVisualStyleBackColor = true;
            btnTelaPagamento.Click += btnTelaPagamento_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 498);
            button3.Name = "button3";
            button3.Size = new Size(114, 35);
            button3.TabIndex = 18;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = true;
            // 
            // tela_caixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 545);
            Controls.Add(button3);
            Controls.Add(btnTelaPagamento);
            Controls.Add(btnTelaRemoverItem);
            Controls.Add(lblValorSubtotalCompra);
            Controls.Add(label4);
            Controls.Add(btnInserirProdutoGrid);
            Controls.Add(txtInserirQuantidadeProduto);
            Controls.Add(label6);
            Controls.Add(lblValorTotaldoItem);
            Controls.Add(lblValorUnitarioItem);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtInserirCodigoProduto);
            Controls.Add(label1);
            Name = "tela_caixa";
            Text = "tela_caixa";
            Load += tela_caixa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInserirCodigoProduto;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private DataGridView dataGridView;
        private Label lblValorUnitarioItem;
        private Label lblValorTotaldoItem;
        private Label label6;
        private TextBox txtInserirQuantidadeProduto;
        private Button btnInserirProdutoGrid;
        private Label label4;
        private Label lblValorSubtotalCompra;
        private Button btnTelaRemoverItem;
        private Button btnTelaPagamento;
        private Button button3;
    }
}