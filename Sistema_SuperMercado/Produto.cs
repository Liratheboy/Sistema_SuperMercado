using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_SuperMercado
{
    public class Produto
    {

        public string descricao { get; set; }
        public string codigo { get; set; }
        public double valorUnitario { get; set; }

        public Produto(){}

        public Produto(string descricao, string codigo, double valorUnitario)
        {
            this.descricao = descricao;
            this.codigo = codigo;
            this.valorUnitario = valorUnitario;
        }
    }
}
