// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine ("Веедите число N");
int n = 10;
int[] arr = new int[n];
int i = 0;
//while (i < n)
while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.WriteLine(arr[i]);
    //Console.WriteLine(" ");
    Console.Write($"{arr[i]} ");
    i = i + 1;
}