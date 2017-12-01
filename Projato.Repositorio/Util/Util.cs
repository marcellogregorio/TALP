using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projato.Repositorio.Util
{
    public static class Util
    {
        /// <summary>
        /// Método para geracao do token
        /// </summary>
        /// <returns></returns>
        public static string GerarToken()
        {
            var data = DateTime.Now.ToString("dd/MM/yyyy");
            return data;
        }
    }
}
