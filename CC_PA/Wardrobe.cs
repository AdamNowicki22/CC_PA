using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void RemoveClothById(int id)
        {
            foreach (Hanger hanger in ListOfHangers)
            {
                foreach(Clothes cloth in hanger.ClothesOnHanger)
                {
                    if (cloth.ClothId == id) 
                    {
                        hanger.ClothesOnHanger.Remove(cloth);
                    }
                }
            }
        }
        public bool AreThereAnyEmptyHangersForMyClothType(string clothType)
        {
            if (clothType =="shirt" ||clothType== "blouse")
            {
                foreach (Hanger hanger in ListOfHangers)
                { 
                    if (hanger.ClothesOnHanger.Count == 0)
                    {
                        return true;
                    }
                }
                foreach (HangerTypeB hangerTypeB in ListOfHangers) 
                {
                    if (hangerTypeB.ClothesOnHanger.Count == 1 &&
                        (hangerTypeB.ClothesOnHanger[0].ClothType== "trousers"||
                        hangerTypeB.ClothesOnHanger[0].ClothType == "skirt"))
                    { return true; }
                }
            }
            return false;
        }

    }
}
