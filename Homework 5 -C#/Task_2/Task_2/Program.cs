namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Creating 4 car objects from the Class Car
            Car car1 = new Car("BMW", 100);
            Car car2 = new Car("Audi", 110);
            Car car3 = new Car("Ferrari", 150);
            Car car4 = new Car("Fiat", 80);

            // Creating 4 driver objects from the Class Driver
            Driver driver1 = new Driver("John", 1);
            Driver driver2 = new Driver("Bob", 2);
            Driver driver3 = new Driver("Jill", 2);
            Driver driver4 = new Driver("Lucy", 1);

            // Creating helper objects for validation
            Car selectedCar1 = new Car();
            Driver selectedDriver1 = new Driver();
            Car selectedCar2 = new Car();
            Driver selectedDriver2 = new Driver();

            // Infinite loop for repeating the process while the user presses Y to do the race again
            do
            {
                Console.WriteLine("Please select the first car for the race.(enter 1, 2, 3 or 4)");
                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            selectedCar1 = car1;
                            break;
                        case "2":
                            selectedCar1 = car2;
                            break;
                        case "3":
                            selectedCar1 = car3;
                            break;
                        case "4":
                            selectedCar1 = car4;
                            break;
                        default:
                            Console.WriteLine("There is no such a car! Please try again!");
                            continue;
                    }
                    break;
                }

                Console.WriteLine("Please select the first driver for the race.(enter 1, 2, 3 or 4)");
                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            selectedDriver1 = driver1;
                            break;
                        case "2":
                            selectedDriver1 = driver2;
                            break;
                        case "3":
                            selectedDriver1 = driver3;
                            break;
                        case "4":
                            selectedDriver1 = driver4;
                            break;
                        default:
                            Console.WriteLine("There is no such a driver! Please try again!");
                            continue;
                    }
                    break;
                }


                Console.WriteLine("Please select the second car for the race.(Make sure it's not the same as the first car!)");
                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (selectedCar1 != car1) // Bonus 1 Excluding the option that was chosen for the other car
                            {
                                selectedCar2 = car1;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same car! Please try again!");
                                continue;
                            }
                        case "2":
                            if (selectedCar1 != car2)
                            {
                                selectedCar2 = car2;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same car! Please try again!");
                                continue;
                            }
                        case "3":
                            if (selectedCar1 != car3)
                            {
                                selectedCar2 = car3;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same car! Please try again!");
                                continue;
                            }
                        case "4":
                            if (selectedCar1 != car4)
                            {
                                selectedCar2 = car4;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same car! Please try again!");
                                continue;
                            }
                        default:
                            Console.WriteLine("There is no such a car! Please try again!");
                            continue;
                    }
                    break;
                }


                Console.WriteLine("Please select the second driver for the race.(Make sure it's not the same as the first driver)");

                while (true)
                {
                    switch (Console.ReadLine())
                    {
                        case "1":
                            if (selectedDriver1 != driver1) // Bonus 1 Excluding the option that was chosen for the other driver
                            {
                                selectedDriver2 = driver1;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same driver! Please try again!");
                                continue;
                            }
                        case "2":
                            if (selectedDriver1 != driver2)
                            {
                                selectedDriver2 = driver2;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same driver! Please try again!");
                                continue;
                            }
                        case "3":
                            if (selectedDriver1 != driver3)
                            {
                                selectedDriver2 = driver3;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same driver! Please try again!");
                                continue;
                            }
                        case "4":
                            if (selectedDriver1 != driver4)
                            {
                                selectedDriver2 = driver4;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose the same driver! Please try again!");
                                continue;
                            }
                        default:
                            Console.WriteLine("There is no such a driver! Please try again!");
                            continue;

                    }
                    break;
                }
                
                // Invoking the method RaceCars and passing the selected inputs as arguments
                RaceCars(selectedCar1, selectedDriver1, selectedCar2, selectedDriver2);

                // Bonus 3 Implementing Race Again Feature
                Console.WriteLine("It was fun, isn't it? :) Press \"Y\" if you are ready for another race, otherwise press any key!");
                string newRace = Console.ReadLine();
                if(newRace.ToUpper() != "Y")
                {
                    break;
                }
                continue;
                
            } while (true);  
        }

        static void RaceCars(Car firstCar, Driver firstDriver, Car secondCar, Driver secondDriver)
        {
            int speed1 = firstCar.CalculateSpeed(firstDriver);
            int speed2 = secondCar.CalculateSpeed(secondDriver);

            if (speed1 > speed2)
            {   // Bonus 2 Descriptive output message
                Console.WriteLine($"The car {firstCar.Model}, driven by {firstDriver.Name} with speed of {speed1}km/h won the race!");
            }
            else if (speed1 < speed2)
            {
                Console.WriteLine($"The car {secondCar.Model}, driven by {secondDriver.Name} with speed of {speed2}km/h won the race!");
            }
            else
            {
                Console.WriteLine("The speed of both cars was even in this race, therefor we don't have a winner!");
            }
        }

    }
}