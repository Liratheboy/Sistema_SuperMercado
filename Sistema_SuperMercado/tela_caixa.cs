using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_SuperMercado
{
    public partial class tela_caixa : Form, Icriar_janela
    {
        private DataTable dt = new DataTable();
        double valorTotal = 0;
        Thread t2;
        public tela_caixa()
        {
            InitializeComponent();
        }

        public void abrirJanela(object obj)
        {
            Application.Run(new tela_principal_funcionario_caixa());
        }

        private List<Produto> getListaTodosProdutos()
        {
            List<Produto> listaProduto = new List<Produto>();

            listaProduto.Add(new Produto("Coca", "921839283", 7));
            listaProduto.Add(new Produto("Pepsi", "711365278", 6));
            listaProduto.Add(new Produto("Leite", "375417485", 4));
            listaProduto.Add(new Produto("Mortadela", "540172947", 10));
            listaProduto.Add(new Produto("Arroz", "482193745", 12));
            listaProduto.Add(new Produto("Feijao", "937284610", 5));
            listaProduto.Add(new Produto("Macarrao", "561029384", 18));
            listaProduto.Add(new Produto("Acucar", "710293845", 7));
            listaProduto.Add(new Produto("Sal", "384756102", 3));
            listaProduto.Add(new Produto("Cafe", "928374510", 15));
            listaProduto.Add(new Produto("Leite", "675201948", 9));
            listaProduto.Add(new Produto("Oleo", "183746592", 20));
            listaProduto.Add(new Produto("Farinha", "294857103", 4));
            listaProduto.Add(new Produto("Carne", "839271405", 11));
            listaProduto.Add(new Produto("Frango", "120948375", 6));
            listaProduto.Add(new Produto("Queijo", "657120938", 14));
            listaProduto.Add(new Produto("Presunto", "984375210", 2));
            listaProduto.Add(new Produto("Ovo", "473829105", 8));
            listaProduto.Add(new Produto("Manteiga", "102938475", 19));
            listaProduto.Add(new Produto("Sabao", "827364910", 10));
            listaProduto.Add(new Produto("Detergente", "394857201", 5));
            listaProduto.Add(new Produto("Creme", "210394857", 13));
            listaProduto.Add(new Produto("Shampoo", "983210475", 1));
            listaProduto.Add(new Produto("Papel", "746382910", 17));

            return listaProduto;
        }

        private Produto getProduto(string codigoProduto)
        {
            List<Produto> listaProdutos = getListaTodosProdutos();
            int i = 0;

            while (listaProdutos[i].codigo != codigoProduto) { i++; }

            Produto produto = listaProdutos[i];

            return produto;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tela_caixa_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Produto");
            dt.Columns.Add("Valor Unidade");
            dt.Columns.Add("Quantidade");
            dt.Columns.Add("Valor Total");

            dataGridView.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirProdutoGrid_Click(object sender, EventArgs e)
        {
            List<Produto> listaProdutosGrid = new List<Produto>();

            string codigo = txtInserirCodigoProduto.Text;
            string quantidadeTxt = txtInserirQuantidadeProduto.Text;
            double quantidade = double.Parse(quantidadeTxt);

            Produto produto = getProduto(codigo);

            double valor = produto.valorUnitario * quantidade;

            valorTotal += valor;

            listaProdutosGrid.Add(produto);

            dt.Rows.Add(produto.descricao, produto.valorUnitario, quantidade, (produto.valorUnitario) * quantidade);

            lblValorUnitarioItem.Text = produto.valorUnitario.ToString();
            lblValorTotaldoItem.Text = (produto.valorUnitario * quantidade).ToString();

            lblValorSubtotalCompra.Text = valorTotal.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtInserirCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTelaPagamento_Click(object sender, EventArgs e)
        {
            double valor = valorTotal;
            tela_pagamento tl1 = new tela_pagamento(valor);
            tl1.Show();
        }

        private void btnVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirJanela);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
    }
}
