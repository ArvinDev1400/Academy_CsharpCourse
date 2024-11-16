
#region Week

//Console.WriteLine("please enter number of week:");
//int numberOfWeek = int.Parse(Console.ReadLine());
//switch (numberOfWeek)
//{
//    case 1:
//        Console.WriteLine("Saturday");
//        break;

//    case 2:
//        Console.WriteLine("Sunday");
//        break;

//    case 3:
//        Console.WriteLine("Monday");
//        break;

//    case 4:
//        Console.WriteLine("Tuesday");
//        break;

//    case 5:
//        Console.WriteLine("Wednesday");
//        break;

//    case 6:
//        Console.WriteLine("Thursday");
//        break;

//    case 7:
//        Console.WriteLine("Friday");
//        break;

//    default:
//        Console.WriteLine("number incorrect");
//        break;
//}

#endregion

try
{

    Console.WriteLine("please enter first number:");
    int number1 = int.Parse(Console.ReadLine());


    Console.WriteLine("please enter second number:");
    int number2 = int.Parse(Console.ReadLine());

    Console.WriteLine("please enter one operator. Example: '*' '/' '+' '-'");
    string operation = Console.ReadLine();

    switch (operation)
    {
        case "/":
            Console.WriteLine(number1 / number2);
            break;

        case "*":
            Console.WriteLine(number1 * number2);
            break;

        case "-":
            Console.WriteLine(number1 - number2);
            break;

        case "+":
            Console.WriteLine(number1 + number2);
            break;

        default:
            Console.WriteLine("my application not support this operation");
            break;
    }


    Console.ReadKey();
}
catch (Exception)
{

    Console.WriteLine("error: please recheck in input valus");
}