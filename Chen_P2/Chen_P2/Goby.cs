using System;
using System.Collections.Generic;
using System.Text;

namespace Chen_P2
{
    class Goby : Fish
    {
        //field
        private PShrimp partner;

        //property
        public PShrimp Partner
        {
            get { return partner; }
        }

        //constructor
        public Goby(string _name, Random _myRand) : base(_myRand)
        {          
            partner = null;
            name = _name + " " + name;
            shape = " ౨><o))}D> ";
            price = (double)myRand.Next(37, 71);
        }

        //method to choose pshrimp
        //fish array parameter
        //no return
        public void ChoosePShrimp(Fish[] fish)
        {
            for (int i = 0; i < fish.Length; i++)
            {
                //condition if fish is shrimp, goby and shrimp does not have partner
                if ((fish[i] is PShrimp) && (((PShrimp)fish[i]).Partner == null) && (partner == null))
                {
                    //assign shrimp object to partner
                    partner = new PShrimp(myRand);
                    //assign shrimp's partner to goby
                    ((PShrimp)fish[i]).Partner = this;
                    //display partner information
                    Console.WriteLine("     {0} partnered with shrimp {1}", name, partner.Name);
                }
            }
        }

        //oveeride swim method
        //int parameter
        //no return
        public override void Swim(int span)
        {
            //if goby does not have partner, call swim
            if (partner == null)
            {
                base.Swim(span);
            }
        }

        //override print method
        //no parameter
        //no return
        public override void Print()
        {
            //call base print
            base.Print();
            //if goby has partner
            if (partner != null)
            {
                Console.WriteLine("     riding shrimp {0}", partner.Name);
            }
        }

    }
}
