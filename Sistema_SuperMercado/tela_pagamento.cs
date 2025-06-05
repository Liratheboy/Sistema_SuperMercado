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
    public partial class tela_pagamento : Form, Icriar_janela
    {
        double valorTotal;
        Thread t1;
        public tela_pagamento(double valorTotal)
        {
            InitializeComponent();
            this.valorTotal = valorTotal;
        }

        public void abrirJanela(Form novaJanela)
        {
            Application.Run(novaJanela);
        }

        private void btnPagDinheiro_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirJanela(new tela_pagamento_dinheiro()));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void tela_pagamento_Load(object sender, EventArgs e)
        {
            lblSubtotal.Text = valorTotal.ToString();
        }

        private void btnPagCredito_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirJanela(new tela_pagamento_credito()));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnPagPix_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirJanela(new tela_pagamento_pix()));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnPagVoucher_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirJanela(new tela_pagamento_voucher()));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnPagDebito_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirJanela(new tela_pagamento_debito()));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnCancelarPagamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
