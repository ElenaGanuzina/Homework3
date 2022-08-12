// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindCubes(int number)
{
    Console.Write($"{number} -> ");

    int count = 1;
    while (count < number)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;  
    }
Console.WriteLine($"{Math.Pow(number, 3)}.");
}

FindCubes(3);
FindCubes(5);
