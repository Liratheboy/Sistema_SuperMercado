namespace Sistema_SuperMercado
{
    public partial class tela_login : Form, Icriar_janela
    {

        Thread t1;
        public tela_login()
        {
            InitializeComponent();
        }

        private List<Funcionario> getFuncionarios()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            listaFuncionarios.Add(new Funcionario("lucas", "748392105", "30458271963"));
            listaFuncionarios.Add(new Funcionario("fernanda", "521087436", "72914560827"));
            listaFuncionarios.Add(new Funcionario("rafael", "936204871", "61827430519"));
            listaFuncionarios.Add(new Funcionario("camila", "102584739", "50793621485"));
            listaFuncionarios.Add(new Funcionario("bruno", "374920156", "82514730962"));

            return listaFuncionarios;
        }

        private Funcionario findFuncionario(string senha, string user)
        {
            List<Funcionario> lista = getFuncionarios();

            int i = 0;

            Funcionario funcionario = null;

            while (lista[i].senhaFuncionario != senha && lista[i].nomeFuncionario != user) { i++; }

            funcionario = lista[i];

            return funcionario;

        }

        public void abrirJanela(object obj)
        {
            Application.Run(new tela_principal_funcionario_caixa());
        }

        private void btnAcessarSistema_Click(object sender, EventArgs e)
        {
            string nome = txtUserLogin.Text;
            string senha = txtSenhaLogin.Text;

            Funcionario funcionario = findFuncionario(senha, nome);

            if (funcionario == null) MessageBox.Show("Erro! User ou Senha incorretos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            { 
                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
