/* l'esercizio di oggi
Esercizio di oggi: C# Shop nome repo: csharp-oop-shop 
Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce 
i prodotti dello shop. Un prodotto è caratterizzato da: - codice (numero intero)
- nome - descrizione - prezzo - iva
Usate opportunamente i livelli di accesso (public, private), i costruttori,
i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
-alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random 
-Il codice prodotto sia accessibile solo in lettura
-Gli altri attributi siano accessibili sia in lettura che in scrittura
-Il prodotto esponga sia un metodo per avere il prezzo base che uno
per avere il prezzo comprensivo di iva
-Il prodotto esponga un metodo per avere il nome esteso, ottenuto
concatenando codice + nome Nella vostro programma principale,
testate tutte le funzionalità della classe Prodotto.

BONUS: create un metodo che restituisca il codice con un pad left di 0
per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091,
mentre codice 123445567 resta come è) */


namespace csharp_op_shop
{
    internal class Prodotto
    {
        private int iCodicePr;
        private string sNome;
        public string sNomePr
        {
            get { return sNome; }
            set { sNome = value; }

        }
        public string sDescPr;
        public float fPrezzo { get; set; }

        private double iva;
        public double dIva
        {
            get { return iva; }
            set
            {
                if (value != 22) Console.WriteLine("l'iva inserita non è corretta");
                iva = 0.1 * value;
            }
        }

        private Random myRand;

        // private Random myRand = new Random(); 
        // se faccio così NON devo dischiare nel costruttore con un x = new Random

        public double PrezzoIvato(float fPrezzo, double dIva)
        {
            return fPrezzo * (1 + dIva);
        }
        public Prodotto(string nome, string desc, float prezzo, double iva)
        {
            myRand = new Random();
            this.sNome = nome;
            this.sDescPr = desc;
            this.fPrezzo = prezzo;
            this.dIva = iva;
            this.iCodicePr = myRand.Next();
            //Console.WriteLine(iCodicePr);

        }
    }
}
