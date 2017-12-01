using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Projato.Web.Commons
{
    /// <summary>
    /// Classe de configuração de endpoint(Endereco) de apis.
    /// 
    /// </summary>
    public static class Commons
    {
        public const string URL_BASE_REMOTO = "http://projetoapii.azurewebsites.net/";
        //public const string URL_BASE_LOCAL = "http://localhost:52383";

        public static string ConectarApi(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }


                }
            }
            catch (Exception e)
            {

                return "";
            }


            return url;

        }
    }
}