namespace BitManipulations
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase _base = new CounterGame();
            _base.Execute();
            Console.ReadKey();
        }
    }
}
