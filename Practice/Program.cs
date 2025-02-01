int totalPrice = 0;
string userChoice = "";

Console.WriteLine("Welcome to the Food Menu System!");

do
{
    Console.WriteLine("\nAvailable Food Items:");
    Console.WriteLine("1. Pizza-Makhloot");
    Console.WriteLine("2. Pizza-Veggie");
    Console.WriteLine("3. Pizza-Pepperoni");

    Console.Write("\nPlease enter the number of the food you want to order (1-3): ");
    string foodChoice = Console.ReadLine();

    string foodName = "";
    int price = 0;
    bool validFood = true;

    switch (foodChoice)
    {
        case "1":
            foodName = "Pizza-Makhloot";
            break;
        case "2":
            foodName = "Pizza-Veggie";
            break;
        case "3":
            foodName = "Pizza-Pepperoni";
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid food item.\n");
            validFood = false;
            break;
    }

    if (!validFood)
        continue;

    Console.WriteLine("\nAvailable Sizes:");
    Console.WriteLine("1. Small");
    Console.WriteLine("2. Medium");
    Console.WriteLine("3. Large");

    Console.Write("\nPlease select a size (1-3): ");
    string sizeChoice = Console.ReadLine();

    switch (foodName)
    {
        case "Pizza-Makhloot":
            switch (sizeChoice)
            {
                case "1":
                    price = 80000;
                    break;
                case "2":
                    price = 150000;
                    break;
                case "3":
                    price = 220000;
                    break;
                default:
                    Console.WriteLine("Invalid size. Please select a valid size.\n");
                    continue;
            }
            break;
        case "Pizza-Veggie":
            switch (sizeChoice)
            {
                case "1":
                    price = 70000;
                    break;
                case "2":
                    price = 135000;
                    break;
                case "3":
                    price = 200000;
                    break;
                default:
                    Console.WriteLine("Invalid size. Please select a valid size.\n");
                    continue;
            }
            break;
        case "Pizza-Pepperoni":
            switch (sizeChoice)
            {
                case "1":
                    price = 100000;
                    break;
                case "2":
                    price = 170000;
                    break;
                case "3":
                    price = 250000;
                    break;
                default:
                    Console.WriteLine("Invalid size. Please select a valid size.\n");
                    continue;
            }
            break;
    }

    totalPrice += price;
    Console.WriteLine($"You selected {foodName} for {price}.\n");

    Console.Write("Do you want to order another item? (yes/no): ");
    userChoice = Console.ReadLine();

    while (true)
    {
        if (userChoice == "yes" || userChoice == "no")
            break;
        Console.Write("Please enter 'yes' or 'no' : ");
        userChoice = Console.ReadLine();
    }

} while (userChoice == "yes");

Console.WriteLine($"\nYour total price is: ${totalPrice}");
Console.WriteLine("Thank you for your order!");

