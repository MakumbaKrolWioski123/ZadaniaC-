namespace Bank
{
    public class KontoBankowe
    {
        public string numerKonta;
        public decimal saldo;
        public KontoBankowe(string numerKonta,decimal saldo)
        {
            this.numerKonta = numerKonta;
            this.saldo = saldo;
        }

        public void Wplata_Wyplata(decimal kwota, int czyWplata)
        {
            if (czyWplata==1)
            {
                saldo += kwota;
                Console.WriteLine($"Wpłacono {kwota} PLN. Nowe saldo: {saldo} PLN.");
            }
            else if (czyWplata==2)
            {
                if (kwota > saldo)
                {
                    Console.WriteLine("Niewystarczające środki na koncie.");
                }
                else
                {
                    saldo -= kwota;
                    Console.WriteLine($"Wypłacono {kwota} PLN. Nowe saldo: {saldo} PLN.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowa operacja. Wybierz 1 dla wpłaty lub 2 dla wypłaty.");
            }
        }
     
        public void WyswietlSaldo()
        {
            Console.WriteLine($"Saldo konta {numerKonta}: {saldo} PLN.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var konto = new KontoBankowe("1234567890", 1000);
            konto.WyswietlSaldo();
            Console.WriteLine("Operacje:");
            Console.WriteLine("1. Wpłata");
            Console.WriteLine("2. Wypłata");
            Console.Write("Wybierz operację (1 lub 2): ");
            int wybor = int.Parse(Console.ReadLine());
            Console.Write("Podaj kwotę: ");
            decimal kwota = decimal.Parse(Console.ReadLine());
            konto.Wplata_Wyplata(kwota, wybor);
        }
    }
}

