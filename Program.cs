namespace Practice_Constructors_Methods_Overloading_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Practice: Constructors, Methods, and Overloading
        // 01/28/2024
        static void Main(string[] args)
        {
            // Code Test
            Car defaultCar = new Car();
            Car makeModelCar = new Car("Toyota", "Rav4");
            Car fullCar = new Car("Hyundai", "Sonata", 2010, 100000);

            // Display
            Console.WriteLine(defaultCar);
            Console.WriteLine(makeModelCar);
            Console.WriteLine(fullCar);
        }
    }
}