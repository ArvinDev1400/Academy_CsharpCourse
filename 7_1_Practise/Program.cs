int inputCounter = 0;
int number;
int maxNumber;
maxNumber = int.Parse(Console.ReadLine());
while (inputCounter < 4)
{
    number = int.Parse(Console.ReadLine());
    if (number > maxNumber)
    {
        maxNumber = number;
    }
    inputCounter++;
}

Console.WriteLine(maxNumber);






Console.ReadKey();