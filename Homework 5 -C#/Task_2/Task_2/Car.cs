namespace Task_2
{
    internal class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        public Car() 
        { 

        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver driver)
        {
            Driver = driver.Name;
            return Speed * driver.Level;
        }
    }
}
