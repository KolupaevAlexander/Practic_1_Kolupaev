using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Cat
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                } else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        private double weight;
        public double Weight 
        {
            get { return weight; } 
            set 
            {
                if (value > 0 && value < 20)
                    weight = value;
                else
                    Console.WriteLine("Вес кота за рамками возможного");
            } 
        }
        public Cat (string CatName)
        {
            name = CatName;
        }

        public void Meow ()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }

        public void SetCatName (string CatName)
        {

            bool OnlyLetters = true;

            foreach (var ch in CatName)
            {
                if (!char.IsLetter(ch))
                {
                    OnlyLetters = false;
                }
            }

            if (OnlyLetters)
                name = CatName;
            else
                Console.WriteLine($"{CatName} - неправильное имя!!!");
        }
    }
}
