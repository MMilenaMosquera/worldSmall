using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallWord.interfaces
{
    internal interface IFood
    {
        int GetId();
        string GetName();
        int GetCalories();
    }
}
