using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projato.Repositorio.ViewModel
{
    public class VendaVM
    {
        public string DescricaoProduto { get; set; }
        public string NomeCliente { get; set; }
        public double Preco { get; set; }
        public int Qtde { get; set; }
        public DateTime Data { get; set; }
    }
}
