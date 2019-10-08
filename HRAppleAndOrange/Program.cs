using System;

namespace HRAppleAndOrange {
    class Program {
        static void Main(string[] args) {

            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;
            int[] apples = { -2, 2, 1 };
            int[] oranges = { 5, -6 };

            int ac = 0;
            int oc = 0;

            foreach(var apple in apples) {
                if(a + apple >= s && a + apple <= t) {
                    ac++;
                }
            }
            foreach(var orange in oranges) {
                if(b + orange >= s && b + orange <= t) {
                    oc++;
                }
            }
            Console.WriteLine(ac);
            Console.WriteLine(oc);
        }
    }
}