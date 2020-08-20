using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Shablony.Generic
{
    public class Product<T> // можно <T, TT> два типа для двух аргиментов
    {
        //Так указывают с типом (шаблоном)!!!!!!
        public string Name { get; set; }

        public T Volume { get; set; }

        public T Energy { get; set; }

        public Product(string name, T volume, T energy)
        {
            // TODO: проверить входные параментры

            Name = name;
            Volume = volume;
            Energy = energy;
            //Energy = default(T); Значение по умолчанию
        }


        /*public string Name { get; set; } так используют обычно 

        public int Volume { get; set; }

        public int Energy { get; set; }
        
        public Product(string name, int volume, int energy)
        {
            // TODO: проверить входные параментры

            Name = name;
            Volume = volume;
            Energy = energy;
        }*/

    }
}
