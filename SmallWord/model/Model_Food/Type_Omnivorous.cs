using SmallWord.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWord.model
{
    internal class Type_Omnivorous : ItypeFood

    {
        public bool canEat(IFood food)
        {
            return food is meatFood;
        }


        public override string ToString()
        {
            return "Omnivoro";
        }
    }
}
