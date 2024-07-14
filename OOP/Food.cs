using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace We_re_so_back.OOP
{
    class Food
    {
        private String main;
        private String appetizers;
        private String dessert;


        public Food(String main)
        {
            this.main = main;
        }
        public Food(String main, String appetizers)
        {
            this.main= main;
            this.appetizers= appetizers;
        }
        public Food(string appetizers, string main, string dessert)
        {
            this.appetizers = appetizers;
            this.main = main;
            this.dessert = dessert;
        }
    }
    
}
