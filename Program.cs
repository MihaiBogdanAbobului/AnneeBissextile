namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.
        Console.WriteLine("Entrez votre année");
        int i = Convert.ToInt32(Console.ReadLine());

        if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
        {
            Console.WriteLine("L'année est bissextile");
        }

        else
        {
            Console.WriteLine("L'année n'est pas bissextile");
        }

    }
}