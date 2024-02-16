using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.Adapters;
using System.Web.UI.WebControls;

namespace compito_in_classe_week_3
{
    public partial class Articolo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Questo metodo viene eseguito quando la pagina viene caricata
            string id = Request.QueryString["idarticolo"];
            // Questa istruzione assegna alla variabile id il valore del parametro idarticolo passato nell'URL
            foreach (Articolo item in Articolo.ListaArticoli)
            {
                // Questo ciclo scorre tutti gli articoli nella lista statica definita nella classe Articolo
                if (item.IdArticolo == Convert.ToInt32(id))
                {
                    // Questa condizione verifica se l'id dell'articolo corrente corrisponde a quello passato nell'URL
                    ImmagineArticolo.ImageUrl = item.UrlImmagine;
                    // Questa istruzione assegna all'immagine della pagina l'URL dell'immagine dell'articolo corrente
                    titoloArticolo.InnerHtml = item.Nome;
                    // Questa istruzione assegna al titolo della pagina il nome dell'articolo corrente
                    descrizioneArticolo.InnerHtml = item.Descrizione;
                    // Questa istruzione assegna alla descrizione della pagina la descrizione dell'articolo corrente
                    prezzoArticolo.InnerHtml = $"{item.Prezzo.ToString("c2")}";
                    // Questa istruzione assegna al prezzo della pagina il prezzo dell'articolo corrente formattato in euro
                }
            }
        }

        protected void AggiungiAlCarrello(object sender, EventArgs e)
        {
            // Questo metodo viene eseguito quando si clicca sul bottone Aggiungi al carrello
            string id = Request.QueryString["idarticolo"];
            // Questa istruzione assegna alla variabile id il valore del parametro idarticolo passato nell'URL
            foreach (Articolo item in Articolo.ListaArticoli)
            {
                // Questo ciclo scorre tutti gli articoli nella lista statica definita nella classe Articolo
                if (item.IdArticolo == Convert.ToInt32(id))
                {
                    // Questa condizione verifica se l'id dell'articolo corrente corrisponde a quello passato nell'URL
                    Articolo.Carrello.Add(item);
                    // Questa istruzione aggiunge l'articolo corrente alla lista statica Carrello definita nella classe Articolo
                }
            }
        }
    }
}