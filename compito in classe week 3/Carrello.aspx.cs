using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace compito_in_classe_week_3
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Questo metodo viene eseguito quando la pagina viene caricata
            if (!IsPostBack)
            {
                // Questa condizione verifica se la pagina non è stata ricaricata da un evento postback
                if (Articolo.Carrello.Count != 0)
                {
                    // Questa condizione verifica se la lista statica Carrello definita nella classe Articolo non è vuota
                    ContenitoreGriglia.Visible = true;
                    // Questa istruzione rende visibile il div che contiene la griglia degli articoli nel carrello
                    MessaggioCarrelloVuoto.Visible = false;
                    // Questa istruzione rende invisibile la label che mostra il messaggio di carrello vuoto
                    double totale = 0;
                    // Questa istruzione dichiara e inizializza una variabile di tipo double per il totale degli acquisti
                    foreach (Articolo item in Articolo.Carrello)
                    {
                        // Questo ciclo scorre tutti gli articoli nella lista Carrello
                        totale += item.Prezzo;
                        // Questa istruzione somma il prezzo di ogni articolo al totale
                    }
                    SommaArticoli.Text = $"Totale acquisti: {totale.ToString("c2")}";
                    // Questa istruzione assegna alla label SommaArticoli il testo con il totale formattato in euro
                }
                else
                {
                    // Questa è la condizione alternativa, se la lista Carrello è vuota
                    ContenitoreGriglia.Visible = false;
                    // Questa istruzione rende invisibile il div che contiene la griglia degli articoli nel carrello
                    MessaggioCarrelloVuoto.Visible = true;
                    // Questa istruzione rende visibile la label che mostra il messaggio di carrello vuoto
                    MessaggioCarrelloVuoto.Text = "Il carrello è vuoto, inserisci un prodotto!";
                    // Questa istruzione assegna alla label MessaggioCarrelloVuoto il testo con il messaggio
                }
                GrigliaCarrello.DataSource = Articolo.Carrello;
                // Questa istruzione assegna alla griglia Carrello la sorgente dati dalla lista Carrello
                GrigliaCarrello.DataBind();
                // Questa istruzione lega i dati alla griglia Carrello
            }
        }

        protected void SvuotaCarrello(object sender, EventArgs e)
        {
            // Questo metodo viene eseguito quando si clicca sul bottone CancellaAcquisti
            Articolo.Carrello.Clear();
            // Questa istruzione svuota la lista Carrello
            ContenitoreGriglia.Visible = false;
            // Questa istruzione rende invisibile il div che contiene la griglia degli articoli nel carrello
            MessaggioCarrelloVuoto.Visible = true;
            // Questa istruzione rende visibile la label che mostra il messaggio di carrello vuoto
            MessaggioCarrelloVuoto.Text = "Il carrello è vuoto, inserisci un prodotto!";
            // Questa istruzione assegna alla label MessaggioCarrelloVuoto il testo con il messaggio
        }
    }
}