using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace We_re_so_back.OOP
{
     class Human
    {
        private string name;
        private int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void def()
        {
            Console.WriteLine($"Your name is {name} and your age is {age}");
        }

        public void work()
        {
            Console.WriteLine($"{name} is working!");
        }
    }
}
