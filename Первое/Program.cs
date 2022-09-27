Console.WriteLine("Введите число строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число столбцов");
int linedown = Convert.ToInt32(Console.ReadLine());
double[, ] numbers = new double[line,linedown];

void random(double[, ] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j< array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100,100))/10;
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

random(numbers);