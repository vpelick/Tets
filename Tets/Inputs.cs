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
            input.Keyboard.KeyDown(VirtualKeyCode.LEFT);
        }

        public void PressArrowLeftUp()
        {
            input.Keyboard.KeyUp(VirtualKeyCode.LEFT);
        }


        public void ContinuousDamage()
        {
            PressArrowLeftDown();
            while (Console.CapsLock)
            {
                for (int  i= 900; i <= 1000; i++)
                {
                    input.Mouse.MoveMouseTo(i, 500);
                    Thread.Sleep(10);
                }

                for (int i = 1000; i >= 900; i--)
                {
                    input.Mouse.MoveMouseTo(i, 500);
                    Thread.Sleep(10);
                }

                Thread.Sleep(20000);
            }
            //PressArrowLeftUp();
        }

    }
}
