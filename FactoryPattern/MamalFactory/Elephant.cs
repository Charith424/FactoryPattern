using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.MamalFactory
{
    class Elephant : Mammal
    {
        public string ReturnAnimal()
        {
            return "Elephant";
        }

        public Elephant() {
            ReturnAnimal();
        }
    }
}
