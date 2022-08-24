using System;

namespace VariableTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b = 5;     //2byte
            sbyte sb = 5;    //2byte

            short s = 5;    //2byte 
            ushort us = 5;  //2byte unsigned

            int i = 5;      //4byte
            Int32 i32 = 5;  //4byte
            Int64 i64 = 5;  //8byte
            uint ui = 5;    //4byte unsigned

            long l = 5;     //8byte
            ulong ul = 5;   //8byte unsigned

            float f = 5.1f; //4byte
            double d = 5.2; //8byte
            decimal de = 5.3M; //16byte

            char c = '5';   //2 byte
            string str = "5"; //sınırsız (dynamic allocation?)

            bool bt = true; //1bit
            bool bf = false;//1bit

            DateTime dt1 = DateTime.Now; //8byte

            object o1 = "this is a string"; //dinamik
            object o2 = "5";                //dinamik

            string em_str = string.Empty;
            bool decision = 1 > 2;
            Int32 i32d = int.Parse(str);
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string time = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("Time is " + time + " on " + date);
        }
    }
}