using System;

namespace Array_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ******** With Array Length ******** ");
                foreach (var item in WithArrayLength())
                {
                    Console.WriteLine(item);
                }
            Console.WriteLine(" ******** Without Array Length ******** ");
                foreach (var item in WithoutArratLength())
                {
                    Console.WriteLine(item);
                }
            Console.ReadKey();
        }

        public static int[] WithArrayLength()
        {
            int[] numberlist = new int[6];
            numberlist[0] = 100;
            numberlist[1] = 200;
            numberlist[2] = 300;
            numberlist[3] = 400;
            numberlist[4] = 500;
            numberlist[5] = 600;
            return numberlist;
        }
        public static int[] WithoutArratLength()
        {
            return  new int[] { 120, 300, 400, 500, 600 };
        }
        public static int[] WithoutNewDeclare()
        {
            int[] arraylist = { 10, 15, 20 };
            return arraylist;
        }
    }
}
