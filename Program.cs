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
// static void EvenElementsToZero(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             array[i] = 0;
//         }
//     }
// }
 static void PrintArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
     {
        Console.Write(array[i] + "\t");
     }
 }
// System.Console.WriteLine("Enter the size of the Array");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = new int[size];
// static int[] FillArrayRandom(int[] array)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(-100, 101);

//     }
//     return array;
// }
// FillArrayRandom(myArray);
// PrintArray(myArray);
// System.Console.WriteLine();
// EvenElementsToZero(myArray);
// PrintArray(myArray);
//таск 4,5.
static int SumOfTheArrayElements (int [] array)
{
    int sum = 0;
    for(int i=0 ; i<array.Length ; i++)
    {
        sum = sum +array[i];
    }
    return sum;
} 
static int MultyplyArrayElements (int [] array)
{
    int Multyply = 1;
for(int i =0; i<array.Length ; i++)
{
Multyply= Multyply * array[i];

}
return Multyply;
}
int [] myArray = new int[new Random().Next(1,6)];
static int [] FillArrayConsole (int [] array)
{
    for(int i=0;i<array.Length ; i++)
    {
        System.Console.WriteLine($"Enter the element{i+1}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
FillArrayConsole(myArray);
PrintArray(myArray);
System.Console.WriteLine();
System.Console.WriteLine(MultyplyArrayElements(myArray));
System.Console.WriteLine(SumOfTheArrayElements(myArray));