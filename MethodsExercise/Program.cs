namespace MethodsExercise
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            var add = num1 + num2;
            return add;
        }

        public static int Subtract(int num1, int num2)
        {
            var subtract = num1 - num2;
            return subtract;
        }

        public static int Multiply(int num1, int num2)
        {
            var multiply = num1 * num2;
            return multiply;
        }

        public static int Divide(int num1, int num2)
        {
            var divide = num1 / num2;
            return divide;
        }

        public static int Modulus(int num1, int num2)
        {
            var modulus = num1 % num2;
            return modulus;
        }
        static void Main(string[] args)
        {
            //-------------Exercise 1-------------
            Console.WriteLine("-----Exercise 1-----");
            Console.WriteLine();

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile.");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Band: {band}");


            //-------------Exercise 2--------------
            Console.WriteLine("-----Exercise 2-----");
            Console.WriteLine();

            Console.Write("Add: ");
            var amountOfCars = Add(2, 6);
            Console.Write(amountOfCars);
            Console.WriteLine();

            Console.Write("Subtract: ");
            var amountOfPhones = Subtract(7, 5);
            Console.Write(amountOfPhones);
            Console.WriteLine();

            Console.Write("Multiply: ");
            var amountOfGenes = Multiply(3, 4);
            Console.Write(amountOfGenes);
            Console.WriteLine();

            Console.Write("Divide: ");
            var slicesOfPizzaPerPerson = Divide(20, 10);
            Console.Write(slicesOfPizzaPerPerson);
            Console.WriteLine();

            Console.Write("Modulus: ");
            var sodasRemaining = Modulus(15, 9);
            Console.Write(sodasRemaining);
        }
    }
}
