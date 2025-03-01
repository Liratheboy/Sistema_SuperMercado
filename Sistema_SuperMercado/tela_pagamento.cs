using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_SuperMercado
{
    public partial class tela_pagamento : Form
    {
        double valorTotal;
        public tela_pagamento(double valorTotal)
        {   
            InitializeComponent();
            this.valorTotal = valorTotal;
        }

        private void btnPagDinheiro_Click(object sender, EventArgs e)
        {

        }

        private void tela_pagamento_Load(object sender, EventArgs e)
        {
            lblSubtotal.Text = valorTotal.ToString();
        }
    }
}
