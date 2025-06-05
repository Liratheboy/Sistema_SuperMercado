using System.Collections.Generic;
using System.Collections;

namespace Sistema_SuperMercado
{
    public partial class tela_login : Form, Icriar_janela
    {

        Thread t1;
        public tela_login()
        {
            InitializeComponent();
        }

        private Dictionary<string, (string, string)> getFuncionarios()
        {
            Dictionary<string, (string senha, string cpf)> listaUsuarios = new Dictionary<string, (string, string)>();

            listaUsuarios.Add("Lucas", ("748392105", "30458271963"));
            listaUsuarios.Add("Fernanda", ("521087436", "72914560827"));
            listaUsuarios.Add("Rafael", ("936204871", "61827430519"));
            listaUsuarios.Add("Camila", ("102584739", "50793621485"));
            listaUsuarios.Add("Bruno", ("374920156", "82514730962"));
            listaUsuarios.Add("a", ("a", "82514730962"));

            return listaUsuarios;
        }

        private Boolean findFuncionario(string senha, string user)
        {
            Dictionary<string, (string senha, string cpf)> listaUsuarios = getFuncionarios();

            Boolean funcionario = false;

            if (listaUsuarios.TryGetValue(user, out var dados) && dados.senha == senha) { return true; }

            else { return false; }
        }

        public void abrirJanela(Form novaJanela)
        {
            Application.Run(novaJanela);
        }

        private void btnAcessarSistema_Click(object sender, EventArgs e)
        {
            string nome = txtUserLogin.Text;
            string senha = txtSenhaLogin.Text;

            Boolean funcionario = findFuncionario(senha, nome);

            if (funcionario == false)
            { MessageBox.Show("Erro! User ou Senha incorretos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                this.Close();
                t1 = new Thread(() => abrirJanela(new tela_principal_funcionario_caixa()));
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tela_login_Load(object sender, EventArgs e)
        {

        }
    }
}
