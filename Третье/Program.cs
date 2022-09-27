Console.WriteLine("введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int linedown = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[line, linedown];
random(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = (sum + numbers[i, j]);
    }
    sum = sum / line;
    Console.Write(sum + "; ");
}
Console.WriteLine();

void random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine("");    
    }
}
