
using System;
using System.Collections.Generic;
using System.Text;

namespace Chen_P2
{
    class Fish
    {
        //protected fields
        protected Random myRand;
        protected string name;
        protected string shape;
        protected double price;
        protected ConsoleColor color;

        //properties
        //name property
        public string Name
        {
            get { return name; }
        }

        //price property
        public double Price
        {
            get { return price; }
        }

        //constructor
        public Fish(Random _myRand)
        {
            //initialize random object
            myRand = _myRand;

            //initialize name with random number
            int number = myRand.Next(1, 101);            
            name = number.ToString();

            //initialize shape and price
            shape = " <C>< ";
            price = 5;

            //initialize color by random
            int colorNumber = myRand.Next(0, 16);
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));     
            color = colors[colorNumber];
        }

        //method MeInWater
        //two int parameters
        //no return
        public void MeInWater(int start, int span)
        {
            //print white ~
            for (int i = 0; i < start; i++)
            {
                Console.Write("~");
            }
            //set fish color and print fish
            Console.ForegroundColor = color;
            Console.Write(shape);
            //set black colorand print left ~
            Console.ForegroundColor = ConsoleColor.White;
            for (int j = (start + shape.Length); j < span; j++)
            {
                Console.Write("~");
            }
            Console.WriteLine();
        }

        //method for swim, overiden
        //one int parameter
        //no return
        public virtual void Swim(int span)
        {
            //create in vaiable to hold start
            int start = myRand.Next(0, (span - shape.Length + 1));
            MeInWater(start, span);
        }

        //method for print, overriden
        //no parameter
        //no return
        public virtual void Print()
        {
            Console.WriteLine("Fish {0}: {1} {2} for {3:C2}", name, shape, color, price);
        }
    }
}
