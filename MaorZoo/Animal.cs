using System;
using System.Collections.Generic;
using System.Text;

namespace MaorZoo
{
    public class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public virtual string SayHello()
        {
            return "Hello!" + Name;
        }
    }
}
