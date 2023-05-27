using SmallWord.interfaces;
using SmallWord.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWord.controllers
{
    internal class AnimalControllers
    {
        private List<IAnimals> animals = new List<IAnimals>();
        public AnimalControllers() { }

        public List<IAnimals> GetAnimals() {  return animals; }

        public  Acuatic CreateAmimalsAcuatic(int id, string species, int age, decimal weigth, ItypeFood diet, int energy, decimal positionX, decimal positionY)
        {
            return new Acuatic(id, species, age, weigth,  diet,  energy,  positionX,  positionY);
        }

        public Terrestrial CreateAmimalsTerrestrial(int id, string species, int age, decimal weigth, ItypeFood diet, int energy, decimal positionX, decimal positionY)
        {
            return new Terrestrial(id, species, age, weigth, diet, energy, positionX, positionY );
        }

        public AeroTerrestrial CreateAmimalsAeroTerrestrial(int id, string species, int age, decimal weigth, ItypeFood diet, int energy, decimal positionX, decimal positionY)
        {
            return new AeroTerrestrial(id, species, age, weigth, diet, energy, positionX, positionY);
        }
    }
}
