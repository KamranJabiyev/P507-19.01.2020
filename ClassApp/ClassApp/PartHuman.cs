using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    partial class Human
    {
        public string FullName()
        {
            return $"{Name} {Surname}";
        }

        public virtual string FullInfo()
        {
            return $"{FullName()} {Age}";
        }
    }
}
