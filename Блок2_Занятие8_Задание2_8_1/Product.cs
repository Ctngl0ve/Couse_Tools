using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Блок2_Занятие8_Задание2_8_1
{
    public class Product
    {
        public string Name { get; set; }
        public int Prise { get; set; }
        public string StringPrise => $"{Prise} ₽.";
        public string Sourses { get; set; }
        public CategoryList Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    public enum CategoryList
    {
        Еда,
        БытоваяТехника
    }

}
