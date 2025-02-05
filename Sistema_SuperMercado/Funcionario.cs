using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_SuperMercado
{
    public class Funcionario
    {

        public string nomeFuncionario { get; set; }
        public string senhaFuncionario { get; set; }
        public string cpfFuncionario { get; set; }

        public Funcionario(){}

        public Funcionario(string nomeFuncionario, string senhaFuncionario, string cpfFuncionario) 
        {
            this.cpfFuncionario = cpfFuncionario;
            this.senhaFuncionario = senhaFuncionario;
            this.nomeFuncionario = nomeFuncionario;
        }

    }
}
