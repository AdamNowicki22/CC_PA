using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_PA
{
    public class HangerTypeB: Hanger
    {
        private int limitOfClothes = 2;

        public void PutClothOnHanger(Clothes cloth)
        {   
            if (ClothesOnHanger.Count == 0)
            {
                ClothesOnHanger.Add(cloth);
            }
            else if ((ClothesOnHanger.Count ==1) && (cloth.ClothType == "shirt" || cloth.ClothType == "blouse"))
            {
                if (ClothesOnHanger[0].ClothType== "skirt"||
                    ClothesOnHanger[0].ClothType == "trousers")
                {
                    ClothesOnHanger.Add(cloth);
                } 
            }
            else if ((ClothesOnHanger.Count == 1) && (cloth.ClothType == "skirt" || cloth.ClothType == "trousers"))
            {
                if (ClothesOnHanger[0].ClothType == "shirt" ||
                    ClothesOnHanger[0].ClothType == "blouse")
                {
                    ClothesOnHanger.Add(cloth);
                }
            }


            else if (ClothesOnHanger.Count >= limitOfClothes)
            { 
                Console.WriteLine("This hanger is already full");
            }
        }
        public void RemoveClothByIdFromHanger(int id)
        {
            foreach (Clothes cloth in ClothesOnHanger)
            {
                if(cloth.ClothId == id)
                {
                    ClothesOnHanger.Remove(cloth);
                    Console.WriteLine("Cloth removed from hanger");
                }

            }

        }

    }
}
