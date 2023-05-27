using SmallWord.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWord.model
{
    internal class Acuatic : Animal
    {
        public Acuatic(int id,string species, int age, decimal weigth, ItypeFood diet, int energy, decimal positionX, decimal positionY) :
            base(id, species, age, weigth,diet, energy, positionX, positionY)
        {
        }

        public override bool eat(IFood food)
        {
         return diet.canEat(food);

        }

        public override int GetAge()
        {
            return age;
        }

        public override decimal GetWeight()
        {
            return weigth;
               
        }

        public override string Get_SpecieAnimal()
        {
            return species;
        }

        public override void move(decimal posX, decimal posY)
        {
            if (energy >= 30)
            {
                positionX += posX;
                positionY += posY;
                energy -= 30;
            }
            MessageBox.Show("El animal no puede moverse. Necesita más energia");

        }
        public override void spleep()
        {
            energy += 50;
            if (energy > 100)
            {
                energy = 100;
            }
        }

        public override string ToString()
        {
            return "El animal creado es: " + Get_SpecieAnimal() + ", altura: " + GetWeight() + " ,edad: " + GetAge() + " Su alimentación es:" + diet;
        }
    }
}
