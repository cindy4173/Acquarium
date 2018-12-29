using System;
using System.Collections.Generic;
using System.Text;

namespace Chen_P2
{
    class KnifeFish : Fish
    {
        //constructor
        public KnifeFish(string _name, Random _myRand) : base(_myRand)
        {
            name = _name + " " + name;
            shape = " <Ш||><t ";
            price = (double)myRand.Next(20, 51);
        }

        //method for broacast
        //fish array parameter
        //no return
        public void BroadCast(Fish[] fish)
        {
            //create bool to check how mant knife fish is
            bool check = true;
            //if there is no knife fish, check is false
            if(fish.Length == 0)
            {
                check = false;
            }

            //if there are one or more fish
            if (check)
            {
                //first loop to check knife fish, and display fishes recieves broadcast
                for (int i = 0; i < fish.Length; i++)
                {
                    if ((fish[i] is KnifeFish) && ((fish[i] != this)))
                    {
                        Console.Write("{0}, ", fish[i].Name);
                    }
                }
                //second loop to check knife fish that have broadcast
                for (int i = 0; i < fish.Length; i++)
                {
                    if ((fish[i] is KnifeFish) && ((fish[i] == this)))
                    {
                        Console.WriteLine(" and the NSA heard the bzzzz broadcast by {0}", name);
                    }

                }
            }
            //if there has no fish
            if (!check)
            {
                Console.WriteLine();
            }
            
        }
    }
}