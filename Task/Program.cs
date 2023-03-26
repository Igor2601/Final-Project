using System;
using static System.Console;
Clear();
string[]array = {"Hello", "2", "World", "Russia", "-3"};
Write($"[{String.Join(", ",array)}]");
int n = new Random().Next(4);
string[]result = new string[n];
for (int i = 0; i < n; i++)
result[i]=array[i];
Write($" -> [{String.Join(", ",result)}]");
