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