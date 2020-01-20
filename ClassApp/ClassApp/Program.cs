using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //string word = "Kanan";
            //char letter = 'a';

            //Console.WriteLine(Count(word, letter));
            //Console.WriteLine(Avaerage(1, 5, 8, 9));
            #endregion
            //Human h1 = new Human();
            //h1.Name = "Mubariz";
            //h1.Surname = "Memmedzade";
            //h1.Age = 19;

            //Human h2 = new Human();
            //h2.Name = "Sadiq";
            //Console.WriteLine(h1.FullInfo());

            Human h3 = new Human("Cavid", "Esedullayev", 21);
            Console.WriteLine(h3.FullInfo());

            //Animal a1 = new Animal("eagle");

            Doctor d1 = new Doctor("Sadiq","Eliyev",20,"endokrinoloq");
            //d1.Surname = "Ceferov";
            //Console.WriteLine(d1.FullInfo());

            Doctor d2 = new Doctor("Imran", "Ehmedov", 22,"stomatoloq");
            //Console.WriteLine(d2.Name);
            //d2.Test();
            

            Console.WriteLine(d2.FullInfo());
        }

        #region Task
        //static int Count(string word, char letter) {
        //    int counter = 0;

        //    foreach (char l in word) {

        //        if (l == letter) {

        //            counter++;
        //        }

        //    }
        //    return counter;
        //}

        //static int Avaerage(params int[] array)
        //{
        //    int result = 0;
        //    foreach (int item in array)
        //    {
        //        result += item;
        //    }
        //    result = result / array.Length;
        //    return result;
        //}
        #endregion
    }
}
