namespace Sistema_SuperMercado
{
    public partial class tela_login : Form, Icriar_janela
    {

        Thread t1;
        public tela_login()
        {
            InitializeComponent();
        }

        public void abrirJanela(object obj)
        {
            Application.Run(new tela_principal_funcionario_caixa());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
