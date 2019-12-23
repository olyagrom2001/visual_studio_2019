using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_2
{
    class Dog
    {
        public Dog() {}
        public Dog(int age = 1)
        {
            Age = age;
        }
        public Dog(int age = 1, string name="Dog")
        {
            Age = age;
            Name = name;
        }
        public int Age { get; private set; }
        [AttributeClass("Имя")]
        public string Name { get; set; }

        public void Gav()
        {
            Console.WriteLine("Gav Gav");
        }

    }
}
