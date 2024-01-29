using System.Security.Principal;

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

            BankAccount account = new BankAccount("12345", "Will Cram", 20);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $20.00
            account.Deposit(500);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $520.00
            account.Deposit(-15000);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $520.00
            account.Withdraw(300);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $220.00
            account.Withdraw(-500);
            Console.WriteLine(account); // 12345 - Will Cram - Current Balance: $220.00
        }


    }
}// Done