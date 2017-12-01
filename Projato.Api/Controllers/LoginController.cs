using Projato.Repositorio.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projato.Api.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string Logar(string nome, string senha)
        {
            var repositorio = new LoginRepositorio();

            return repositorio.Logar(nome, senha);
        }


    }
}