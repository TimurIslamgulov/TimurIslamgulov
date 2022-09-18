/* Задача 25
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*int pr = 1;
Console.Write("Введите число А = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    pr = pr * a;
}
Console.WriteLine($"Итого получается = {pr}.");
*/


/*Задача 27: Напишите программу, 
которая принимает на вход число и выдаёт сумму цифр в числе.*/
/*int sum = 0;
int d;
Console.Write("Введите число А = ");
int a = Convert.ToInt32(Console.ReadLine());
while(a > 0)
{
    d = a % 10;
    sum += d;
    a = a/10;
}

Console.WriteLine($"Итого получается = {sum}.");
*/



/*Задача 29: Напишите программу,
которая задаёт массив из 8 элементов и выводит их на экран.*/
/*Console.Write("Введите колличество эллементов массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write($"{i} элемент = ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    
    
}
for(int i = 0; i < n; i++)
{
    
    if (i!= n-1) Console.Write($"{arr[i]},");
    else Console.Write($"{arr[i]}!");
}*/

//Необязательная задачка: Написать программу сортировки массива от большего к меньшему. 
//Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.

Console.Write("Введите колличество эллементов массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write($"{i} элемент = ");
    arr[i] = new Random().Next(1,10);
    Console.WriteLine(arr[i]);
    
    
}
for(int i = 0; i < n; i++)
{
    
    if (i!= n-1) Console.Write($"{arr[i]},");
    else Console.WriteLine($"{arr[i]}!");
}
for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(0) - 1 - i; j++)
    {
       int temp;
       if(arr[j]<arr[j+1])
       {
            temp = arr[j];
            arr[j] = arr[j+1];
            arr[j+1] = temp;
    
       } 
    }
}
for(int i = 0; i < arr.GetLength(0); i++)
{
    if (i!= n-1) Console.Write($"{arr[i]},");
    else Console.WriteLine($"{arr[i]}!");
}
