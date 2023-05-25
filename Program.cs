using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // Additional task 1
    enum CatFood
    {
        Fish = 1,
        Mouse = 2,
        Chicken = 3,
        Cheese = 4
    }
    abstract class Animal
    {
        public abstract int FullnessLevel { get; set; }
        public abstract void EatSomething();
        public abstract void ShowFood();
        public abstract void Satiety();
    }

    class Cat:Animal
    {
        private int fulnessLevel;
        CatFood food;
        public override int FullnessLevel
        {
            get => fulnessLevel;
            set => fulnessLevel = value;
        }

        public override void ShowFood()
        {
            List<CatFood> catfood = Enum.GetValues(typeof(CatFood)).Cast<CatFood>().ToList();
            Console.WriteLine("Food available: \n" + String.Join(Environment.NewLine, catfood));
        }

        public override void EatSomething()
        {
            Console.WriteLine("Select the type of food you would like to feed your pet: 1-4");
            food = (CatFood)int.Parse(Console.ReadLine());

        }
        public override void Satiety()
        {

            switch (food)
            {
                case CatFood.Fish:
                    fulnessLevel = 70;
                    Console.WriteLine("You selected: " + $"{CatFood.Fish} {fulnessLevel}"+"% satiety");
                    break;
                case CatFood.Mouse:
                    fulnessLevel = 50;
                    Console.WriteLine("You selected: " + $"{CatFood.Mouse} {fulnessLevel}"+"% satiety");
                    break;
                case CatFood.Chicken:
                    fulnessLevel = 100;
                    Console.WriteLine("You selected: " + $"{CatFood.Chicken} {fulnessLevel}"+"% satiety");
                    break;
                case CatFood.Cheese:
                    fulnessLevel = 30;
                    Console.WriteLine("You selected: " + $"{CatFood.Cheese} {fulnessLevel}"+"% satiety");
                    break;
            }
        }
    }

    //Homework task 1
    class Task1
    {
        public int number1;
        public int number2;
        public int number3;
        const  int minRange = -5;
        const  int maxRange = 5;

        public Task1(int numberFirst, int numberSecond, int numberThird)
        {
            number1 = numberFirst;
            number2 = numberSecond;
            number3 = numberThird;
        }

        public void CheckTheRange()
        {
            int[] numbers = new int[3] { number1, number2, number3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= minRange && numbers[i] <= maxRange)
                {
                    Console.WriteLine("You are in the range");
                }
                else Console.WriteLine("Unlucky range:)");
            }
        }
    }

    //Homework task 2
    class Task2
    {
        private int number1 { get; set; }
        private int number2 { get; set; }
        private int number3 { get; set; }

        public int Number1
        {
            get => number1;
            set => number1 = value;
        }
        public int Number2
        {
            get => number2;
            set => number2 = value;
        }
        public int Number3
        {
            get => number3;
            set => number3 = value;
        }

        public void Initialization()
        {
            Console.WriteLine("Please type the first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type the second number");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type the third number");
            number3 = int.Parse(Console.ReadLine());
        }
        public void MinMaxValue()
        {
            int[] Count = new int[3] { number1, number2, number3 };
            int minValue = Count[0];
            int maxValue = Count[0];
            for(int i = 0; i<Count.Length; i++)
            {
                if (Count[i] > maxValue)
                {
                    maxValue = Count[i];
                }
                else if (Count[i] < minValue)
                {
                    minValue = Count[i];
                }
            }
            Console.WriteLine("MinValue = "+$"{minValue}" + " " + "MaxValue = " + $"{maxValue}");
        }
    }

    //Homework task 3
    enum HTTPError
    {
        OK = 200,
        Created = 201,
        Accepted = 202,
        NoContent = 203
    }

    class Task3
    {
        int code { get; set; }
        string status;
        public int Code
        {
            get => code; 
            set => code = value;
        }
        public void StatusDetail()
        {
            Console.WriteLine("Please type the code you would like to get info: 200, 201, 202, 203");
            code = int.Parse(Console.ReadLine());
            status = Enum.GetName(typeof(HTTPError), code);
            Console.WriteLine("The status is: "+ " " + $"{status}");
        }
    }

    //Homework task 4
    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return $"{ name }, { mark }, { age }";

        }
    }

    class Task4
    {
        Dog dog;
        public void Initialization()
        {
            Console.WriteLine("Please indicate the name: ");
            dog.name = Console.ReadLine();
            Console.WriteLine("Please indicate the mark: ");
            dog.mark = Console.ReadLine();
            Console.WriteLine("Please indicate the age: ");
            dog.age = int.Parse(Console.ReadLine());

        }

        public void Show()
        {
            Console.WriteLine(dog);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Additional task 1
            Cat cat = new Cat();
            cat.ShowFood();
            cat.EatSomething();
            cat.Satiety();

             //Homework task 1
            Task1 task1 = new Task1(3, 5, 7);
            task1.CheckTheRange();

            //Homework task 2
            Task2 task2 = new Task2();
            task2.Initialization();
            task2.MinMaxValue();

            //Homework task 3
            Task3 task3 = new Task3();
            task3.StatusDetail();

            //Homework task 4
            Task4 task4 = new Task4();
            task4.Initialization();
            task4.Show();
           
            Console.ReadKey();

        }
    }
}
