using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xenprog
{
    class Animal
    {
        protected string name;
        protected string type;

        public string Name { get { return name; } set { name = value; } } 
        public string Type { get { return type; } set { type = value; } } 
    }
    class Reptile : Animal
    {
        protected string movement;

        public string Movement { get { return movement; } set { movement = value; } }
    }

    class Snake : Reptile
    {
        private string venomType;
        public string VenomType { get { return venomType; } set { venomType = value; } }
    }
    internal class multilevelinheritance
    {

    }
}
