using System;

//Emil SUT22
namespace Class_Arv_Labb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lejon Lion1 = new Lejon(10,"Gul","M",200,1,1);
            Lion1.getInfo();
            Lion1.makeSound();
            Lion1.seeAnimal();
            Lion1.checkWeight();
            Lion1.checkEnclosure();

            Zebra Zebra1 = new Zebra(10, "Svart och vit", "F", 60, 4,4);
            Zebra1.makeSound();
            Zebra1.checkStripes();

            Fisk Fish1 = new Fisk(3, "Guldig", "M", 33, 7,3);
            Fish1.makeSound();
            Fish1.checkLength();

            Haj Shark1 = new Haj(33, "Mörk blå", "F", 460, 7, 220,1);
            Shark1.makeSound();
            Shark1.checkTeeth();
            Shark1.checkTeeth();

            Lax Salmon1 = new Lax(11, "Blå, vit och rosa", "F", 100, 6, 0.7m,1);
            Salmon1.makeSound();
            Salmon1.checkSpeed();

        }
    }
    //Animal class
    public class Djur
    {
        public int age=default;
        public int id = default;
        public string species=default;
        public string colour=default;
        public string gender = default;
        public string sound = default;
        public int enclosure = default;

        public Djur()
        {
            age = 0;
            id = 0;
            species = "None";
            colour = "None";
            gender = "None";
            sound = "None";
            enclosure = 0;
        }


        public virtual void makeSound() { }

        public void getInfo()
        {
            Console.WriteLine($"Art: {species} {id}\nFärg: {colour}\nKön: {gender}\nÅlder: {age}år\n");
        }

        public void seeAnimal()
        {
            Console.WriteLine($"Ser ut som ett {species} {id} som har färgen {colour}.\n");
        }
        public void checkEnclosure()
        {
            Console.WriteLine($"{species} {id} är i inhägnad {enclosure}.\n");
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
        public Lejon(int _age,string _colour,string _gender,int _weight,int _enclosure,int _id)
        {
            age = _age;
            id= _id;
            colour = _colour;
            gender = _gender;
            weight = _weight;
            enclosure=_enclosure;
            species = "Lejon";
            sound = "Roar";
        }
        public override void makeSound()
        {
            Console.WriteLine($"{species} {id} gör ljudet {sound}\n");
        }
        public void checkWeight()
        {
            if (weight > 200)
            {
                Console.WriteLine($"{species} {id} är övervigtig på {weight}kg\n");
            }
            else if(weight < 100)
            {
                Console.WriteLine($"{species} {id} är underviktig {weight}kg\n");
            }
            else
            {
                Console.WriteLine($"{species} {id} väger {weight}kg\n");
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
        public Fisk(int _age, string _colour, string _gender, int _length, int _enclosure, int _id)
        {
            age = _age;
            id = _id;
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
                Console.WriteLine($"Stora {species} {id} är {length}cm lång.\n");
            }
            else
            {
                Console.WriteLine($"{species} {id} är {length}cm lång\n");
            }
        }
        public override void makeSound()
        {
            Console.WriteLine($"{species} {id} gör ljudet {sound} i vatten\n");
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
        public Haj(int _age, string _colour, string _gender, int _length, int _enclosure,int _teeth, int _id)
        {
            age = _age;
            id= _id;
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
                Console.WriteLine($"{species} {id} har {teeth} tänder.\n");
            }
            else
            {
                Console.WriteLine($"{species} {id} har {teeth} tänder. Mindre en vanligt\n");
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
        public Lax(int _age, string _colour, string _gender, int _length, int _enclosure, decimal _speed, int _id)
        {
            age = _age;
            id = _id;
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
                Console.WriteLine($"{species} {id} har maxhastigheten {speed}m/s.\n");
            }
            else
            {
                Console.WriteLine($"{species} {id} har en hög maxhastighet på {speed}m/s\n");
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
        public Zebra(int _age, string _colour, string _gender, int _stripes, int _enclosure,int _id)
        {
            age = _age;
            id= _id;
            colour = _colour;
            gender = _gender;
            stripes = _stripes;
            enclosure = _enclosure;
            species = "Zebra";
            sound = "Bark";
        }
        public override void makeSound()
        {
            Console.WriteLine($"{species} {id} gör ljudet {sound}\n");
        }
        public void checkStripes()
        {
            if (stripes > 50)
            {
                Console.WriteLine($"{species} {id} har {stripes} ränder vilket är mer en vanligt.\n");
            }
            else if (stripes < 30)
            {
                Console.WriteLine($"{species} {id} har {stripes} ränder vilket inte är så många.\n");
            }
            else
            {
                Console.WriteLine($"{species} {id} har {stripes} ränder\n");
            }
        }
    }
}
