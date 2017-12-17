using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.MamalFactory
{
    class Human : Mammal
    {
        public string ReturnAnimal()
        {
            return "Human";
        }
    }
}
