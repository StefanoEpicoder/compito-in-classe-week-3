using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compito_in_classe_week_3
{
    public partial class Articolo
    {
        // Queste sono le proprietà della classe, che definiscono l'id, il nome, l'url dell'immagine, la descrizione e il prezzo di un articolo
        public int IdArticolo { get; set; }
        public string Nome { get; set; }
        public string UrlImmagine { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        // Questa è una lista statica di articoli, che contiene tutti gli articoli disponibili
        public static List<Articolo> ListaArticoli { get; set; } = new List<Articolo>();

        // Questa è una lista statica di articoli, che contiene gli articoli aggiunti al carrello
        public static List<Articolo> Carrello { get; set; } = new List<Articolo>();

        // Questo è un metodo statico che restituisce la lista degli articoli, dopo averli inizializzati con dei valori di esempio
        public static List<Articolo> GetLista()
        {
            // Queste sono le istanze degli articoli, create con il costruttore implicito e assegnando i valori alle proprietà
            Articolo articolo1 = new Articolo { IdArticolo = 1, Nome = "iPhone12", UrlImmagine = "~/Assets/iPhone12.jpg", Descrizione = "Dispone di un ottimo display da 6.1 pollici con una risoluzione di 1170 x 2532 con tecnologia OLED. Sul versante hardware, iPhone 12 dispone di un SOC Apple A14 Bionic e ha 4GB di ram. Per quanto riguarda la batteria, è una 2815 mAH che garantisce delle buone prestazioni in termini di autonomia.", Prezzo = 589.00 };
            Articolo articolo2 = new Articolo { IdArticolo = 2, Nome = "iPhone13", UrlImmagine = "~/Assets/iPhone13.png", Descrizione = "È possibile registrare video a 4K - 3840 x 2160 e abbiamo il led flash Doppio a due tonalità. Il dispositivo ha il supporto dual SIM e supporta le reti mobili sino a quelle 5G , mentre la Wi-Fi è di tipo a/b/g/n/ac/6 e il Bluetooth è 5.0. Non manca il GPS e neanche il chip NFC..", Prezzo = 629.99 };
            Articolo articolo3 = new Articolo { IdArticolo = 3, Nome = "iPhone14", UrlImmagine = "~/Assets/iPhone14.jpg", Descrizione = "Dispone di un display OLED da 6.1 pollici e una risoluzione di 1170 x 2532 pixel. Come il suo predecessore è dotato di un chip A15 Bionic con un processore a 6 core e una CPU a 5 core, per garantire prestazioni elevate e un'elevata efficienza anche per le attività più impegnative.", Prezzo = 749.99 };
            Articolo articolo4 = new Articolo { IdArticolo = 4, Nome = "iPhone15", UrlImmagine = "~/Assets/iPhone15.jpg", Descrizione = "L'eccellenza di questo Apple iPhone 15 è completata da una fotocamera con un sensore da ben 48 megapixel che permette di scattare foto di alta qualità con una risoluzione di 8000x6000 pixel e di registrare video in 4K alla risoluzione di 3840x2160 pixel. Lo spessore di 7.8mm è veramente contenuto e rende questo Apple iPhone 15 ancora più spettacolare.", Prezzo = 829.99 };
            Articolo articolo5 = new Articolo { IdArticolo = 5, Nome = "Macbook", UrlImmagine = "~/Assets/Macbook.png", Descrizione = "Ti presentiamo il nuovo MacBook Air: il nostro portatile più sottile e leggero, completamente trasformato dal chip Apple M1. CPU fino a 3,5 volte più veloce. GPU fino a 5 volte più scattante. Il Neural Engine più evoluto di sempre, che assicura performance di machine learning fino a 9 volte migliori.", Prezzo = 1149.00 };
            Articolo articolo6 = new Articolo { IdArticolo = 6, Nome = "iMac", UrlImmagine = "~/Assets/iMac.jpg", Descrizione = "È il Mac con architettura Vega e ha fino a 16 GB di memoria a elevata ampiezza di banda,per prestazioni ancora migliori. Così avrai frame rate più elevati per la realtà virtuale,rendering 3D in tempo reale,effetti speciali più realistici e un gameplay fluido perfino con le impostazioni di gioco più spinte.", Prezzo = 4359.99 };
            // Queste sono le istruzioni per aggiungere gli articoli alla lista
            ListaArticoli.Add(articolo1);
            ListaArticoli.Add(articolo2);
            ListaArticoli.Add(articolo3);
            ListaArticoli.Add(articolo4);
            ListaArticoli.Add(articolo5);
            ListaArticoli.Add(articolo6);
            // Questa è l'istruzione per restituire la lista
            return ListaArticoli;
        }
    }
}