﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Exps
{
    internal class EmailException : Exception
    {
        public EmailException()
        {

        }

        public EmailException(string Email) : base($"Invalid email: {Email}") 
        {

        }
        

        
    }
}
