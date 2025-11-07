namespace Klasa_enkapsulacja
{
    public class Product
    {
        private string nazwa;
        private decimal cena;
        private int iloscNaMagazynie;

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public decimal Cena
        {
            get { return cena; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Cena nie może być ujemna.");
                }
                cena = value; 
            }
        }
        public int IloscNaMagazynie
        {
            get { return iloscNaMagazynie; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Ilość na magazynie nie może być ujemna.");
                }
                iloscNaMagazynie = value; 
            }
        }

        public Product(string nazwa, decimal cena,int iloscNaMagazynie)
        {
            this.Nazwa = nazwa;
            this.Cena = cena;
            this.IloscNaMagazynie = iloscNaMagazynie;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Nazwa produktu: {Nazwa}");
            Console.WriteLine($"Cena: {Cena} PLN");
            Console.WriteLine($"Ilość na magazynie: {IloscNaMagazynie}");
        }
    }
      
    internal class Program
    {
        static void Main(string[] args)
        {
           var produkt = new Product("Laptop", -3500.99m, 10);
            produkt.WyswietlInformacje();
        }
    }
}


