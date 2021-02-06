using InputSimulatorStandard;
using System;
using System.Runtime.InteropServices;
using System.Threading;


namespace Tets
{
    class Xama
    {
        Inputs input;
        public Xama() 
        {
            input = new Inputs();
        }

        public void Run()
        {
            Thread th = new Thread(input.ContinuousDamage);
            bool flag = false;
            while (true)
            {
                if (Console.CapsLock)
                {
                    if (!flag)
                    {
                        flag = !flag;
                        th.Start();
                    }
                }
                else
                {
                    th.Abort();
                    input.PressArrowLeftDown();
                    flag = !flag;
                }
            }
        }

    }
}
