using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_09
{
    //3
    [Serializable]
    public class MyException : Exception
    {
        public DateTime TimeException { get; }
        public MyException() : this("MyException")
        { 

        }
        public MyException(string message) : base(message) { TimeException = DateTime.Now; }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    //2
    //class MyException : ApplicationException
    //{
    //    public DateTime TimeException { get; }

    //    public MyException():base("MyException")
    //    {
    //        TimeException = DateTime.Now;
    //    }
    //}

    //1
    //class MyException:ApplicationException
    //{
    //    private string _message;
    //    public DateTime TimeException { get; }

    //    public MyException()
    //    {
    //        _message = "MyException";
    //        TimeException = DateTime.Now;
    //    }
    //}
    class MyClass
    {
        string st;
        int n;
    }
    class Program
    {
        private static int Divide(int n)
        {
            try
            {
                return 100 /n;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public class A
        //{
        //    private int num;

        //    public A(int num)
        //    {
        //        this.num = num;
        //    }
        //    public void MethodA()
        //    {
        //        Console.WriteLine("Entering MethodA");
        //        try
        //        {
        //            this.MethodB();
        //            Console.WriteLine("Class A");
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception(e.Message);
        //            // throw; передача исходного объекта исключения
        //            Console.WriteLine("Exception MethodA");
        //        }
        //        Console.WriteLine("Leaving MethodA");
        //    }
        //    public void MethodB()
        //    {
        //        Console.WriteLine("Entering MethodB");
        //        if (this.num > 10 || this.num < 0)
        //            throw new System.Exception("Exception in MethodB - out of range");
        //        Console.WriteLine("Leaving MethodB");
        //    }
        //}
        //public class Tester
        //{
        //    public static void Main()
        //    {
        //        Console.WriteLine("Entering Main");
        //        A a = new A(15);
        //        try
        //        {
        //            a.MethodA();
        //            Console.WriteLine("Main");
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Exception Main");

        //            // причина возникновения исключения
        //            Console.WriteLine(e.Message);
        //            // имена, сигнатуры и нахождение методов, вызов которых привел к возникновению исключения
        //            Console.WriteLine(e.StackTrace);
        //            // метод, сгенерировавший исключение
        //            Console.WriteLine(e.TargetSite);
        //        }
        //        Console.WriteLine("Leaving Main");

        //        Console.ReadKey();
        //        Console.ReadKey();
        //    }
        //}


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        //public static void Main()
        //{
        //    Console.WriteLine("Entering Main");
        //    int a = 10, b = 0, c;
        //    try
        //    {
        //        Console.WriteLine("Entering try. Level 1");
        //        c = a + b;
        //        try
        //        {
        //            Console.WriteLine("Entering try. Level 2");
        //            c = a / b;
        //        }
        //        catch (System.DivideByZeroException ex)
        //        {
        //            Console.WriteLine("level 2 " + ex.Message);
        //        }
        //    }
        //    catch (System.ArithmeticException ex)
        //    {
        //        Console.WriteLine("Leaving try. Level 1"
        //            + ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("hello from finally");
        //    }
        //    Console.WriteLine("Leaving Main");
        //}
        //static void Main(string[] args)
        //{
        //    //try
        //    //{
        //    //    Console.WriteLine("Enter two numbers: ");

        //    //    int n1 = int.Parse(Console.ReadLine());
        //    //    int n2 = int.Parse(Console.ReadLine());

        //    //    int res = n1 / n2;

        //    //    Console.WriteLine($"Result: {res}");
        //    //}
        //    //catch (DivideByZeroException de)
        //    //{
        //    //    Console.WriteLine(de.Message);
        //    //}
        //    //catch (FormatException fo)
        //    //{
        //    //    Console.WriteLine(fo.Message);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine(ex.Message);
        //    //}
        //    //finally
        //    //{
        //    //    Console.WriteLine("finaly");
        //    //}


        //    //try
        //    //{
        //    //    Console.WriteLine("Enter two numbers: ");

        //    //    int n1 = int.Parse(Console.ReadLine());
        //    //    int n2 = int.Parse(Console.ReadLine());

        //    //    int res = n1 / n2;

        //    //    Console.WriteLine($"Result: {res}");

        //    //}
        //    //catch
        //    //{
        //    //    Console.WriteLine("Error!");
        //    //}


        //    //try
        //    //{

        //    //}
        //    //finally
        //    //{

        //    //}


        //    string str = null;
        //    try
        //    {
        //        Console.WriteLine("Enter two numbers: ");

        //        int n1 = int.Parse(Console.ReadLine());
        //        int n2 = int.Parse(Console.ReadLine());

        //        if (n2%2==0)
        //        {
        //            throw new MyException();
        //        }
        //        Divide(n1);

        //        int res = n1 / n2;

        //        Console.WriteLine($"Result: {res}");
        //        str = "Hello";
        //    }
        //    catch(MyException me)
        //    {
        //        //Console.WriteLine($"Error!{me.TimeException}{me.Message}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    //Console.WriteLine(str.Contains("Hell"));

        //    Console.ReadKey();
        //    Console.ReadKey();

        //}
    }
}
