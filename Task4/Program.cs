﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int n = 5;
int[] array = {2,4,7,3,9};
int i = 0;
int max = array[0];
while (i < n)
{
  if(array[i] > max)
  {
    max = array[i];
  }
  i++;
}
Console.WriteLine(max);