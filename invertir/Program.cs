using System;

namespace invertir
{
    class Program
    {
        static void Main(string[] args) 
        {

            string f1 = "", f2 = "";

            Console.WriteLine("escriba la palabra a invertie :");
            f1 = Console.ReadLine();

            for ( int j = f1.Length - 1; j >= 0; j--) {

                f2 += f1[j];

                    }
            Console.WriteLine("la frase invetidad es " + f2);
            Console.ReadKey();


            
        }
    }
}
