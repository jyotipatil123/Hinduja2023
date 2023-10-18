using System;

namespace hindujanamespace1
{

    class india
    {
        public static void f1()
        {
            System.Console.WriteLine("public static f1()");
        }
         static void f2()
        {
            System.Console.WriteLine("static f2()");
        }
        public void f3()
        {
            System.Console.WriteLine("public void f3()");
            f2();
        }

        public int add()
        {
            int a=10;
            int b=20;

            return (a+b);
        }

        // addition, subtraction, multiplication, division, modulus 

        //return and parameters
        public int add(int a , int b )
        {
            return (a+b);
        }
    }
   public class myclass1
   {
      static void Main()
      {
        // static void functions 
           function1();
           function2();
           function1();
           function2();

           // public void functions
           myclass1 obj= new myclass1();
           obj.fun1();

           india obj1= new india();
           obj1.f3();
           System.Console.WriteLine( "Addition result is : " + obj1.add());
           
           india.f1();    

          //return with parameters
          System.Console.WriteLine(obj1.add(10,2)) ;           

      }



      static void function1()
      {
         System.Console.WriteLine("static void function1() is invoked");
      }
         static void function2()
      {
         System.Console.WriteLine("static void function2() is invoked");
      }

      public void fun1()
      {
        System.Console.WriteLine("public void fun1()");
      }      
   }
}
