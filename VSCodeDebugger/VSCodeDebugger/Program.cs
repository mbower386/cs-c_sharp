using System;

namespace VSCodeDebugger
{
    class Program
    {
        static void Main (string[] args)
        {
            OuterFunction ();
        }

        public static void OuterFunction ()
        {
            Console.WriteLine ("Outer function code here");
            InnerFunction ();
        }

        public static void InnerFunction ()
        {
            Console.WriteLine ("Inner function code here");
        }
    }
}