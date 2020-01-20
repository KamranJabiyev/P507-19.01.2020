using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    class Doctor:Human
    {
        public string Profession;
        public Doctor(string name, string surname, int age,string pro) : base(name, surname, age)
        {
            Profession = pro;
        }

        public void Test()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {FullName()} {FullInfo()}");
        }

        public override string FullInfo()
        {
            return $"{base.FullInfo()} {Profession}";
        }
    }
}
