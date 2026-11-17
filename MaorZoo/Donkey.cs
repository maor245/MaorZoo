using System;
using System.Collections.Generic;
using System.Text;

namespace MaorZoo
{
    public class Donkey : Animal
    {
        public override string SayHello()
        {
            return $"Donkey {Name} says: Iii-Haaa";
        }
    }
}