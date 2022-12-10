/*//Задача 64: Задайте значение N. 
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
WriteLine();*/

/* //Задача 66: Задайте значения M и N. 
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
WriteLine();*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
using static System.Console;
Clear();

WriteLine(" Введите аргумент функции Аккермана  A(N,M) ");
Write(" Введите аргумент функци N= ");
int n=Convert.ToInt16(ReadLine());
Write(" Введите аргумент функции M= ");
int m=Convert.ToInt16(ReadLine());

int AkkermanFunc(int first, int second)
{
    int result=0;
    if(first==0)
        result=second+1;
    if(second==0)
        result=AkkermanFunc(first-1,second+1);
    if(first!=0&&second!=0)
        result=AkkermanFunc(first-1,AkkermanFunc(first,second-1));
    
    return result;
}

int res=0;
res=AkkermanFunc(n, m);
Write($"Значение фукции Аккермана A({n},{m})={res}");
WriteLine();