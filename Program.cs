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
// static void SqaresPrint(int number)
// {

//     for (int i = 1; i <= number; i++)
//     {
//         System.Console.WriteLine($"{i * i}\t");
//     }
// }

// SqaresPrint(11);
//таск 3
static void EvenElementsToZero (int [] array)
{
    for(int i = 0 ; i < array.Length ; i++)
    {
        if (array[i]%2 == 0)
        {
            array[i] = 0;
        }
    }
} 
static void PrintArray (int [] array)
{
    for(int i = 0;i<array.Length;i++)
    {
        Console.Write(array[i] + "\t");
    }
}
System.Console.WriteLine("Enter the size of the Array");
int size = Convert.ToInt32(Console.ReadLine());
int [] myArray = new int [size];
static int [] FillArrayRandom (int [] array )
{
    Random random = new Random();
    for(int i=0 ; i<array.Length;i++)
    {
        array[i] = random.Next(-100,101);

    }
    return array;
}
FillArrayRandom(myArray);
PrintArray(myArray);
System.Console.WriteLine();
EvenElementsToZero(myArray);
PrintArray(myArray);