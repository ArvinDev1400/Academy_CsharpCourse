//int count = 1;

//while (count < 10)
//{
//    Console.WriteLine(count);
//    count++;
//}

Console.WriteLine("please enter the number");
long number = long.Parse(Console.ReadLine());
long i = number;
long count = 0;

while (i > 0)
{
    if (number % i == 0)
    {
        count++;
    }
    i--;
}

if (count == 2)
{
    Console.WriteLine("it's prime");
}
else
{
    Console.WriteLine("not prime");
}

Console.ReadKey();