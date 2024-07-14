using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace We_re_so_back.OOP
{
     class Car
    {
        private String model;
        public static int numofCars;
        public Car(String model) 
        { 
            this.model = model;
            numofCars++;
        }
    }
}
