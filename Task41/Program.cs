// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadData (string line)
{
Console.WriteLine(line);
int number = int.Parse(Console.ReadLine()??"");
return number;
}


int len = ReadData("Сколько чисел хотите ввести: ");
int count = 0;
int temp = 0;
for (int i = 0; i < len; i++)
{
    temp = ReadData("Введите число: ");
    if (temp > 0) count++;
}
Console.WriteLine($"Чисел больше ноля: {count}");