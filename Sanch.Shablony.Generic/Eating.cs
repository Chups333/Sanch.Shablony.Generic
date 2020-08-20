using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Shablony.Generic
{
    public class Eating<T>
    //where T: Product ограничение (в main) var eating = new Eating<Apple>; - можно подставить наследника или сам класс наследников
    //where T : Product<T> это правильно в моем коде var eating = new Eating<Product<int>>
    //where T : struct стек
    //where T : class
    //where T : new() публичный конструктор без параметров
    {
        public int Volume { get; set; }
        
        public void Add(T product)
        {
         //   Volume += product.Volume * product.Energy;
        }
    }
}
