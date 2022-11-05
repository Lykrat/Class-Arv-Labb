using System;
using static System.Net.Mime.MediaTypeNames;

namespace Class_Arv_Labb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lejon Lion1 = new Lejon(10,"Gul","M",200,1);
            Lion1.getInfo();
            Lion1.makeSound();
            Lion1.seeAnimal();
            Lion1.checkWeight();
            Lion1.checkEnclosure();

            Zebra Zebra1 = new Zebra(10, "Svart och vit", "F", 60, 4);
            Zebra1.makeSound();

            Fisk Fish1 = new Fisk(3, "Guldig", "M", 33, 7);
            Fish1.makeSound();

            Haj Shark1 = new Haj(33, "Mörk blå", "F", 460, 7, 220);
            Shark1.makeSound();

            Lax Salmon1 = new Lax(11, "Blå, vit och rosa", "F", 100, 6, 0.7m);
            Salmon1.makeSound();

        }
    }
    //Animal class
    public class Djur
    {
        public int age=default;
        public string species=default;
        public string colour=default;
        public string gender = default;
        public string sound = default;
        public int enclosure = default;

        public Djur()
        {
            age = 0;
            species = "None";
            colour = "None";
            gender = "None";
            sound = "None";
            enclosure = 0;
        }


        public virtual void makeSound() { }

        public void getInfo()
        {
            Console.WriteLine($"Art: {species}\nFärg: {colour}\nKön: {gender}\nÅlder: {age}år\n");
        }

        public void seeAnimal()
        {
            Console.WriteLine($"Ser ut som ett {species} som har färgen {colour}.\n");
        }
        public void checkEnclosure()
        {
            Console.WriteLine($"{species} är i inhägnad {enclosure}.\n");
        }
    }
    //Child class lion
    public class Lejon : Djur
    {
        public int weight = default;

        public Lejon()
        {
            weight = 0;
            species = "Lejon";
            sound = "Roar";
        }
        public Lejon(int _age,string _colour,string _gender,int _weight,int _enclosure)
        {
            age = _age;
            colour = _colour;
            gender = _gender;
            weight = _weight;
            enclosure=_enclosure;
            species = "Lejon";
            sound = "Roar";
        }
        public override void makeSound()
        {
            Console.WriteLine($"{species} gör ljudet {sound}\n");
        }
        public void checkWeight()
        {
            if (weight > 200)
            {
                Console.WriteLine($"{species} är övervigtig på {weight}kg\n");
            }
            else if(weight < 100)
            {
                Console.WriteLine($"{species} är underviktig {weight}kg\n");
            }
            else
            {
                Console.WriteLine($"{species} väger {weight}kg\n");
            }
        }

    }
    //Child class fish
    public class Fisk : Djur
    {
        public int length;

        public Fisk()
        {
            length = 0;
            species = "Fisk";
            sound = "blub blub";
        }
        public Fisk(int _age, string _colour, string _gender, int _length, int _enclosure)
        {
            age = _age;
            colour = _colour;
            gender = _gender;
            length = _length;
            enclosure = _enclosure;
            species = "Fisk";
            sound = "blub blub";
        }
        public void checkLength()
        {
            if (length > 50)
            {
                Console.WriteLine($"Stora {species} är {length}cm lång.");
            }
            else
            {
                Console.WriteLine($"{species} är {length}cm lång");
            }
        }
        public override void makeSound()
        {
            Console.WriteLine($"{species} gör ljudet {sound} i vatten\n");
        }
    }
    //Double child class shark
    public class Haj : Fisk
    {
        public int teeth;

        public Haj()
        {
            species = "Haj";
            sound = "blob";
            teeth = 0;
        }
        public Haj(int _age, string _colour, string _gender, int _length, int _enclosure,int _teeth)
        {
            age = _age;
            colour = _colour;
            gender = _gender;
            length = _length;
            enclosure = _enclosure;
            teeth = _teeth;
            species = "Haj";
            sound = "blob";
        }
        public void checkTeeth()
        {
            if (teeth < 220)
            {
                Console.WriteLine($"{species} har {teeth} tänder.");
            }
            else
            {
                Console.WriteLine($"{species} har {teeth} tänder. Mindre en vanligt");
            }
        }
    }
    //Double child class salmon
    public class Lax : Fisk
    {
        public decimal speed;

        public Lax()
        {
            species = "Lax";
            sound = "blob blub";
            speed = 0;
        }
        public Lax(int _age, string _colour, string _gender, int _length, int _enclosure, decimal _speed)
        {
            age = _age;
            colour = _colour;
            gender = _gender;
            length = _length;
            enclosure = _enclosure;
            speed = _speed;
            species = "Lax";
            sound = "blob blub";
        }
        public void checkSpeed()
        {
            if (speed < 0.5m)
            {
                Console.WriteLine($"{species} har maxhastigheten {speed}m/s.");
            }
            else
            {
                Console.WriteLine($"{species} har en hög maxhastighet på {speed}m/s");
            }
        }
    }
    //Child class zebra
    public class Zebra : Djur
    {
        public int stripes;

        public Zebra()
        {
            stripes = 0;
            species = "Zebra";
            sound = "Bark";
        }
        public Zebra(int _age, string _colour, string _gender, int _stripes, int _enclosure)
        {
            age = _age;
            colour = _colour;
            gender = _gender;
            stripes = _stripes;
            enclosure = _enclosure;
            species = "Zebra";
            sound = "Bark";
        }
        public override void makeSound()
        {
            Console.WriteLine($"{species} gör ljudet {sound}\n");
        }
        public void checkStripes()
        {
            if (stripes > 50)
            {
                Console.WriteLine($"{species} har {stripes} ränder vilket är mer en vanligt.");
            }
            else if (stripes < 30)
            {
                Console.WriteLine($"{species} har {stripes} ränder vilket inte är så många.");
            }
            else
            {
                Console.WriteLine($"{species} har {stripes} ränder");
            }
        }
    }
}
