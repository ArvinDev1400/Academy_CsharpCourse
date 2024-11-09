int number = 10;
//number++;
//number--;

number %= 4;

Console.WriteLine(number);
Console.ReadKey();


Console.WriteLine("please enter number of week:");
int numberOfWeek = int.Parse(Console.ReadLine());

if (numberOfWeek == 1)
    Console.WriteLine("Saturday");

else if (numberOfWeek == 2)
    Console.WriteLine("Sunday");

else if (numberOfWeek == 3)
    Console.WriteLine("Monday");

else if (numberOfWeek == 4)
    Console.WriteLine("Tuesday");

else if (numberOfWeek == 5)
    Console.WriteLine("Wednesday");

else if (numberOfWeek == 6)
    Console.WriteLine("Thursday");

else if (numberOfWeek == 7)
    Console.WriteLine("Friday");

else if (numberOfWeek < 1 && numberOfWeek > 7)
    Console.WriteLine();

Console.ReadKey();