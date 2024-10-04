using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogvsCat
{
    internal class Cat:Animal, Ilive
    {
        string Ilive.BabyCalled() 
        {
            return "kitten";
        }
    }
}
