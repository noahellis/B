﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSetB
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputBark dogBark = new UserInputBark();
            
            while (true)
            {
                
                dogBark.GetUserInput();
                dogBark.CompareWords();

                
            }

        }
    }
}