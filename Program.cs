//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 80,95

int number_from_user = UserCreateArray("Задайте размер массива ");


int UserCreateArray(string numbers)
{
    System.Console.Write(numbers);
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число");
    }
    return i;
}


void FillRandom(double[] numbers)
{
    Random rnd = new Random();
    for(int i = 0; i < numbers.Length; i++)
    //numbers[i] = Math.Round((rnd.NextDouble() * 100), 2);
    numbers[i] = Math.Round(rnd.Next(-100, 101)*0.1, 2);
}


double MinimumNumber(double[] numbers)
{
    double min = numbers[0];
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < min)
        min = numbers[i];
    }
    return min;
}


double MAXimumNumber(double[] numbers)
{
    double max = numbers[0];
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > max)
        max = numbers[i];
    }
    return max;
}

int CountNumbers(double[] numbers)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i ++ )
    {
        count = count + 1;
    }
    return count;
}

void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        System.Console.WriteLine(numbers[i]);
    }
    System.Console.WriteLine();
}


void FillArray ()
{
    double[] array = new double [number_from_user];
    FillRandom(array);
    PrintArray(array);
    CountNumbers(array);
    System.Console.WriteLine($"Кол-во элементов в массиве {CountNumbers(array)}");
    MinimumNumber(array);
    System.Console.WriteLine($"Минимальное число: {MinimumNumber(array)}");
    MAXimumNumber(array);
    System.Console.WriteLine($"Максимальное число: {MAXimumNumber(array)}");
    System.Console.WriteLine($"Разница между min и max = {MAXimumNumber(array) - MinimumNumber(array)}");
}


FillArray();