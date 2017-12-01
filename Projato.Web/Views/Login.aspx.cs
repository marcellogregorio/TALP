using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projato.Web.Views
{
    public partial class Login : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            var loginItem = login.Text;
            var senhaItem = senha.Text;

            var urlBase = Commons.Commons.URL_BASE_REMOTO;

            urlBase = string.Format(urlBase + "/Login/Logar?nome={0}&senha={1}", loginItem, senhaItem);

            var retornoAPi = Commons.Commons.ConectarApi(urlBase);
            if (string.IsNullOrEmpty(retornoAPi))
            {
                // Login errado.
            }
            else
            {
                // Login Correto.
                Session["Cliente"] = retornoAPi;
                // Server.TransferRequest("Principal.aspx");

                Response.Redirect("Principal.aspx");

            }
        }
    }
}