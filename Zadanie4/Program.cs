namespace Zadania4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie = "";
            string nazwisko = "Kowalska";
            string wiek = "28";
            string email = "anna.kowalska@example.com";
            string numer="123456789";
            bool imieOk = false;
            bool nazwiskoOk = false;
            bool wiekOk = false;
            bool emailOk = false;
            bool numerOk = false;

            if (imie.Length == 0)
            {
                imieOk = false;
                Console.WriteLine("[Pole]✗ Imie nie może być puste!");
            }
            else
            {
                imieOk = true;
                Console.WriteLine("[Pole]✓ OK");
            }

            if (nazwisko.Length == 0)
            {
                nazwiskoOk = false;
                Console.WriteLine("[Pole]✗ Nazwisko nie może być puste!");
            }
            else
            {
                nazwiskoOk = true;
                Console.WriteLine("[Pole]✓ OK");
            }

            if (int.TryParse(wiek, out int wiekNumer))
            {
                if(wiekNumer>=18 && wiekNumer<=100)
                {
                     wiekOk = true;
                    Console.WriteLine("[Pole]✓ OK");
                }
                else
                {
                     wiekOk = false;
                    Console.WriteLine("[Pole]✗ Wiek musi być między 18 a 100 lat.");
                }
            }
            else
            {
                 wiekOk = false;
                Console.WriteLine("[Pole]✗ Nieprawidlowa wartosc!");
            }

            if (email.Contains("@") && email.Contains("."))
            {
                emailOk = true;
                Console.WriteLine("[Pole]✓ OK");
            }
            else
            {
                emailOk = false;
                Console.WriteLine("[Pole]✗ Nieprawidlowy format email!");
            }

            if(numer.Length==9 && long.TryParse(numer, out long numerTelefonu))
            {
                numerOk = true;
                Console.WriteLine("[Pole]✓ OK");
            }
            else
            {
                numerOk = false;
                Console.WriteLine("[Pole]✗ Numer telefonu musi zawierać 9 cyfr!");
            }

            if(wiekOk && emailOk && numerOk && imieOk && nazwiskoOk)
            {
                Console.WriteLine("Wszystkie pola są poprawne.");
            }
            else
            {
                Console.WriteLine("Niektóre pola zawierają błędy.");
            }
        }
    }
}
