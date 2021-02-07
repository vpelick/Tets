using InputSimulatorStandard;
using InputSimulatorStandard.Native;
using System;
using System.Runtime.InteropServices;
using System.Threading;


namespace Tets
{
    class Inputs
    {
        public InputSimulator input = new InputSimulator();
        public Inputs()
        {
            input = new InputSimulator();
        }

        public void Click()
        {
            input.Mouse.RightButtonDown();
            input.Mouse.RightButtonUp();
        }

        public void PressArrowLeftDown()
        {
            while (true)
            {
                if (Console.CapsLock)
                {
                    input.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    Thread.Sleep(50);
                }
            }

        }


        public void ContinuousDamage()
        {
            double x = 0;
            double y = 500*65535/899; ;
            while (true)
            {
                if (Console.CapsLock)
                {
                    for (int i = 700; i <= 1000; i=i+5)
                    {
                        x=i * 65535 / 1599;

                        input.Mouse.MoveMouseTo(x, y);
                        
                        Thread.Sleep(1);
                    }

                    for (int i = 1000; i >= 700; i=i-5)
                    {
                        x = i * 65535 / 1599;
                        input.Mouse.MoveMouseTo(x, y);
                        Thread.Sleep(1);
                    }

                    Thread.Sleep(20000);
                }
                Thread.Sleep(1000);
            }
        }

        public void PressKeyBoard(VirtualKeyCode vKey)
        {
            input.Keyboard.KeyDown(vKey);
            Thread.Sleep(500);
            input.Keyboard.KeyUp(vKey);
        }
    }
}
