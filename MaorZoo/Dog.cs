using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MaorZoo
{
    public class Dog : Animal
    {
        public override string SayHello()
        {
            return $"Dog {Name} says: wolf";
        }
    }
}

