using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_Наследование_30._10._22г
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cats cat = new Cats();
            cat.Gender = "Кот";
            cat.Breed = "Вислоухий";
            cat.Color = "Серый";
            cat.Age = 2;
            Console.WriteLine(cat.Display());
            Console.WriteLine(cat.Display2());
            cat.Print();
            Console.ReadKey();
        }
    }
    public class Zoomagazin
    {
        public Zoomagazin(string gender, string breed, string color, byte age)
        {
            this.Gender = gender;
            this.Breed = breed;
            this.Color = color;
            this.Age = age;
        }

        public Zoomagazin() { }
        public string Gender { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public byte Age { get; set; }

        public string Display()
        {
            return $"Животное: {Gender}";
        }
        public string Display2()
        {
            return $"Пол: {Gender}, Порода: {Breed}, Возраст: {Age}";
        }
    }
    public class Cats : Zoomagazin
    {
        public void Print()
        {
            Console.WriteLine("Все животные домашние и абсолютно здоровые!");
        }
    }
}
