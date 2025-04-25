using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatement
{
    class Animal
    {
        public string? Name;
        public DateTime Born;
        public byte Legs;
    }
    class Cat : Animal // This is a subtype of animal
    {
        public bool IsDomestic;
    }
    class Spider: Animal
    {
        public bool IsVenomous;
    }

}
