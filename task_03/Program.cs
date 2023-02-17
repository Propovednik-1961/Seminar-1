// 

Console.Write("Введите день недели ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.Write("понедельник ");
        break;

    case 2:
        Console.Write("вторник ");
        break;

    case 3:
        Console.Write("среда ");
        break;

    case 4:
        Console.Write("четверг ");
        break;

    case 5:
        Console.Write("пятницца ");
        break;
    case 6:
        Console.Write("суббота ");
        break;

    case 7:
        Console.Write("воскресенье ");
        break;

    default:
    Console.Write("Не верное значение! ");
    break;    
}