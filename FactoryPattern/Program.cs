using FactoryPattern.MamalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mamalObj= MamalFactory.Mammalmechine.Createmamal(MamalFactory.AnimalSet.zeebrs);
            Console.WriteLine(mamalObj.ReturnAnimal());
            Console.ReadLine(); 
        }
    }
}
