// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// {y = k1 * x + b1
// {y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int ReadData(string line) //Вводим числа
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int b1 = ReadData("Введите координату b1 :");
int k1 = ReadData("Введите координату k1 :");
int b2 = ReadData("Введите координату b2 :");
int k2 = ReadData("Введите координату k2 :");

// k1 * x + b1 = k2 * x + b2  -->    x * (k1 -k2) = b2- b1   --->    x = (b2-b1)/(k1-k2)
int x = (b2 - b1) / (k1 - k2);
int y = k2 * x + b2;
Console.WriteLine($"Координаты точки пересечения заданных прямых: x={x} y={y}");