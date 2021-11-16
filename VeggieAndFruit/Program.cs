using System;
using System.IO;

namespace VeggieAndFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitpath = @"C: \Users\opilane\samples\fruit.txt";
            string[] VeggieData = File.ReadAllLines(fruitpath);
            string veggiepath = @"C: \Users\opilane\samples\veggie.txt";
            string[] FruitData = File.ReadAllLines(veggiepath);
            File.WriteAllLines(fruitpath, FruitData);
            File.WriteAllLines(veggiepath, VeggieData);
        }
    }
}
