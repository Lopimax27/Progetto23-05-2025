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
        return new Dipendente();
    }

}
