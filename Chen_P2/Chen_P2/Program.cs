using System;
//Sitong Chen
//10-20-17
//Project 2 Aquarium
namespace Chen_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare new random object
            Random randomObj = new Random();
            //print name
            Console.WriteLine("Sitong Chen, Aquarium Project");
            Console.WriteLine();

            //declare fish object        
            Fish[] fishes = StockAquarium(17, randomObj);

            //check knife fish and call broadcast
            foreach(Fish f in fishes)
            {
                //Console.WriteLine(f.Name);
                if(f is KnifeFish)
                {
                    ((KnifeFish)f).BroadCast(fishes);
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //find partner to goby
            PartnerGoby(fishes);
            
            Console.WriteLine();
            Console.WriteLine("The full aquarium: ");
            //display fishes shape
            foreach(Fish f in fishes)
            {
                //Console.WriteLine(f.Name);
                f.Swim(50);     //call swim
                //Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("*****Stock details*****");
            //create a viable to hold the total price
            double total = 0;
            //add price and print information
            foreach(Fish f in fishes)
            {
                f.Print();
                total = total + f.Price;
            }
            Console.WriteLine();
            Console.WriteLine("Total starting cost: {0:C2}", total);
        }
        //method stock aquarium
        //int parameter and random object parameter
        //return fish array
        static public Fish[] StockAquarium(int numFish, Random rand)
        {
            //declare fish array
            Fish[] fishes = new Fish[numFish];
            //print infor
            Console.WriteLine("*****Stocking the aquariums!*****");
            //for loop to create random fishes 
            for(int i = 0; i < numFish; i++)
            {
                int gene;           //create a viable to hold random number
                gene = rand.Next(0, 4);      //assign random number
                //sweitch to create random fishes
                switch (gene)
                {
                    case 0:
                        fishes[i] = new PShrimp(rand);
                        break;
                    case 1:
                        fishes[i] = new Goby("Goby", rand);
                        break;
                    case 2:
                        fishes[i] = new KnifeFish("Ghost Knife", rand);
                        break;
                    default:
                        fishes[i] = new Fish(rand);
                        break;
                }
            }
            return fishes;    //return fishes array
        }

        //method to find goby partner
        //fish array parameter
        //no return
        static public void PartnerGoby(Fish[] fishes)
        {
            Console.WriteLine("Attemping to partner goby fish...");     //print information
            //for loop to check Goby
            for(int i = 0; i < fishes.Length; i++)
            {
                if(fishes[i] is Goby)
                {
                    ((Goby)fishes[i]).ChoosePShrimp(fishes);        //callmethod to find Goby's partner
                }
            }
        }
    }
}