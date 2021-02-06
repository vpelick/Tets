using InputSimulatorStandard;
using System;
using System.Threading;



namespace Tets
{
    class Program
    {
    
        public static void Main(string[] args)
        {
            Inputs cl = new Inputs();
            InputSimulator input = new InputSimulator();
            while (true)
            {
                if (Console.CapsLock)
                {
                    Console.WriteLine("ATIVO");
                    cl.Click();
                }
                Thread.Sleep(1000);
            }
        }
    }
}
