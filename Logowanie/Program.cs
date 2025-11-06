namespace Logowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string login="admin";
           string haslo="password";
            int attempts=1;
            Console.WriteLine("Podaj login:");
            string inputLogin = Console.ReadLine();
            Console.WriteLine("Podaj hasło:");
            string inputHaslo = Console.ReadLine();

            while (attempts < 3)
            {
                if (inputLogin == login && inputHaslo == haslo)
                {
                    
                    Console.WriteLine("Logowanie udane!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy login lub hasło!");
                }
                Console.WriteLine("Podaj login:");
                inputLogin = Console.ReadLine();
                Console.WriteLine("Podaj hasło:");
                inputHaslo = Console.ReadLine();

                attempts++;
            }
            if (attempts == 3)
            {
                Console.WriteLine("Konto zablokowane!");
                
            }
        }
    }
}
