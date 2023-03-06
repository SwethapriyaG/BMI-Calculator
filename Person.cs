using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalculator
{
    class Person
    {
        public string Name { get; private set; } // Egenskaper och inkapsling av variable
        public int Age { get; private set; }
        public float Length { get; private set; }
        public float Weight { get; private set; }
        public Person (string pName, int pAge, float pLength, float pWeight) // Konstuctor med argumetor
        {
            Name = pName;
            Age = pAge;
            Length = pLength;
            Weight = pWeight;
        }
        
    }
}
