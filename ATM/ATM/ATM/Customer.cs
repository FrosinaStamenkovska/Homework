namespace ATM
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private int Balance { get; set; }
        private string PinCode { get; set; }

        public Customer(string firstName, string lastName, long cardNumber, string pinCode)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            PinCode = pinCode;
            Balance = 0;
        }

        public void GreetingMessage()
        {
            Console.WriteLine($"Welcome {FirstName} {LastName}!");
        }

        public bool CorrectPin(string pinCode)
        {
            return PinCode == pinCode;
        }

        public static bool OnlyLetters(string input)
        {
            bool result = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    result = false;
                } 
            };
            return result;
        }

        public int BalanceChecking()
        {
            return Balance;
        }

        public void CashWithdrawal(int amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"You have successfuly withdrawn {amount:C}. \nYou have {Balance:C} left on your account!");
            }
        }

        public void CachDeposition(int amount)
        {
            if (amount >= 0)
            {
                Balance += amount;
                Console.WriteLine($"You have successfuly deposited {amount:C}. \nYour new balance is {Balance:C}");
            }
        }
    }
}
