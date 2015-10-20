﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public String Name
        {
            get;
            set;
        }
        private int age;

        public Person(String name, int age)
        {
            Name = name; 
            Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = (value >= 0) ? value : 1;  }
        }

      

        public override string ToString()
        {
            return Name+" est agée de "+Age+" ans";
        }


    }
}
