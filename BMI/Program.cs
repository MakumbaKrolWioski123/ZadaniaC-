namespace BMI
{
    public class BMI
    {
        public double waga;
        public double wzrost;
        public double _wynikBMI;

        public double WynikBMI
        {
            get { return _wynikBMI; }
            set { _wynikBMI = value; }
        }


        public double ObliczBMI()
        {
           double bmi = waga / (wzrost * wzrost);
            return bmi;
        }

        public string InterpretujBMI (double bmi)
        {
            if (bmi < 18.5)
            {
                return "Niedowaga";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Waga prawidłowa";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Nadwaga";
            }
            else
            {
                return "Otyłość";
            }
        }
        public BMI(double waga, double wzrost)
        {
            this.waga = waga;
            this.wzrost = wzrost;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wage:");
            double waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w centymetrach:");
            double wzrost = Convert.ToDouble(Console.ReadLine());
            var b1 = new BMI(waga, wzrost/100);
            double WartoscBMI = b1.ObliczBMI();
            Console.WriteLine($"Twoje BMI wynosi: {Math.Round(WartoscBMI,2)}");
            string interpretacja = b1.InterpretujBMI(WartoscBMI);
            Console.WriteLine($"Interpretacja: {interpretacja}");

            b1.WynikBMI = WartoscBMI;
            double wynik = b1.WynikBMI;
        }
    }
}

