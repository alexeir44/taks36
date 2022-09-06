double [] RandomArray = {0, 0, 0, 0, 0, 0, 0, 0};
byte i;

// Поиск максимального
double FindMax(double max, double getNumber)
{
    if (max < getNumber)
        max = getNumber;
        return max;
}

// Поиск минимального
double FindMin(double min, double getNumber)
{
    if (min > getNumber)
        min = getNumber;
        return min;
}

// Генерация случайного числа
double RandomGenerator()
{
    double randomNumber = new  Random().Next(-99, 100); //new.NextDouble();
    Console.Write($"{randomNumber} ");
    return randomNumber;
}

// Код программы
Console.Write("Сгенерирован массив: ");
for (i = 0; i<RandomArray.Length; i++)
{
    RandomArray[i] = RandomGenerator();
}
Console.WriteLine("");
double maximum = RandomArray[0];
double minimum = RandomArray[0];

for (i = 0; i<RandomArray.Length; i++)
{
    maximum = FindMax(maximum, RandomArray[i]);
    minimum = FindMin(minimum, RandomArray[i]);
}

Console.Write($"Разница между максимальным и минимальным = {maximum - minimum}");