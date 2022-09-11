// Homework 9. Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N. 
// M = 1; N = 15 -> 120 
// M = 4; N = 8. -> 30 

int SUM(int M, int N)
{
    if (N<M) return 0;
    else return N + SUM(M, N- 1);
}
Console.WriteLine(SUM(4, 8));











/* int ProizvRek(int a, int b) // возвед в степень
{
    if (b == 0) return 1;
    else return a * ProizvRek(a, b - 1); //b как счетчик вызывается 
}
Console.WriteLine(ProizvRek(2, 8)); */
