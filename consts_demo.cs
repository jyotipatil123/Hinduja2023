using System;

namespace hindujanamespace2
{
    class india
    {
        const float var1=3.1111f;

        public void function1()
        {
          //  var1=4.5f;
            System.Console.WriteLine("Variable inide function1() is : " +var1);
        }
    }
    class UK
    {
        public static void Main()
        {
            india obj= new india();
            obj.function1();
        }
    }
}
