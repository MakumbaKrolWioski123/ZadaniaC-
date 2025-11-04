namespace Generator
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę zadań do wygenerowania (1-20): ");
            string liczbaZadan = Console.ReadLine();
            int liczba = int.Parse(liczbaZadan);
            while (liczba < 1 || liczba > 20)
            {
                Console.WriteLine("Liczba zadań musi być z zakresu 1-20, wpisz ponownie: ");
                liczbaZadan = Console.ReadLine();
                liczba = int.Parse(liczbaZadan);
            }

            int j = 0;
            for (int i = 0; i <= liczba; i++)
            {
                j = i + 1;
                if (j % 2 == 0)
                {
                    Console.WriteLine($"Zadanie {j} - Priorytet normalny");
                }
                else
                {
                    Console.WriteLine($"Zadanie {j} - Priorytet wysoki");
                }
            }
        }
    }
}
