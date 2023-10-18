// structures in c#

using System;

public struct Book 
{
    public int bookid;
    public string bookname;
    public string author;

    public void function1()
    {
        System.Console.WriteLine("I am from structure");
    }
}

class myclass6
{
   static void Main(string[] args)
   {
        Book b1= new Book();
        b1.bookid=101;
        b1.bookname="c sharp";
        b1.author="ken";   
        b1.function1();

        Book b2= new Book();
        b2.bookid=102;
        b2.bookname="asp.net";
        b2.author="john";
        b2.function1();

       System.Console.WriteLine("Book 1 id : "+ b1.bookid);
        System.Console.WriteLine("Book 1 name : "+ b1.bookname);
         System.Console.WriteLine("Book 1 author : "+ b1.author);

          System.Console.WriteLine("Book 2 id : "+ b2.bookid);
           System.Console.WriteLine("Book 2 name : "+ b2.bookname);
            System.Console.WriteLine("Book 2 author : "+ b2.author);


   }
}