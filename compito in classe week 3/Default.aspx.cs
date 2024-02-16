using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compito_in_classe_week_3
{
    public partial class Default : System.Web.UI.Page
    {
        // Definisco un metodo protetto Page_Load che viene eseguito quando la pagina viene caricata
        protected void Page_Load(object sender, EventArgs e)
        {
            // Controllo se la richiesta è una richiesta iniziale o una richiesta di postback
            if (!IsPostBack)
            {
                // Se è una richiesta iniziale, svuoto la lista degli articoli
                Articolo.GetLista().Clear();
                // Richiamo il metodo GetLista della classe Articolo per ottenere la lista degli articoli
                Articolo.GetLista();
                // Imposto la proprietà DataSource del controllo RepeaterArticoli con la lista degli articoli
                RepeaterArticoli.DataSource = Articolo.ListaArticoli;
                // Richiamo il metodo DataBind del controllo RepeaterArticoli per associare i dati
                RepeaterArticoli.DataBind();
            }
        }
    }
}