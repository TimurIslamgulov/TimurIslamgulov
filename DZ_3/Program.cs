//Задача 23

/*void cube(int N)
{
    for(int i=1; i<=N; i++)
    {
        int cube = i*i*i;
        Console.Write(cube + ", ");
    }
}
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
cube(N);
*/


//Задача 21 (скорее всего надо попытаться решить задачу через массив)
/*
void distanse (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double D = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));

    Console.WriteLine("Расстояние между двумя точками равно = " + D);
}
Console.WriteLine("Введите координаты первой точнки: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точнки: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
distanse(x1,y1,z1,x2,y2,z2);
*/


//Задача 19
/*
static bool Palindrom(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - i - 1])
        {
           Console.WriteLine("NO!");     
           return false;
        }
    }
    Console.WriteLine("YES!");
    return true;
}
Console.Write("Введите пятизначное число: ");
string s = Console.ReadLine();
Palindrom(s);
*/