 do
    {
        Console.WriteLine("Выберите программу");
        Console.WriteLine("1.Угадай число");
        Console.WriteLine("2.Таблица умножения");
        Console.WriteLine("3.Делители числа");
        Console.WriteLine("4.Выйти");
        string programs = Console.ReadLine();
        switch (programs)
        {
            case "1":
                randomnum();
                break;
            case "2":
            table();
            break;
            case "3":
            delitel();
            
                break;
            case "4":
                return;
        }
    } while (true);
static void randomnum()
{
    Random random = new();
    int randomint = random.Next(100);
    Console.WriteLine("Введите число");
    int number = -1;
    do
    {
        number = Convert.ToInt32(Console.ReadLine());
        if (number < randomint)
        {
            Console.WriteLine("Больше");
            Console.WriteLine("Введите число еще раз");
        }
        if (number > randomint)
        {
            Console.WriteLine("Меньше");
            Console.WriteLine("Введите число еще раз");
        }
    } while (number != randomint);
    Console.WriteLine("Вы угадали!");
}
static void delitel()
{
    Console.WriteLine("Введите число");
    int numint = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= numint; i++)
    {
        int result = numint % i;
        if (result == 0)
        {
            Console.WriteLine(i);
        }
    }
}
static void table()
{
    int[,] table = new int[10, 10];
    for (int i = 1; i < 10; i++)
    {
        Console.Write(i + "  ");
        for (int j = 1; j < 10; j++)
        {
            Console.Write("\t" + i * j);
        }
        Console.WriteLine("");

    }
}
