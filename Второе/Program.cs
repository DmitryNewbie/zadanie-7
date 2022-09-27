Console.WriteLine("Введите номер строки");
int line = Convert.ToInt32(Console.ReadLine())-1;
Console.WriteLine("Введите номер столбца");
int linedown = Convert.ToInt32(Console.ReadLine())-1;
int [,] numbers = new int [5,5];


if (line > numbers.GetLength(0) || linedown > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента массива =" , numbers[line, linedown]);
}


void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
                Console.Write(array[i,j] + " ");
            } 
            Console.WriteLine(" ");  
        }
}
Random(numbers);