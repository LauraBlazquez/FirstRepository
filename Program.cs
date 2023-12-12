public static double OtherArea(double arist, double radium)
{
    const string Ap = "Diguem la mesura de l'apotema del polígon en cm:";
    const int Five = 5, Two = 2;
    double ap;
    Console.WriteLine();
    ap = Convert.ToDouble(Console.ReadLine());
    return arist * Five * ap / Two;
}