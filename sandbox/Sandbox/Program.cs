using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person{};
        p1._firstname = "Mary";
        p1._lastname = "Smith";
        p1._age = 25;


        Person p2 = new Person{};
        p2._firstname = "John";
        p2._lastname = "Wakins";
        p2._age = 30;
    }
}