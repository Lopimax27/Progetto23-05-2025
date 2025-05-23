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

