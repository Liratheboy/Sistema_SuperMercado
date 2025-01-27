namespace Sistema_SuperMercado
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new tela_login());

        }
    }
}