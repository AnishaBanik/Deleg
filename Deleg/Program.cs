using System;
using System.IO;
namespace DifferentMethods
{
    public delegate void NameDelegate(string msg);
    public class Printing
    {
        public string msg;
        public Printing(string msg)
        {
            this.msg = msg;
        }
        public void display(string msg)
        {
            Console.WriteLine("from 1st method: \t " + this.msg);
        }
        public void keep(string msg)
        {
            System.IO.File.WriteAllText(@"C:\Users\Anisha Banik\abc.txt", this.msg);
            Console.WriteLine("done from 2nd method  ");
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter messege");
            string text = Console.ReadLine();
            var per = new Printing(text);
            var nDelegate = new NameDelegate(per.display);
            nDelegate("Call 1st func: ");
            nDelegate = new NameDelegate(per.keep);
            nDelegate("Call 2nd func: ");
        }
    }
}
