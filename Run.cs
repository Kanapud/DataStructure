using System;
using System.Diagnostics.CodeAnalysis;

namespace ArrayBox
{
    public class Run
    {
        static void Main() 
    {
            //Test case 1
            Box a1 = new ArrayBox(5);
            a1.add(3); a1.view( );
            a1.add(2); a1.view( );
            a1.add(1); a1.view( );
            a1.add(4); a1.view( );
            Console.WriteLine("size = " + a1.size());
            a1.remove(3); a1.view();
            a1.remove(1); a1.view();
            a1.remove(5); a1.view();
            a1.remove(4); a1.view();
            a1.remove(2); a1.view();

            //Test case 2
            Box a2 = new ArrayBox(5);
            a2.remove(4); a2.view();
            a2.add(1); a2.view();
            a2.add(2); a2.view();
            a2.add(3); a2.view();
            a2.add(4); a2.view();
            Console.WriteLine("size = " + a2.size());
            a2.remove(4); a2.view();
            a2.remove(3); a2.view();
            a2.remove(3); a2.view();
            a2.remove(2); a2.view();
            a2.remove(1); a2.view();
        }
    }
}
