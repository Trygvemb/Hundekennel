﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.Model.Interfaces
{
    internal interface IDogsRepository : IGenericRepository<Dog>
    {
        public IEnumerable<Dog> MatchTwoDogsAndShowFamilyTree(string dog1Id, string dog2Id);
    }
}
