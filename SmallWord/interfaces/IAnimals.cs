using SmallWord.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWord.interfaces
{
    internal interface IAnimals
    {
        string Get_SpecieAnimal();
        decimal GetWeight();
        int GetAge();

        void move(decimal posX, decimal posY );

        bool eat( IFood food);

        void spleep();
    }
}
