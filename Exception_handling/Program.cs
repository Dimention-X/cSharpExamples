﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
                try
            {
                Console.WriteLine("My name is "); return;
            }
            finally { Console.WriteLine("akhilesh"); }
        }
    }
}
