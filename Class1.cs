using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class A
{
    int numberofWheels;
    public static int someNumber = 2;


    public A(int parameter)
    {
        numberofWheels = parameter;
    }

    public int getDoubleNumberofWheels()
    {
        someNumber = someNumber * 5;

        return numberofWheels * 3;
    }


    public static void getFloatNumberofWheels()
    {
        Console.WriteLine("Test");
    }
}