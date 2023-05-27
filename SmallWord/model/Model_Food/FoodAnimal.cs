using SmallWord.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWord.model
{
    internal class meatFood: IFood
    {
        private int id;
        private string name;
        private int calories;

        public meatFood(int id, string name, int calories)
        {
            this.id = id;
            this.name = name;
            this.calories = calories;
        }

        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public int GetCalories()
        {
            return calories;
        }

       
    }
}
