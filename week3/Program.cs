﻿using week3;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates","1234567");
        Book book = new Book("Ultimate C# ", "Microsoft", "2233445");

        book.DisplayInfo();
    }
}

