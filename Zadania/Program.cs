namespace Zadania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsjusz = 25;
            double farenheit = (temperaturaCelsjusz * 9 / 5) + 32;
            temperaturaCelsjusz = (farenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperatura w Farenheitach: {Math.Round(farenheit, 2)}");
            Console.WriteLine($"Konwersja z powrotem do Celsjusza: {Math.Round(temperaturaCelsjusz, 2)}");
            if (temperaturaCelsjusz < 0)
            {
                Console.WriteLine("Uwazaj temperatura poniżej zera!");
            }
        }
    }
}
