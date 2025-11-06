namespace Oceny
    {
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Podaj swoją ocenę (1-6):");
              string input = Console.ReadLine();
            int ocena=int.Parse(input);
            string opisOceny="";
            if(ocena>=1 && ocena<=6)
            {
                switch(ocena)
                {
                    case 1:
                        opisOceny="niedostateczny";
                        break;
                    case 2:
                        opisOceny="dopuszczający";
                        break;
                    case 3:
                        opisOceny="dostateczny";
                        break;
                    case 4:
                        opisOceny="dobry";
                        break;
                    case 5:
                        opisOceny="bardzo dobry";
                        break;
                    case 6:
                        opisOceny="celujący";
                        break;
                }
                Console.WriteLine($"Twoja ocena to: {opisOceny}");
            }
            else
            {
                Console.WriteLine("Nieprawidłowa ocena! Podaj liczbę od 1 do 6.");
            }
        }
    }
}
