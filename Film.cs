using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Film
    {
        public abstract string Name { get; set; }

        public abstract int Year { get; set; }


        public abstract string Director { get; set; }

        public abstract string Work();

    }
}
