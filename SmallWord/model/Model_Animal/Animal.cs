using SmallWord.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWord.model
{
    internal abstract class Animal : IAnimals

    {
        int id = 0; 
        public string species;
        public int age;
        public decimal weigth;
        public int energy= 100;
        public decimal positionX = 0;  
        public decimal positionY = 0;  
        public ItypeFood diet;


        public Animal(int id, string species, int age, decimal weigth, ItypeFood diet, int energy, decimal positionX, decimal positionY) 
        {
            this.id = id;
            this.species = species;
            this.age = age;
            this.weigth = weigth;
            this.diet = diet;
            this.energy = energy;
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public abstract void move(decimal posX, decimal posY);
        public abstract bool eat(IFood food);
        public abstract void spleep();
        public abstract string Get_SpecieAnimal();
        public abstract decimal GetWeight();
        public abstract int GetAge();
    }
}
