//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using static System.Console;
Clear();

Write(" Введите натуральное число M= ");
int m=Convert.ToInt16(ReadLine());
Write(" Введите натуральное число N= ");
int n=Convert.ToInt16(ReadLine());

int SuumSeries(int start, int end)
{
    int result=0;
    if(start==end) 
        return result+=start;
   return result=start+SuumSeries(start+1,end);;
}
int res=0;
if(m<=n)
     res=SuumSeries(m, n);
else
    res=SuumSeries(n, m);
Write("Сумма всех элементов "+(res));
WriteLine();