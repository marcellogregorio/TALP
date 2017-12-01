using Projato.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Projato.Repositorio.Login
{
    public class LoginRepositorio : IDisposable
    {


        /// <summary>
        /// Método para efetuar o login.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public string Logar(string nome, string senha)
        {
            using (var context = new Model1())
            {
                var usuario = context.Login.FirstOrDefault(x => x.EmailLogin.ToUpper().Equals(nome.ToUpper()) && x.SenhaLogin.ToUpper().Equals(senha.ToUpper()));
                if (usuario == null) return "";

                return usuario.IdLogin.ToString();
            }



        }

        public void Dispose()
        {

        }
    }
}
