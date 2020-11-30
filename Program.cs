using System;

namespace _05.tutorial
{
    class ProgramConstants
    {

        public const double PI = 3.1415926535897932385;
        public readonly double Size;  //readonly variable, its value can not be changed, it is read only
        public ProgramConstants(int size) //Constructor
        {
            this.Size = size; // Can not be further modified! 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ProgramConstants.PI);
            ProgramConstants c = new ProgramConstants(10);
            Console.WriteLine(c.Size);


        }
    }
}
