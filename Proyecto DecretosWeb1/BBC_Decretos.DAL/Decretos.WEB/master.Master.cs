using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Decretos.WEB
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {

            btnInicio.BackColor = System.Drawing.Color.Orange;
            String col = ("#297fb8");
            btnUsuario.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecExentos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecAlcaldicios.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecPagos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecCompras.BackColor = System.Drawing.ColorTranslator.FromHtml(col);

        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {

            String col = ("#297fb8");
            btnInicio.BackColor=System.Drawing.ColorTranslator.FromHtml(col);
            btnDecExentos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecAlcaldicios.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecPagos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecCompras.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnUsuario.BackColor = System.Drawing.Color.Orange;

            Response.Redirect("Usuario.aspx");
                
        }

        protected void btnDecPagos_Click(object sender, EventArgs e)
        {
            String col = ("#297fb8");
            btnInicio.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnUsuario.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecExentos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecAlcaldicios.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecCompras.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecPagos.BackColor = System.Drawing.Color.Orange;
        }

        protected void btnDecAlcaldicios_Click(object sender, EventArgs e)
        {
            String col = ("#297fb8");
            btnInicio.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnUsuario.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecExentos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecCompras.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecPagos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecAlcaldicios.BackColor = System.Drawing.Color.Orange;
        }

        protected void btnDecExentos_Click(object sender, EventArgs e)
        {
            String col = ("#297fb8");
            btnInicio.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnUsuario.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecAlcaldicios.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecCompras.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecPagos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecExentos.BackColor = System.Drawing.Color.Orange;
        }

        protected void btnDecCompras_Click(object sender, EventArgs e)
        {
            String col = ("#297fb8");
            btnInicio.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnUsuario.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecExentos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecAlcaldicios.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecPagos.BackColor = System.Drawing.ColorTranslator.FromHtml(col);
            btnDecCompras.BackColor = System.Drawing.Color.Orange;
        }



    }
}