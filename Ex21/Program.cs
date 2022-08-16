// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));
}

Console.WriteLine("Введите трехмерные координаты первой точки:");
Console.Write("x1: ");
int xDot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int yDot1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int zDot1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите трехмерные координаты второй точки:");
Console.Write("x2: ");
int xDot2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int yDot2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int zDot2 = Convert.ToInt32(Console.ReadLine());

double value = Distance3D(xDot1, yDot1, zDot1, xDot2, yDot2, zDot2);
Console.WriteLine($"Расстояние между двумя заданными точками = {value}");
