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
    public partial class tela_caixa : Form
    {
        private DataTable dt = new DataTable();

        public tela_caixa()
        {
            InitializeComponent();
        }

        private List<Produto> getListaTodosProdutos()
        {
            List<Produto> listaProduto = new List<Produto>();

            listaProduto.Add(new Produto("Coca", "921839283", 7));
            listaProduto.Add(new Produto("Pepsi", "739571837", 6));
            listaProduto.Add(new Produto("Leite", "375417485", 4));
            listaProduto.Add(new Produto("seila", "540172947", 10));

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

            listaProdutosGrid.Add(produto);

            dt.Rows.Add(produto.descricao, produto.valorUnitario, quantidade, (produto.valorUnitario) * quantidade);

        }
    }
}
