//Abstract example
using System;

abstract class Parent
{
    public abstract void dad();    //always use abstract keyword
    public void who()
    {
        Console.WriteLine("i am your dad");
    }
}
class Son : Parent
{
    public override void dad()   //always use override keyword
    {
        Console.WriteLine("i am your son bro");
    }
}
class family
{
    static void Main(string[] args)
    {
        Son s = new Son();
        s.dad();
        s.who();
    }
}

//Encapsuplation
using System;

namespace RectangleApplication
{
    class Rectangle
    {
        //member variables
        public double length; //if we put private here then we can only access the data member/ member function inside that class only
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class ExecuteRectangle //main class
    {
        static void Main(string[] args)  //main method it fetch the data from the two derived class as wwell from the base class
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            //Console.ReadLine(); //if we entered this code it will select as enter to the next line
        }
    }
}

//Inheritance //hierarchical 
using System;
namespace System
{
    public class father
    {
        public string fathername()
        {
            return "Vikram";
        }

    }
    public class firstson : father
    {
        public string firstname()
        {
            return "Rolex";
        }

    }
    public class secondson : father
    {
        public string secondname()
        {
            return "Siva";
        }

    }
    class Jato
    {
        public static void Main(String[] args)
        {
            firstson first = new firstson();
            Console.WriteLine("My name is :" + first.firstname() + Environment.NewLine + "My father is :" + first.fathername()); //Environment.NewLine helps to get space b/w space/move to next line
            secondson second = new secondson();
            Console.WriteLine();//going to new line (giving space between to print statement
            Console.WriteLine("My name is :" + second.secondname() + Environment.NewLine + "My father is :" + first.fathername());
        }
    }
}

//Inheritance //multilevel inheritance
using System;      
namespace Demo
{
    class Grandfather  //base class
    {
        public void Grand()    //method
        {
            Console.WriteLine("Grandfather...");
        }
    }
    class Father : Grandfather  //first child class 
    {
        public void Dad()
        {
            Console.WriteLine("Father...");
        }
    }
    class Son : Father  //Second child class
    {
        public void Boy()  //method
        {
            Console.WriteLine("Son.. ");
        }
    }
    class family
    {     //main class
        static void Main(string[] args)   //main method
        {
            Son s = new Son();    //inheriting form grand father and father
            s.Grand();   //s is the object which we created
            s.Dad();
            s.Boy();
            Console.ReadLine();
        }
    }
}
//Inheritance//multiple inhertance
using System;  
public interface Drawable
{
    void draw();
}
class Rectangle : Drawable
{
    public void draw()
    {
        Console.WriteLine("drawing rectangle...");
    }
}
class Circle : Drawable
{
    public void draw()
    {
        Console.WriteLine("drawing circle...");
    }
}
class TestInterface
{
    static void Main(string[] args)
    {
        Drawable d;
        d = new Rectangle();
        d.draw();
        d = new Circle();
        d.draw();
    }
}  

// compile time //Poymorphism //methodoverloading  
using System;			            /*using System using this we can comment */
class methodoverloading
{
    // adding two integer values. 
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);  //run time poly
    }

    // adding three integer values.
    public void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);

    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating Object
        methodoverloading ob = new methodoverloading();
        ob.Add(1, 2);
        ob.Add(1, 2, 3);
    }
}


/*Runtime polymorphism(method overriding)*/

using System;
class Animal   // class
{
    public virtual void eating()    //method
    {
        Console.WriteLine("Eating..");
    }
    class Dog : Animal
    {
        public override void eating()    //overriding the method from the parent class
        {
            Console.WriteLine("Eating Bread..");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();      //creatting a object  
            dog.eating();
        }
    }
}