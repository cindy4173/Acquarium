using System;
using System.Collections.Generic;
using System.Text;

namespace Chen_P2
{
    class PShrimp : Fish
    {
        //field
        private Goby partner;

        //property
        public Goby Partner
        {
            get { return partner; }
            set { partner = value; }
        }

        //constructor
        public PShrimp(Random _myRand) : base(_myRand)
        {
            partner = null;
            shape = " D-xѺѺX:༄ ";
            price = (double)myRand.Next(18, 24);
        }

        //method for override swim
        //int parameter
        //no return
        public override void Swim(int span)
        {
            //create vaiable to hold start
            int start = myRand.Next(0, (span - shape.Length + 1));

            //if shrimp has partner
            if (partner != null)
            {
                //call partner's me in water
                partner.MeInWater(start, span);
            }
            //Console.WriteLine();
            MeInWater(start, span);
        }

        //override method for print
        //no parameter
        //no return
        public override void Print()
        {
            base.Print();
            if (partner != null)
            {
                Console.WriteLine("     Carrying partner {0}", name);
            }
        }
    }
}
