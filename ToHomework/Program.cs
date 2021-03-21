using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ToHomework
{
   
    class Program
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Program()
        {

        }
        public Program(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}

