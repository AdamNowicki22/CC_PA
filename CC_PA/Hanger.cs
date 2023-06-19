using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_PA
{
    public abstract class Hanger
    {
        public List<Clothes> ClothesOnHanger;
        public void RemoveAllClothesFromHanger()
        {
            ClothesOnHanger.Clear();
        }
        public void PrintAllClothesOnHanger()
        {
            foreach (Clothes cloth in ClothesOnHanger)
            {
                Console.WriteLine($"On this hanger we have cloth ID {cloth.ClothId}, it is a {cloth.ClothType} by {cloth.BrandName}");
            }
        }
    }
}
