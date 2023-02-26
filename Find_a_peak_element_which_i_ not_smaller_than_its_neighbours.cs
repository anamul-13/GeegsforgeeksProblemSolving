// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Array Length:");
int n=int.Parse(Console.ReadLine());
int[] array = new int[n];

Console.WriteLine("Enter Array Index: ");
for(int i=0; i<n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("The peak Element is: ");

for(int i=1; i<array.Length-1; i++)
{
    if (array[i] > array[i-1] && array[i] > array[i+1])
    {
        Console.WriteLine(array[i]);
    }
}
