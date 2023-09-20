// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Pls enter day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

//var.1
// if (number < 1 || number > 7)
// {
//     Console.WriteLine("There is no such day!");
// }
// else
// {
//     if (number == 1)
//     {
//         Console.WriteLine("Monday");
//     }
//     if (number == 2)
//     {
//         Console.WriteLine("Tuesday");
//     }
//     if (number == 3)
//     {
//         Console.WriteLine("Wensday");
//     }
//     if (number == 4)
//     {
//         Console.WriteLine("Tuesday");
//     }
//     if (number == 5)
//     {
//         Console.WriteLine("Friday");
//     }
//     if (number == 6)
//     {
//     Console.WriteLine("Saturday");
//     }
//     if (number == 7)
//     {
//     Console.WriteLine("Sunday");
//     }
// }


//var.2
// if (number == 1)
// {
//     Console.WriteLine("Monday");
// }
// else if  (number == 2)
// {
//     Console.WriteLine("Tuesday");
// }
// else if  (number == 3)
// {
//     Console.WriteLine("Wensday");
// }
// else if  (number == 4)
// {
//     Console.WriteLine("Thersday");
// }
// else if  (number == 5)
// {
//     Console.WriteLine("Friday");
// }
// else if  (number == 6)
// {
//     Console.WriteLine("Saturday");
// }
// else if  (number == 7)
// {
//     Console.WriteLine("Sunday");
// }
// else
// {
//     Console.WriteLine("There is no such day!!!");
// }

//var.3
switch (number)
{
    case 1:
    {
        Console.WriteLine("Monday");
        break;
    }
    case 2:
    {
        Console.WriteLine("Tuesday");
        break;
    }
    case 3:
    {
        Console.WriteLine("Wensday");
        break;
    }
    case 4:
    {
        Console.WriteLine("Thersday");
        break;
    }
    case 5:
    {
        Console.WriteLine("Friday");
        break;
    }
    case 6:
    {
        Console.WriteLine("Saturday");
        break;
    }
    case 7:
    {
        Console.WriteLine("Sunday");
        break;
    }
    default:
    {
        Console.WriteLine("No such day");
        break;
    }
}
