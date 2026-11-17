using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MaorZoo
{
    public class Cat : Animal
    {
        public override string SayHello()
        {
            return $"Cat {Name} says: miayuu";
        }
    }
}