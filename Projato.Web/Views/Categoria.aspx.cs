using Newtonsoft.Json;
using Projato.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projato.Web.Views
{
    public partial class Produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            var descricao = txtDescricao.Text;

            var urlBase = Commons.Commons.URL_BASE_REMOTO;

            //   urlBase = Commons.Commons.URL_BASE_LOCAL;


            urlBase = string.Format(urlBase + "/Categoria/Cadastrar?descricao={0}&imagem={1}", descricao,"1232312313123131");

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);
            if (string.IsNullOrEmpty(retornoAPi))
            {

            }
            else
            {
                PopularGridView();
            }

        }

        private void PopularGridView()
        {
            var urlBase = Commons.Commons.URL_BASE_REMOTO;
            urlBase = string.Format(urlBase + "/Categoria/Pesquisar?descricao=");

            var retornoAPI = Commons.Commons.ConectarApi(urlBase);
            if (string.IsNullOrEmpty(retornoAPI)) return;
            
                var entidade = JsonConvert.DeserializeObject<List<Categoria>>(retornoAPI);

                gdvCategoria.DataSource = entidade;
                gdvCategoria.DataBind();
          
        }


            //if (!string.IsNullOrEmpty(retornoAPi))
            //{
            //    var entidade = JsonConvert.DeserializeObject<List<Dados.Categoria>>(retornoAPi);
            //    ddlCategoria.DataSource = entidade;
            //    ddlCategoria.DataBind();
            //}


}
}