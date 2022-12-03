using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexao_com_banco
{
    internal class Alimenticio : Produtos
    {
        public int Medida { get; set; }
        public string Tipo { get; set; }
    }
}
