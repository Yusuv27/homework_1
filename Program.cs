Console.WriteLine("Какое задание вас интересует?(введите цифрой): ");
int menu = Convert.ToInt32(Console.ReadLine());
if(menu==1)
{
    //Первое задание:

    Console.WriteLine("Первое задание: программа, которая на вход принимает два числа и выдаёт, какое число максимальное");

    Console.WriteLine("Введите первое число: ");

    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");

    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num > num2)
    {
        Console.WriteLine("Максимальное первое число: "+ num);
    }
    else
    {
        Console.WriteLine("Максимальное второе число: "+ num2);
    }
}
else if(menu==2)
{
    //Второе задание:

    Console.WriteLine("Второе задание:программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");


    Console.WriteLine("Введите первое число: ");

    int num3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");

    int num4 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите третье число: ");

    int num5 = Convert.ToInt32(Console.ReadLine());

    if(num3>num4)
    {
        if(num3>num5)
        {
            Console.WriteLine("Максимальное первое число: "+ num3);
        }
        else
        {
            Console.WriteLine("Максимальное третье число: "+ num5);
        }
    }
    else if(num4>num5)
    {
        Console.WriteLine("Максимальное второе число: "+ num4);
    }
    else
    {
        Console.WriteLine("Максимальное третье число: "+ num5);
    }
}
else if(menu==3)
{
    //Третье задание:
    Console.WriteLine("Третье задание: программа, которая на вход принимает число и выдаёт, является ли число чётным.");

    Console.WriteLine("Введите число: ");

    int num6 = Convert.ToInt32(Console.ReadLine());

    int check = num6 % 2;
    if (check==0)
    {
        Console.WriteLine("Введенное число " + num6 + " четное");
    }
    else
    {
        Console.WriteLine("Введенное число " + num6 + " нечетное");
    }
}
else if(menu==4)
{
    //Четвертое задание:

    Console.WriteLine("Четвертое задание: программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

    Console.WriteLine("Введите число: ");

    int num7 = Convert.ToInt32(Console.ReadLine());

    int check1 = num7 % 2;
    int num8 = num7;
    if(check1 != 0)
    {
        num8 = num7-1;
    } 
    int num9 = 2;
    while(num9!= num8)
    {
        Console.Write(num9+" " );
        num9=num9+2;
    }
    Console.Write(num9+" " );
}
else if(menu==0)
{
    //Строка 0:
    Console.WriteLine("(Введите 1)Первое задание: программа, которая на вход принимает два числа и выдаёт, какое число максимальное");
    Console.WriteLine("(Введите 2)Второе задание:программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("(Введите 3)Третье задание: программа, которая на вход принимает число и выдаёт, является ли число чётным.");
    Console.WriteLine("(Введите 4)Четвертое задание: программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
}
else
{
    Console.WriteLine("Такого задания нет, введите 0, чтобы посмотреть список заданий.");
}
