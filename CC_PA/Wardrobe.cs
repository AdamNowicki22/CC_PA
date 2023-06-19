using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_PA
{
    public class Wardrobe
    {
        private int Capacity;
        public List<Hanger> ListOfHangers;

        public Wardrobe(int capacity)
        {
            capacity = Capacity;
            ListOfHangers = new List<Hanger>();
        }

        public void PutHangerIntoWardrobe(Hanger hanger)
        {
            if (ListOfHangers.Count < Capacity)
            { 
                ListOfHangers.Add(hanger);
            }
            else { Console.WriteLine("Wardrobe is full"); }
        }

    }
}
