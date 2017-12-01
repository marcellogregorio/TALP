using Newtonsoft.Json;
using Projato.Repositorio.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projato.Api.Controllers
{
    public class VendaController : Controller
    {
        // GET: Venda
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string Cadastrar(int idProduto, int idCliente, int qtde)
        {
            var repositorio = new VendaRepositorio();

            var resultado = repositorio.CadastrarVenda(idProduto, idCliente, qtde);
          return  JsonConvert.SerializeObject(resultado);
        }

        [HttpGet]
        public string Buscar(int? idProduto, int? idCliente)
        {
            var repositorio = new VendaRepositorio();
            var resultado = repositorio.BuscarVenda(idProduto, idCliente);
            return JsonConvert.SerializeObject(resultado);
        }
    }
}