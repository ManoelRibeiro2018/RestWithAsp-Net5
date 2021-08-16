﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Model
{
    public class Person : EntityBase
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public void Update(string fisrtName, string lastName, string address, string gender)
        {
            FirtName = fisrtName;
            LastName = lastName;
            Address = address;
            Gender = gender;
        }
    }
}
