using Newtonsoft.Json;
using Projato.Repositorio.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projato.Api.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categora
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public bool Cadastrar(string descricao, byte[] imagem)
        {
            var repositorio = new CategoriaRepositorio();
            return repositorio.Salvar(descricao, imagem);
        }

        [HttpGet]
        public string Pesquisar(string descricao)
        {
            var repositorioCategoria = new CategoriaRepositorio();

            var itemBuscado = repositorioCategoria.Pesquisar(descricao);

           return JsonConvert.SerializeObject(itemBuscado);
        }

    }
}