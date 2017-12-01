using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projato.Web.Views
{
    public partial class Produto1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarCampos();
            }
        }

        private void CarregarCampos()
        {

            var urlBase = Commons.Commons.URL_BASE_REMOTO;

            //   urlBase = Commons.Commons.URL_BASE_LOCAL;


            urlBase = string.Format(urlBase + "/Categoria/Pesquisar?descricao={0}", " ");

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);
            if (!string.IsNullOrEmpty(retornoAPi))
            {
                var entidade = JsonConvert.DeserializeObject<List<Dados.Categoria>>(retornoAPi);
                ddlCategoria.DataSource = entidade;
                ddlCategoria.DataBind();
            }
        }

        private void CadastrarDados()
        {
            int idCategoria = int.Parse(ddlCategoria.SelectedValue);
            var descricao = txtProduto.Text;
            double preco = double.Parse(txtPreco.Text);

            var urlBase = Commons.Commons.URL_BASE_REMOTO;

            //   urlBase = Commons.Commons.URL_BASE_LOCAL;


            urlBase = string.Format(urlBase + "/Produto/CadastrarProduto?idCategoria={0}&nomeProduto={1}&valorProduto={2}", idCategoria, descricao, preco);

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);
        }

        private void PopularGrid()
        {
            var urlBase = Commons.Commons.URL_BASE_REMOTO;

            //   urlBase = Commons.Commons.URL_BASE_LOCAL;


            urlBase = string.Format(urlBase + "/Produto/PesquisarProduto?nome=");

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);
            var entidade = JsonConvert.DeserializeObject<List<Dados.Produto>>(retornoAPi);

            gdvProduto.DataSource = entidade;
            gdvProduto.DataBind();

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            CadastrarDados();
            CarregarCampos();
            PopularGrid();
        }
    }
}