﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.Model
{
    public class Dog
    {
        public string PedigreeNumber { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string DadPedigreeNumber { get; set; }
        public string MomPedigreeNumber { get; set; }
        public string Gender { get; set; }
        public bool IsDead { get; set; }
        


        public Dog(string pedigreeNumber,
                   string name,
                   DateTime dOB,
                   string dadPedigreeNumber,
                   string momPedigreeNumber,
                   string gender,
                   bool isDead)
        {
            PedigreeNumber = pedigreeNumber;
            Name = name;
            DOB = dOB;
            DadPedigreeNumber = dadPedigreeNumber;
            MomPedigreeNumber = momPedigreeNumber;
            Gender = gender;
            IsDead = isDead;
        }
    }
}
