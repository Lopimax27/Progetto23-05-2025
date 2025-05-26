using System;

public class Dipendente
{
    private string _nome;
    private int _eta;

    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            _nome = value;
        }
    }
    public int Eta
    {
        get
        {
            return _eta;
        }
        set
        {
            if (value >= 18)
            {
                _eta = value;
            }
        }
    }

    public virtual void EseguiCompito()
    {
        Console.WriteLine("Compito generico del dipendente.");
    }

    public Dipendente(string nome, int eta)
    {
        _nome = nome;
        _eta = eta;
    }

}

public class Program
{
    public static void Main()
    {
        List<Dipendente> insiemeDipendenti = new List<Dipendente>();
        bool x = true;

        do
        {
            Console.WriteLine("1.Aggiungi un dipendente\n2.Visualizza i dipendenti\n3.Esegui tutti i compiti\n0.Esci");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    insiemeDipendenti.Add(InputDipendenti());
                    break;
                case 2:
                    Visualizza();
                    break;
                case 3:
                    EseguiCompito();
                    break;
                case 0:
                    x = false;
                    break;
            }
        } while (x);
    }

    public static Dipendente InputDipententi()
    {
        Console.WriteLine("Inserisci se il dipendente è un autista o un meccanico o un operatore centrale (1,2,3)");
        int sceltaDip=int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisci il nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Inserisci l'età: ");
        int eta = int.Parse(Console.ReadLine());

        //TODO Inserire sistema di controllo che prende in input gli altri valori e con uno switch ritorna il dipendente da aggiungere

    }

}
