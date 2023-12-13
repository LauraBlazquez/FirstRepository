using System;
namespace activitats
{
    public class MenuAreas
    {
        public static void Main()
        {
            const string Msg = "De quin polígon vols calcular l'àrea?\n1) Quadrat\n2) Rectangle\n3) Cercle\n4) Pentàgon\n";
            const string MenuError = "";
            const string InputArist = "Diguem la mesura del costat del polígon en cm:";
            const string InputRadium = "Diguem la mesura del radi del polígon en cm:";
            int option;
            double result = 0;

            do
            {
                Console.WriteLine(Msg);
                option = Convert.ToInt32(Console.ReadLine());
                if (option < 1 || option > 4) Console.WriteLine(MenuError);
            } while (option < 1 || option > 4);

            switch (option)
            {
                case 1:
                    double arist;
                    Console.WriteLine(InputArist);
                    arist = Convert.ToDouble(Console.ReadLine());
                    result = QuadrilateralArea(arist);
                    break;
                case 2:
                    double aristLong, aristShort;
                    Console.WriteLine(InputArist);
                    aristLong = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(InputArist);
                    aristShort = Convert.ToDouble(Console.ReadLine());
                    result = QuadrilateralArea(aristLong, aristShort);
                    break;
                case 3:
                    double radium;
                    Console.WriteLine(InputRadium);
                    radium = Convert.ToDouble(Console.ReadLine());
                    result = CercleArea(radium);
                    break;
                case 4:
                    Console.WriteLine(InputArist);
                    arist = Convert.ToDouble(Console.ReadLine());
                    result = PentagonArea(arist);
                    break;
            }
            Console.WriteLine($"L'area del polígon és de {result} cm.");
        }
        public static double QuadrilateralArea(double num)
        {
            return Math.Round(num * num,2);
        }
        public static double QuadrilateralArea(double aristLong, double aristShort)
        {
            return Math.Round(aristLong * aristShort,2);
        }
        public static double CercleArea(double num)
        {
            const double Two = 2;
            return Math.Round(Math.PI * Math.Pow(num, Two),2);
        }
        public static double PentagonArea(double num)
        {
            const int Five = 5, Two = 2;
            return Math.Round(num * Five * num / Two,2);
        }
    }
}