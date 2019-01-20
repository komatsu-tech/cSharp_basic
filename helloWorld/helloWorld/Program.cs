using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace helloWorld
{
    class Program
    {
        enum enumValue
        {
            hoge, fuga, foo, bar
        }

        static void Main(string[] args)
        {

            //helloWorld();
            //arrayStudy();
            //rdTxt();
            enumBehavior();

        }

        static void helloWorld()
        {
            Console.WriteLine("hello, C# world!\n");
            Console.WriteLine("goodbye, C# world!\n");

            Console.Read();
        }

        static void arrayStudy()
        {
            int[] intArray = new int[5] { 1, 1, 2, 3, 5 };
            int i = 0;

            Console.WriteLine("foreach example");
            foreach (int intVal in intArray)
            {
                Console.WriteLine(intVal);
            }

            Console.WriteLine("while example");
            while (i < intArray.Length)
            {
                Console.WriteLine(intArray[i]);
                i++;
            }

            Console.Read();

        }

        static void rdTxt()
        {
            try
            {
                using (StreamReader reader = new StreamReader("sample.txt", Encoding.GetEncoding("UTF-8")))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }

            }
            catch
            {
                Console.WriteLine("cannot open file");
            }

            //while( reader.EndOfStream == false )
            //{
            //    Console.WriteLine(reader.ReadLine());
            //}
            Console.ReadLine();

        }

        static void enumBehavior()
        {
            Console.WriteLine((enumValue)3);
            Console.WriteLine((int)(enumValue)3);
            Console.ReadLine();

        }
    
    }


    
}
