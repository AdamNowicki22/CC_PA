using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_PA
{
    public class HangerTypeA: Hanger
    {
        private int limitOfClothes = 1;


        public void PutClothOnHanger(Clothes cloth)
        {
            if ((ClothesOnHanger.Count < limitOfClothes) && (cloth.ClothType=="shirt" || cloth.ClothType == "blouse"))
                { ClothesOnHanger.Add(cloth); }
            else { Console.WriteLine
                    ("You cannot use this hanger, it is either full or you are trying to put wrong cloth type"); }
        }
    }
}
