using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    partial class Human
    {
        public string Name;
        public string Surname;
        public int Age;

        public Human()
        {
            Console.WriteLine("Insan dunyaya geldi");
        }

        public Human(string word):this()
        {
            Console.WriteLine(word);
        }

        public Human(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }


}
