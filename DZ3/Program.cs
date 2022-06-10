int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Input(" номер дня недели: ");

if (number == 6 || number == 7)
    {
    Console.WriteLine("да");
    }
else if (number >7)
    {
    Console.WriteLine("не правильное число");
    }
else
    {
    Console.WriteLine("нет");
    }