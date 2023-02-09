﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex14.Entity;

namespace Ex14.Management
{
    internal class SortByName : IComparer<StudentVM>
    {
        public int Compare(StudentVM x, StudentVM y)
        {
            return x.FullName.CompareTo(y.FullName);
        }
    }
}