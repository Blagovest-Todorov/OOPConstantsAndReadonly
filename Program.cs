using System;

namespace _02.SimpleClassDefinition
{

    class Cat
    {
        public string name;
    }

    internal class Person
    {
        private string name;
        private int age;



        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

          //cosnt can not be static ! 
        public const int MinAge = 0; //defining a constant -compile type;//cosnt can not be changed the value of it
        public const int MaxAge = age + 150;//at compile time the values of teh constatns are replacing into the code

        
        public int Age                  //at Compilation, MinAge -> 0; MaxAge -> 150 //replacing with value
        {
            get
            {
                return this.age;
            }
            set
            {
                int newAge = value;
                if (newAge < MinAge || newAge > MaxAge)
                {
                    throw new ArgumentOutOfRangeException("The value must be between 0 and 200 ");
                }
                this.age = value;
            }

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    this.name = value;
                }
            }
        }

        public void Introduce()
        {
            Console.WriteLine("Hello! , my name is {0} and i am  {1}-years-old.", this.name, this.age);
        }

        public void Walk()
        {
            Console.WriteLine("{0} is walking !", this.Name);
        }

    }

    class LearningOOP
    {
        static void Main(string[] args)
        {

        }
    }
}   



