using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    abstract class Animal
    {
        public abstract void Eat();
        public abstract void Breathe();
    }
    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat is eating fish.");
        }

        public override void Breathe()
        {
            Console.WriteLine("Cat is breathing.");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating meat.");
        }

        public override void Breathe()
        {
            Console.WriteLine("Dog is breathing.");
        }
    }
    abstract class Game
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public Game(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }

        public abstract void Start();
        public abstract void Stop();
    }

    class Strategy : Game
    {
        public int NumberOfUnits { get; set; }

        public Strategy(string title, int numberOfUnits) : base(title, "Стратегия")
        {
            NumberOfUnits = numberOfUnits;
        }

        public override void Start()
        {
            Console.WriteLine($"Начинается стратегическая игра '{Title}' с {NumberOfUnits} юнитами.");
        }

        public override void Stop()
        {
            Console.WriteLine($"Игра '{Title}' окончена.");
        }
    }

    class Shooter : Game
    {
        public int NumberOfWeapons { get; set; }

        public Shooter(string title, int numberOfWeapons) : base(title, "Шутер")
        {
            NumberOfWeapons = numberOfWeapons;
        }

        public override void Start()
        {
            Console.WriteLine($"Начинается шутер '{Title}' с {NumberOfWeapons} видами оружия.");
        }

        public override void Stop()
        {
            Console.WriteLine($"Игра '{Title}' окончена.");
        }
    }

    class Simulator : Game
    {
        public string SimulationType { get; set; }

        public Simulator(string title, string simulationType) : base(title, "Симулятор")
        {
            SimulationType = simulationType;
        }

        public override void Start()
        {
            Console.WriteLine($"Начинается симулятор '{Title}' типа {SimulationType}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"Игра '{Title}' окончена.");
        }
    }
    class Program
    {
        static void Main()
        {
            Animal myCat = new Cat();
            Animal myDog = new Dog();

            myCat.Eat();
            myCat.Breathe();

            myDog.Eat();
            myDog.Breathe();

            Game myStrategy = new Strategy("Age of Empires", 50);
            Game myShooter = new Shooter("Call of Duty", 20);
            Game mySimulator = new Simulator("Flight Simulator", "Flight");

            myStrategy.Start();
            myStrategy.Stop();

            myShooter.Start();
            myShooter.Stop();

            mySimulator.Start();
            mySimulator.Stop();
        }
    }
}
