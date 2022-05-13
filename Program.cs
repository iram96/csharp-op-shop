

namespace csharp_op_shop // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Prodotto pr1 = new Prodotto("Tavolino", "60x80x60", 20, 22);

            Console.WriteLine("il tuo articolo: {0}, descrizione: {1}, prezzo: {2}€, prezzo +IVA: {3}€ ", pr1.sNomePr, pr1.sDescPr, pr1.fPrezzo, pr1.PrezzoIvato(pr1.fPrezzo, pr1.dIva));

        }
    }
}