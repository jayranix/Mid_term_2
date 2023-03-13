class Program
    {
        static void Main(string[] args)
        {
            int breakfastSet = 5;
            int weekendSet = 2;
            int coffee = 3;

            while (true)
            {
                                Console.WriteLine("Enter day of week (1-7):");
                int dayOfWeek = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter time of day (8-18):");
                int timeOfDay = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter menu (Breakfast Set, Weekend Set, Coffee):");
                string menu = Console.ReadLine();

                bool validMenu = true;
                switch (menu)
                {
                    case "Breakfast Set":
                        if (dayOfWeek == 7 || timeOfDay > 11)
                        {
                            Console.WriteLine("Sorry your order is not available.");
                            validMenu = false;
                        }
                        else if (breakfastSet == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock.");
                            validMenu = false;
                        }
                        else
                        {
                            breakfastSet--;
                        }
                        break;

                    case "Weekend Set":
                        if (dayOfWeek < 6)
                        {
                            Console.WriteLine("Sorry your order is not available.");
                            validMenu = false;
                        }
                        else if (weekendSet == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock.");
                            validMenu = false;
                        }
                        else
                        {
                            weekendSet--;
                        }
                        break;

                    case "Coffee":
                        if (coffee == 0)
                        {
                            Console.WriteLine("Sorry your order is out of stock.");
                            validMenu = false;
                        }
                        else
                        {
                            coffee--;
                        }
                        break;

                    default:
                        Console.WriteLine("Please enter a valid menu.");
                        validMenu = false;
                        break;
                }

                if (menu == "End")
                {
                    break;
                }

            }
        }
    }
}