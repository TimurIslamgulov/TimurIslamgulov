//Нахождение максимума любого размера одномерного массива
/*
void FillArray(int[] collection, int N)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        
        collection[index] = new Random().Next(1, N);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.WriteLine( "/");

}
void Max(int[] max)
{
    int leght = max.Length;
    int position = 1;
    int maximum = 0;
    while(leght > position)
    {
        if(max[maximum] < max[position])
        {
            max[maximum] = max[position];
        }
        position++;

    }
    Console.WriteLine("Максимальное число - " + max[maximum]);
}
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
FillArray(array, N);
PrintArray(array);
Max(array);
*/


//Задача 10 & 13
/*void Num_2_3(int number)
{
    if(number/100 > 9 || number/10 < 9 )
    {
        Console.WriteLine("Просили же трёхзначное число!!!!");
        
    }
    else
    {
        int num_2 = number / 10 % 10;
        int num_3 = number % 100 % 10;
        Console.WriteLine("Вторая цифра - " + num_2);
        Console.WriteLine("Третья цифра - " + num_3);

    }
}
Console.Write("Введите трёхзначное число - ");
int number = int.Parse(Console.ReadLine());
Num_2_3(number);
*/



// Задача 15
/*
void data(int number)
{
    if(number < 8)
    {
        if(number == 6 || number == 7)
        {
            Console.WriteLine("Чтож сегодня выходной и можно сходить в парк");
        }
        else
        {
            Console.WriteLine("Сегодня рабочий день, стоит ударно поработать"); 
        }
    }
    else Console.WriteLine("Введите число от 1 до 7!!!!");
}
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
data(number);
*/


// задача необязательная
/*void robot (int word)
{
    if(word%10 == 1 && word % 100 != 11)
    {
        Console.WriteLine(word + " программист. ");
    }
    else
    {
        if(word % 10 == 2 && word % 100 != 12 || word % 10 == 3 && word % 100 != 13 || word % 10 == 4 && word % 100 != 14)
        {
            Console.WriteLine(word + " программистa. ");
        }
        else
        {
            Console.WriteLine(word + " программистов. ");
        }
    }
}
Console.WriteLine("Введите кол-во студентов в классе: ");
int word = int.Parse(Console.ReadLine());
robot(word);
*/