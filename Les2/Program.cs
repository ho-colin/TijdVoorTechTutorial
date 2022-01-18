using System;

namespace Les2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            string s1 = "test";
            Console.WriteLine(s1 + s1);
            Console.WriteLine("s1+s1");

            int i1 = 1;
            Console.WriteLine(i1 + i1);

            Console.WriteLine(s1 + i1);
            //Console.WriteLine(s1*i1);

            //                     0      1
            string[] sArray = { "John", "Doe" };
            Console.WriteLine(sArray[1]);
            isJohnCena(sArray[1]);

            sArray[1] = "Cena";
            Console.WriteLine(sArray[1]);
            isJohnCena(sArray[1]);

            void isJohnCena(string waarde) {
                if (waarde == "Cena") {
                    Console.WriteLine("You can't see me.");
                }
            }
        }
    }
}
