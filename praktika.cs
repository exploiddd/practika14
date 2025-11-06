using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp8.Message;

namespace ConsoleApp8
{
    //задание 1
    public class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Играет музыка...");
        }
    }
    public class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Брень-брень!");
        }
    }
    public class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Бум-бум!");
        }
    }

    //задание 2
    public class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено.");
        }
    }
    public class Email : Message
    {
        public override void Send()
        {
            Console.WriteLine("Email отправлен!");
        }
    }
    public class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS отправлено!");
        }
    }

    //задание 3
    public class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    public class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }
    public class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }

    //задание 4
    public abstract class Shape
    {
        public abstract string Draw();
    }
    public class Circle : Shape
    {
        public override string Draw()
        {
            return "Рисую круг";
        }
    }
    public class Triangle : Shape
    {
        public override string Draw()
        {
            return "Рисую треугольник";
        }
    }

    //задание 5
    public class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }
    public class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }
    public class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //вывод 1
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };

            foreach (var i in band)
            {
                i.Play();
            }
            Console.WriteLine();

            //вывод 2
            Message[] messages = { new Email(), new SMS(), new Message() };
            
            foreach (var m in messages)
            {
                m.Send();
            }
            Console.WriteLine();

            //вывод 3
            Food[] lunch = { new Pizza(), new Burger(), new Food() };

            foreach (var f in lunch)
            {
                f.Eat();
            }
            Console.WriteLine();

            //вывод 4
            Shape[] shapes = { new Circle(), new Triangle() };

            foreach (var s in shapes)
            {
                Console.WriteLine(s.Draw());
            }
            Console.WriteLine();

            //вывод 5
            Player[] team = { new Warrior(), new Archer(), new Player() };

            foreach (var p in team)
            {
                p.Attack();
            }
        }
    }
}