// Homework 9. Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// M = 1; N = 5. -> ""1, 2, 3, 4, 5"" 
// M = 4; N = 8. -> ""4, 6, 7, 8"" 

string Queue(int M, int N)
{
    if (M > N) return " ";
    else return $"{M}, " + Queue(M + 1, N);//запомнить
}
Console.WriteLine(Queue(4, 8));