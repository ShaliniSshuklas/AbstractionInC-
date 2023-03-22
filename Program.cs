using System;

namespace Abstraction
{
    // abstraction means to hide certain details and show the essentials data to user .
    // abstraction achieve with abstract class or interface .
    // abstract class can't be instantiated. (can't make object).
    // abstract class have abstract method and non abstract method (normal method).
    // we use override concept to inherite the abstract or regular method .


    public abstract class Programs
    {
        public abstract void uiMethod();

        public void backendMethod()
        {
            Console.WriteLine("this is a method");
        }

    } 

    public class Employee: Programs
    {
        public override void uiMethod()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(); 
            obj.uiMethod();  
            obj.backendMethod();  
        }
    }
}
       

