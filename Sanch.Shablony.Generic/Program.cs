using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Shablony.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = new Product("Яблоко",100,100); так обычно указывают
            var p = new Product<int>("Яблоко", 100, 100);// а так для шаблонов
            var pp = new Product<decimal>("Банан", 10.1M, 100);// а так для шаблонов

            var list = new List<int>();
            var map = new Dictionary<int, string>(); //словарь
            map.Add(5, "Пять");
        }
    }
}
