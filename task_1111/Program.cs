// найти сумму от 1 до н
// int SUM(int N)
// {
//     int i = N;
//     if (i == 0) return 0;
//     else return i + SUM(i - 1);
// }

// Console.WriteLine(SUM(5));


// int SUM(int n)
// {
//     // int i=N;//
//     if (n == 0) return 0;
//     else return n + SUM(n - 1);
// }
// int SUM2(int N)
// {
//     int summ = 0;
//     for (int i = N; i > 0; i--)
//         summ += i;
//     return summ;
// }
// Console.WriteLine(SUM(5));
// Console.WriteLine(SUM2(5));

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// зад про вывод сроки   из интернета 1,05 семин 9
// string NumbersRec(int a, int b)
// {
//     if (a<=b) return $"{a} "+ NumbersRec(a+1, b);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1,10)); 

// string Queue(int i,int n)//очередь возрастан 3-z
//             {
//              // string result=string.Empty;
//              if (i>n) return "";// "" только для string 0 для int
//              else return $"{i},"+ Queue(i+1,n);  
//             }
//             Console.WriteLine(Queue(15,35));

// string Queue(int n)//очередь убыван
// {
//     string result = string.Empty;
//     if (n == 0) return "";
//     else return $"{n}, {Queue(n - 1)}";  
//             }
//             Console.WriteLine(Queue(6));



// Console.WriteLine("Введите число ");//ребята в зале то же работ
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i<=a; i++)
// {
//     Console.Write(i+" ");
// }



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"  см выше


// int[] CreateArray(int N)//как вариан из 5 лекции от -н до н не работало 
// {
//     int[] arrayA = new int[N  + 1];
//     for (int i = -N; i <= N; i++)
//     {
//         arrayA[i + N] = i;
//     }
//     return arrayA;
// }
// //принять массив на 10 линии, и массивы выводим через string.Join() :)
// int[] arrayA = CreateArray(6);
// Console.WriteLine($"ваш ряд чисел: {string.Join (", ", arrayA) }");

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453-> 12
// 45 -> 9
// int SumDigits(int x)//через цикл
// {
//     int sum = 0;
//     while (x > 0)
//     {
//         sum = sum + x % 10;
//         x = x / 10;
//     }
//     return sum;
// }
//     int SDRek(int x) //через рекурсию
//     {
//         if (x==0) return 0;
//         else return x%10+SDRek(x/10);
//     }                    
// Console.WriteLine(SumDigits(35));
// Console.WriteLine(SDRek (35));


//  адача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Proizv(int a, int b)//цикл
// {
//     int res = 1;
//     for (int i = 1; i <= b; i++) res = res * a;
//     return res;

// }

// int ProizvRek(int a, int b)//рекурсия
// {
//     if (b == 0) return 1;
//     else return a * ProizvRek(a, b - 1);

// }

// Console.WriteLine(Proizv(2, 8));
// Console.WriteLine(ProizvRek(2, 8));


// int countDown(n)//пример рекурсия
// {
//     console.log(n)
// if (n > 1)
//     {
//         countDown(n - 1) // вызов рекурсии
// }
//     else
//     {
//         return true // основное действие
//   }
// }
// countDown(5)

// 5
// 4
// 3
// 2
// 1
// countDown(-1)
// - 1 
// true


// все натуральные числа в промежутке от N до M  из интернета 10.09.22
// Console.Write("Введи N: ");
// int N = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введи M: ");
// int M = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine($"N={N}, M={M}");//N=2, M=6
// if (M>N)
// for (int i = N; i <= M; i++)
//     Console.Write($" {i}");//2 3 4 5 6
// else
//     for (int i = M; i <= N; i++)
//         Console.Write($" {i}");//2 3 4 5 6
