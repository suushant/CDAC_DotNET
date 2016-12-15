﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesIntro
{
    class Delegates
    {
        public delegate void Del(); //create delegate
        static void Main1(string[] args)
        {
            Del o = new Del(function1);  //create an object passing function as parameter
            o();    //call the function using the object!
        }
        public static void function1()
        {
            Console.WriteLine("function!");
            Console.ReadLine();

        }
        public static void function2(int a)
        {
            Console.WriteLine("action: value is "+ a);
            Console.ReadLine();
        }
        public static int function3(int a,int b,String name)
        {
            Console.WriteLine("string passed is: "+name);
            return a+b;
        }
        static void Main()
        {
            //you can also use inbuilt delegate classes
            //1. Action 2. Func 3.Predicate
            //Action has 2 variants Action -> has no returntype and no parameters. Action<> -> has no returntype but has parameters. Max allowed are 16.
            //Func returns value. has parameters in the <inparam, returntype> format.
            //Predicate has one parameter and returns bool
            Console.WriteLine("in main");
            Action ac = function1;
            ac();

            Action<int> aci = function2;
            aci(5);

            Func<int,int,string,int> fcc = function3;
            Func<string, string> fc = UppercaseString;
            string name = "alex";
            Console.WriteLine("the desired output is: "+fcc(5,4,fc(name)));
            Console.ReadLine();
            
            
        }
        private static string UppercaseString(string i)
        {
            Console.WriteLine("converting to upper case..");
            return i.ToUpper();
        }
    }
}
