using System;

namespace Задание_1
{
    class Program
    {
        static void Main (string[] args)
        {
            Cat murzik = new Cat("Мурзик");
            Cat barsik = new Cat("Барсег");
            murzik.Meow();
            barsik.Meow();
            barsik.Name = "Барсик";
            barsik.Meow();
            barsik.Name = "1234";
            barsik.Meow();

            barsik.Weight = 100;
            murzik.Weight = -15;
            barsik.Weight = 10;
            murzik.Weight = 15;

            Console.WriteLine($"Вес Барсика {barsik.Weight}");
            Console.WriteLine($"Вес Мурзика {murzik.Weight}");

            Console.ReadKey();
        }
    }
}
