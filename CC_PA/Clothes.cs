using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_PA
{
    public class Clothes
    {
        public int ClothId;
        public string BrandName;
        public string ClothType;

        public Clothes(int clothID, string brandName, string clothType)
        {
            ClothId = clothID;
            BrandName = brandName;
            setClothType(clothType);
        }
        private void setClothType(string type)
        {
            clothTypes parsedType;
            if(Enum.TryParse(type, out parsedType))
            {
                ClothType = parsedType.ToString();
            }
            else
            {
                ClothType = "wrong";
            }

        }
    }
    enum clothTypes
    {
        shirt,
        blouse,
        trousers,
        skirt
    }
}
