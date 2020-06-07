using System;
using System.Collections.Generic;

namespace exception
{
    class Program
    {

        static List<int> list;

        static void FillData(int data)
        {
            if (data > 0)
            {
                list = new List<int>();
                list.Add(data);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            //try
            //{
            //    FillData(0);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sifir ve sifirdan kicik reqemler daxil edile bilmez");
            //}

            //Console.WriteLine("Hello world");



            B b = new B();
            try
            {
                C c = (C)b;

                if (b is C)
                {
                    Console.WriteLine("Casting");
                }

                C c2 = b as C;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        class A
        {

        }

        class B : A
        {

        }

        class C : B
        {

        }
    }
}
