using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.MamalFactory
{
   public class Mammalmechine
    {
        public static Mammal Createmamal(AnimalSet animal) {
            Mammal mamal = null;
            switch (animal)
            {
                case AnimalSet.human:
                    mamal = new Human();
                    return mamal;
                    break;
                case AnimalSet.zeebrs:
                    mamal = new Zeebra();
                    return mamal;
                    break;
                case AnimalSet.Elephant:
                    mamal = new Elephant();
                    return mamal;
                    break;
                default:
                    mamal = null;
                    return mamal;
                    break;
            }
        }
    }
}
