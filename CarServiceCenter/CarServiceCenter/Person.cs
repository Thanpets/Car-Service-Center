﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter {
    class Person : Entity {

        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname):base() {
            Name = name;
            Surname = surname;
        }
    }
}
