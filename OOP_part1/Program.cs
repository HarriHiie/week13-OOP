using System;

namespace OOP_part1
{
    class Dog
    {
        //class fields
        public string name;
        public int spots;
        public double happiness;





        static void Main(string _name, int _spots) //constructur
        {
            name = _name;
            spots = _spots
            happiness = 0;
            Console.WriteLine($"The Dog {name} has been created");
        }
    }

    static void Main(string[] args)
    {
        Dog myDog = new Dog("koer", 15);
        Console.WriteLine($"{myDog.name}'s level of happiness: {myDog.happiness}");
        Dog myDog = new Dog("Dog"), 2);



    } }
