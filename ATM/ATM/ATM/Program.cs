namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Array of objects, where the Customer-objects are or will be stored
            Customer[] customers = new Customer[3];

            // Creating 3 Customer objects and placing them on a particular index of the array of customers
            customers[0] = new Customer("Frosina", "Stamenkovska", 1111222233334444, "1111");
            customers[1] = new Customer("Bob", "Bobski", 1234123412341234, "1234");
            customers[2] = new Customer("John", "Doe", 1111111111111111, "2222");

            // Adding cash deposit to each customer and checking their balance before cash deposition
            customers[0].BalanceChecking();
            customers[0].CachDeposition(1000);

            customers[1].BalanceChecking();
            customers[1].CachDeposition(1500);

            customers[2].BalanceChecking();
            customers[2].CachDeposition(500);

            

            do // Infinite Loop to repeating the process for every next client
            {
                Console.WriteLine("Welcome to ATM app!");
                Customer currentCustomer = null; // creating a helper object to store the info for the chosen client
                int enterPinAttempts = 3; // setting a variable  for 3 pin code attempts

                while (currentCustomer == null) // cannot  exit the loop until a client is assigned
                {
                    Console.WriteLine("Please enter your card number! (Make sure it's in the following format: 0000-0000-0000-0000 )");
                    string cardInput = Console.ReadLine();

                    // converting the input to number and replacing the "-" with empty string
                    bool successfulParsing = long.TryParse(cardInput.Replace("-", ""), out long cardNumber );
                    
                    // a validation if the user do not enter a valid number or if the number is not with 16 digits
                    if (!successfulParsing || cardNumber.ToString().Length != 16)
                    {
                        Console.WriteLine("You have entered an invalid card number!, Please try again!");
                        continue;
                    }

                    bool customerExists = false;

                    foreach (Customer customer in customers)
                    {
                        if (customer.CardNumber == cardNumber)
                        {
                            currentCustomer = customer; // if the card numbers exists in the system, asigning that customer to the currentCustomer object
                            customerExists = true;
                        }
                    }


                    if (customerExists) // if the customer exists checking his pin code
                    {
                        while (enterPinAttempts > 0)
                        {
                            Console.WriteLine("Please enter your pin code!");
                            if (!currentCustomer.CorrectPin(Console.ReadLine())) // If the pin is incorrect the user has 2 more attempts
                            {
                                Console.WriteLine("Wrong Pin Code!");
                                enterPinAttempts --;
                                continue;
                            }
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The card number does not exist in our system! \nPress 1 to try again, or press 2 to register a new card!");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                break; // By pressing 1 the user will be given a chance to try to enter the card number again
                            case "2": // The user can register (we are already sure that the card number doesn't exist in our system)
                                string firstName = null;
                                string lastName = null;
                                string pinCode = null;

                                // If the validations for inputs are not passed, the user cannot exit the loop until the valid input is inserted
                                while (true)
                                {
                                    Console.WriteLine("Please enter your first name:");
                                    firstName = Console.ReadLine();
                                    if (firstName.Length < 2 || Customer.OnlyLetters(firstName) == false)
                                    {
                                        Console.WriteLine("Invalid first name! Make sure you are using only letters! ");
                                        continue;
                                    }
                                    break;
                                }

                                while (true)
                                {
                                    Console.WriteLine("Please enter your last name:");
                                    lastName = Console.ReadLine();
                                    if (lastName.Length < 2 || Customer.OnlyLetters(lastName) == false)
                                    {
                                        Console.WriteLine("Invalid last name! Make sure you are using only letters!");
                                        continue;
                                    }
                                    break;
                                }

                                while (true)
                                {
                                    Console.WriteLine("Please enter your pin code (needs to be with 4 digits):");
                                    pinCode = Console.ReadLine();
                                    if (pinCode.Length != 4 || !int.TryParse(pinCode, out int parsedPin))
                                    {
                                        Console.WriteLine("Invalid Pin Code! Make sure you are using only numbers!");
                                        continue;
                                    }
                                    break;
                                }
                                
                                // After validations the new customer is added in the system and is assigned to the currentCustomer object
                                Customer newCustomer = new Customer(firstName, lastName, cardNumber, pinCode);
                                Array.Resize(ref customers, customers.Length + 1);
                                customers[customers.Length - 1] = newCustomer;

                                currentCustomer = newCustomer;
                                break;

                            default:
                                Console.WriteLine("Invalid input, please choose 1 or 2!");
                                continue;
                        }
                    }

                    if (enterPinAttempts == 0) // If there are 3 incorrect pin attempts the loop is exited and the customer cannot continue
                    {
                        Console.WriteLine("Your Card has been blocked after 3 incorrect pin attempts! Please contact your bank.");
                        break;
                    }
                }

                currentCustomer.GreetingMessage(); // At this point we can finally greet our Customer :)

                while (true)
                {
                    int amount = 0; // a variable where the result from the input will be stored and ready for transactions
                    Console.WriteLine("Please choose one of the following options: \n1 - Balance checking \n2 - Cash withdrawal \n3 - Cash deposition");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine($"Your current balance is: {currentCustomer.BalanceChecking():C}");
                            break;
                        case "2":
                            if(currentCustomer.BalanceChecking() == 0)
                            {
                                Console.WriteLine("This option is not available due to not having funds on your account!  #YouAreBroke :))) ");
                                break;
                            }

                            Console.WriteLine("Please enter an amount that you would like to withdraw.");
                            while (true)
                            {
                                if (!int.TryParse(Console.ReadLine(), out amount))
                                {
                                    Console.WriteLine("Wrong input! Please try again!");
                                    continue;
                                }

                                if (currentCustomer.BalanceChecking() >= amount)
                                {
                                    currentCustomer.CashWithdrawal(amount);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough funds on your account to complete the transaction, please try with lower amount!");
                                    continue;
                                }
                            }
                            break;
                        case "3":
                            Console.WriteLine("Please enter an amount that you would like to deposit.");
                            while (true)
                            {
                                if (!int.TryParse(Console.ReadLine(), out amount) || amount < 0) // validation if the input is not a number or is a negative number
                                {
                                    Console.WriteLine("Wrong input! Please try again!");
                                    continue;
                                }
                                currentCustomer.CachDeposition(amount);
                                break;
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong input, please choose 1, 2, or 3!");
                            continue;

                    }

                    // Giving an option to the customer to do another transaction or to exit
                    Console.WriteLine("If you want to do another transaction press Y, otherwise press any key!");
                    if(Console.ReadLine().ToUpper() != "Y")
                    {
                        Console.WriteLine("Have a nice day, Goodbye! \n");
                        break;
                    }
                    continue;
                }
            } while (true);
            
        }
        

    }
}