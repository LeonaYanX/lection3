//Task 1
// static double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denomenator = c + d;
//     double result = numenator / denomenator;
//     return result;
// }
// System.Console.WriteLine(CalculateFormula(2, 3, 4, 5));
//Таск 2
static void SqaresPrint(int number)
{

    for (int i = 1; i <= number; i++)
    {
        System.Console.WriteLine($"{i * i}\t");
    }
}

SqaresPrint(11);