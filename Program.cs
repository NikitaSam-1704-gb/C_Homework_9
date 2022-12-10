//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

Write(" Введите натуральное число N-> ");
int n=Convert.ToInt16(ReadLine());

string OutputSeries(int n)
{
    string result="";
    if(n==1) 
        return result=" "+n.ToString();
   return result=" "+n.ToString()+","+OutputSeries(n-1).ToString();
}
string res="";
Write("-> '"+(res=OutputSeries(n))+" ' ");
WriteLine();