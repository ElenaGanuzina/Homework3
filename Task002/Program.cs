//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt(Math.Pow((x2 -x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2 - z1), 2));
    return dist;
}
Console.WriteLine(FindDist(4, 9, -5, 0, 3, 6));
Console.WriteLine(FindDist(0, -5, 8, 13, 4, 9));
