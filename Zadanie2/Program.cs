namespace Zadanie3
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 4;
            int suma= a + b;
            int roznica = a - b;
            int iloczyn = a * b;
            int iloraz = a / b;
            int reszta = a % b;
                
            Console.WriteLine($"Dane liczby: a = {a}, b = {b}");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Różnica: {roznica}");
            Console.WriteLine($"Iloczyn: {iloczyn}");
            Console.WriteLine($"Iloraz: {iloraz}");
            Console.WriteLine($"Reszta z dzielenia: {reszta}");
        }
    }
}
