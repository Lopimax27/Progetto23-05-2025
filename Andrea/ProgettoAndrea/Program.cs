static void Visualizza()
{
    Console.WriteLine("\n-- Elenco dei dipendenti --");
    foreach (Dipendente d in dipendenti)
    {
        Console.WriteLine(d.ToString());
    }

}
