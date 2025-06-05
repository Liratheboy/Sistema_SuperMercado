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
    public partial class tela_principal_funcionario_caixa : Form, Icriar_janela
    {

        Thread t1;

        public tela_principal_funcionario_caixa()
        {
            InitializeComponent();
        }

        public void abrirJanela(Form novaJanela)
        {
            Application.Run(novaJanela);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirJanela(new tela_caixa()));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tela_principal_funcionario_caixa_Load(object sender, EventArgs e)
        {

        }
    }
}
