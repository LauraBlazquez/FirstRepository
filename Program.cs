using System;
namespace activitats;
public class MenuAreas
{
    public static void Main()
    {
        const string Msg = "De quin polígon vols calcular l'àrea?\n1) Quadrat\n2) Rectangle\n3) Cercle\n4) Pentàgon\n";
        const string MenuError = "";
        const string InputArist = "Diguem la mesura del costat del polígon en cm:";
        const string InputRadium = "Diguem la mesura del radi del polígon en cm:";
        int option;
        double result;

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
                result = Area(arist);
                break;
            case 2:
                double aristLong, aristShort;
                Console.WriteLine(InputArist);
                aristLong = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(InputArist);
                aristShort = Convert.ToDouble(Console.ReadLine());
                result = Area(aristLong, aristShort);
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
                Console.WriteLine(InputRadium);
                radium = Convert.ToDouble(Console.ReadLine());
                result = OtherArea(arist, radium);
                break;
        }
    }

    public static double Area(double num)
    {
        return num * num;
    }
    public static double Area(double aristLong, double aristShort)
    {
        const int Two = 2;
        return aristLong * aristShort / Two;
    }
    public static double CercleArea(double num)
    {
        const double Pi = Math.PI;
        const int Two = 2;
        return Pi * Math.Pow(num, Two);
    }
    public static double OtherArea(double arist, double radium)
    {
        const string Ap = "Diguem la mesura de l'apotema del polígon en cm:";
        const int Five = 5, Two = 2;
        double ap;
        Console.WriteLine();
        ap = Convert.ToDouble(Console.ReadLine());
        return arist * Five * ap / Two;
    }
}