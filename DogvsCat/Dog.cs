using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogvsCat
{
    internal class Dog : Animal, Ilive
    {
            string Ilive.BabyCalled()
            {
                return "puppy";
            }
    }
}
