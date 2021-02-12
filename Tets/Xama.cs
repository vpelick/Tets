using InputSimulatorStandard;
using InputSimulatorStandard.Native;
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

        public void RunTest()
        {
            while (true)
            {
                if (Console.CapsLock)
                {
                    input.PressKeyBoard(VirtualKeyCode.F1);
                    Thread.Sleep(500);
                    input.PressKeyBoard(VirtualKeyCode.F2);
                    Thread.Sleep(500);
                    input.PressKeyBoard(VirtualKeyCode.F3);
                    Thread.Sleep(500);
                    input.PressKeyBoard(VirtualKeyCode.F4);
                    Thread.Sleep(500);
                    input.PressKeyBoard(VirtualKeyCode.F5);
                    Thread.Sleep(500);
                }
            }
        }
        public void Run()
        {
            int explosionCount = 0;
            int defCount = 0;
            int buffCount = 0;
            int speedCount = 0;
            int stamPot = 0;
            int stamCount = 0;
            Thread thDamage = new Thread(input.ContinuousDamage);
            Thread thLeft = new Thread(input.PressArrowLeftDown);
            bool flag = false;
            thDamage.Start();
            thLeft.Start();
            while (true)
            {
                if (Console.CapsLock)
                {
                    input.Click();
                    //explosionCount++;
                    defCount++;
                    buffCount++;
                    speedCount++;
                    stamPot++;

                    if (explosionCount==4)
                    {
                        explosionCount = 0;
                        explosion();
                    }

                    if (defCount==20)
                    {
                        defCount = 0;
                        def();
                    }

                    if (buffCount==21)
                    {
                        buffCount = 0;
                        buff();
                    }

                    if (speedCount==22)
                    {
                        speedCount = 0;
                        speed();
                    }

                    if (stamPot == 13)
                    {
                        stamPot = 0;
                        stamCount++;
                        if (stamCount <= 42)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_3);
                        }
                        
                        if(stamCount > 42 && stamCount <= 84)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_2);
                        }

                        if (stamCount > 84 && stamCount <= 126)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_1);
                        }

                        if (stamCount ==126)
                        {
                            stamCount = 0;
                        }

                    }

                    Thread.Sleep(600);

                }
                else
                {
                    explosionCount = 0;
                    defCount = 0;
                    buffCount = 0;
                    speedCount = 0;
                    stamPot = 0;
                    stamCount = 0;
                }
            }
        }

        public void explosion()
        {
            input.PressKeyBoard(VirtualKeyCode.F4);
            for(int i = 0; i < 3; i++)
            {
                input.Click();
                Thread.Sleep(200);
                input.Click();
                Thread.Sleep(400);
            }
            input.PressKeyBoard(VirtualKeyCode.F2);
        }

        public void def()
        {
            input.PressKeyBoard(VirtualKeyCode.F3);
            for (int i = 0; i < 3; i++)
            {
                input.Click();
                Thread.Sleep(200);
                input.Click();
                Thread.Sleep(400);
            }
            input.PressKeyBoard(VirtualKeyCode.F2);
        }

        public void buff()
        {
            input.PressKeyBoard(VirtualKeyCode.F1);
            for (int i = 0; i < 3; i++)
            {
                input.Click();
                Thread.Sleep(200);
                input.Click();
                Thread.Sleep(400);
            }
            input.PressKeyBoard(VirtualKeyCode.F2);
        }

        public void speed()
        {
            input.PressKeyBoard(VirtualKeyCode.F5);
            for (int i = 0; i < 3; i++)
            {
                input.Click();
                Thread.Sleep(200);
                input.Click();
                Thread.Sleep(400);
            }
            input.PressKeyBoard(VirtualKeyCode.F2);
        }
    }
}
