//int[] myNums = { 2, 3, 4, };
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

int[] myNums = new int[10];
Random rng = new Random();

int sum = 0;
for (int i = 0; i < myNums.Length; i++)
{
    myNums[i] = rng.Next(1, myNums.Length +1 );
    sum = sum + myNums[i];
}
foreach (int element in myNums)
{
    Console.WriteLine(element);
}
Console.WriteLine($"Total: {sum}");
