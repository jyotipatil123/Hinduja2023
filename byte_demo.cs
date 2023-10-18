using System;

namespace hindujanamespace3
{
    class UK
    {
        static void Main(string[] args)
        {
            byte var2=65;
            byte var3=200;

            System.Console.WriteLine(var2);
            System.Console.WriteLine(var3);

            byte[] arr={1,2,3,4,5,6,7,8,9,10};
            byte[] arr1 = {11,12,13,14,15,16,17,18};
            byte[] arr2={19,20,21,22,23,24,25,26,27,28,29,30};
             
             foreach(byte i in arr)
             {
                System.Console.WriteLine(i);
             }

              foreach(byte i in arr1)
             {
                System.Console.WriteLine(i);
             }

             System.Console.WriteLine("byte array is : ");
             System.Console.WriteLine(BitConverter.ToString(arr));

             System.Console.WriteLine("byte array is : ");
             System.Console.WriteLine(BitConverter.ToString(arr1));

             System.Console.WriteLine("byte array is : ");
             System.Console.WriteLine(BitConverter.ToString(arr2));

        }
    }
}
