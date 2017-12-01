using Newtonsoft.Json;
using Projato.Dados;
using Projato.Repositorio.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projato.Api.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public bool CadastrarProduto(int idCategoria, string nomeProduto, double ValorProduto)
        {
            var repositorio = new ProdutoRepositorio();
            return repositorio.CadastarProduto(idCategoria, nomeProduto, ValorProduto);
        }

        [HttpGet]
        public string PesquisarProduto(string nome)
        {
            var repositorio = new ProdutoRepositorio();
          return JsonConvert.SerializeObject(repositorio.BuscarProduto(nome));
        }
    }
}