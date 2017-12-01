using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projato.Web.ViewModel
{
    public class VendaVMWeb
    {
        public string DescricaoProduto { get; set; }
        public string NomeCliente { get; set; }
        public string Preco { get; set; }
        public int Qtde { get; set; }
        public DateTime Data { get; set; }
    }
}