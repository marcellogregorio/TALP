using Newtonsoft.Json;
using Projato.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projato.Web.Views
{
    public partial class Venda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarCampos();
        }

        private void CarregarCampos()
        {
            var urlBase = Commons.Commons.URL_BASE_REMOTO;

            //   urlBase = Commons.Commons.URL_BASE_LOCAL;


            urlBase = string.Format(urlBase + "/Produto/PesquisarProduto?descricao={0}", " ");

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);

            if (!string.IsNullOrEmpty(retornoAPi))
            {
                var entidade = JsonConvert.DeserializeObject<List<Dados.Produto>>(retornoAPi);
                ddlProduto.DataSource = entidade;
                ddlProduto.DataBind();

                ddlProduto.Items.Insert(0, "Selecione um produto");
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            lblPreco.Text = string.Empty;
            txtQtde.Text = string.Empty;
            lblQtdeInvalida.Visible = false;
        }

        protected void ddlProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nomeProduto = ddlProduto.SelectedItem.Text;

            var urlBase = Commons.Commons.URL_BASE_REMOTO;
          
            urlBase = string.Format(urlBase + "/Produto/PesquisarProduto?descricao={0}", nomeProduto);

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);

            if (!string.IsNullOrEmpty(retornoAPi))
            {
                var entidade = JsonConvert.DeserializeObject<List<Dados.Produto>>(retornoAPi);

                lblPreco.Text = entidade.First().ValorProduto.ToString();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            CadastrarDados();
       
        }

        private void CadastrarDados()
        {
            int idCliente = int.Parse(Session["Cliente"].ToString());
            int idProduto = int.Parse(ddlProduto.SelectedValue);
            var qtde = int.Parse(txtQtde.Text);

            var urlBase = Commons.Commons.URL_BASE_REMOTO;

            urlBase = string.Format(urlBase + "/Venda/Cadastrar?idProduto={0}&idCliente={1}&qtde={2}", idProduto, idCliente, qtde);

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);

            if (!string.IsNullOrEmpty(retornoAPi))
            {
                var entidade = JsonConvert.DeserializeObject<bool>(retornoAPi);
                if (entidade)
                    LimparCampos();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            var idProduto = "";
            if (ddlProduto.SelectedIndex != 0)
            {
                idProduto = ddlProduto.SelectedValue;
            }

            var urlBase = Commons.Commons.URL_BASE_REMOTO;


            urlBase = string.Format(urlBase + "/Venda/Buscar?idProduto={0}&idCliente={1}", idProduto, 7);

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);

            if (!string.IsNullOrEmpty(retornoAPi))
            {
                var entidade = JsonConvert.DeserializeObject<List<VendaVMWeb>>(retornoAPi);
                if (!entidade.Any()) return;


                gdvVenda.DataSource = entidade;
                gdvVenda.DataBind();
            }
        }

        protected void gdvVenda_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           if (e.CommandName.Equals("EDITAR"))
            {
                var posicao = gdvVenda.SelectedIndex;
                var campos =  gdvVenda.Rows[posicao].DataItem;

              //  CarregarCamposEdicao(id);
            }
        }

        public void CarregarCamposEdicao()
        {

        }

        protected void gdvVenda_RowEditing(object sender, GridViewEditEventArgs e)
        {

            var posicao = gdvVenda.Rows[e.NewEditIndex];

            Label lbldeleteid = (Label)posicao.FindControl("lblID");

        }
    }
}