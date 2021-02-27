using InputSimulatorStandard;
using InputSimulatorStandard.Native;
using System;
using System.Runtime.InteropServices;
using System.Threading;


namespace Tets
{
    class Priest
    {
        Inputs input;
        public Priest() 
        {
            input = new Inputs();
        }

        public void Run()
        {
            int vlCount = 0;
            int asinhaCount = 0;
            int anjoCount = 0;
            int absCount = 0;
            int reflectCount = 0;
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
                    vlCount++;
                    asinhaCount++;
                    anjoCount++;
                    absCount++;
                    reflectCount++;
                    stamPot++;

                    if (vlCount == 25)
                    {
                        vlCount = 0;
                        vlBuff();
                    }

                    if (asinhaCount == 30)
                    {
                        asinhaCount = 0;
                        asinhaBuff();
                    }

                    if (anjoCount == 32)
                    {
                        anjoCount = 0;
                        anjoBuff();
                    }

                    if (absCount == 34)
                    {
                        absCount = 0;
                        absBuff();
                    }

                    if (reflectCount == 36)
                    {
                        reflectCount = 0;
                        reflectBuff();
                    }

                    if (stamPot == 35)
                    {
                        stamPot = 0;
                        stamCount++;
                        if (stamCount <= 99)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_3);
                        }

                        if(stamCount > 99 && stamCount <= 198)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_2);
                        }

                        if (stamCount > 198 && stamCount  <= 297)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_1);
                        }
                    }

                    Thread.Sleep(900);

                }
                else
                {
                    vlCount = 0;
                    asinhaCount = 0;
                    anjoCount = 0;
                    absCount = 0;
                    reflectCount=0;
                    stamPot = 0;
                    stamCount = 0;
                }
            }
        }

        public void vlBuff()
        {
            input.PressKeyBoard(VirtualKeyCode.F1);
            for(int i = 0; i < 3; i++)
            {
                input.Click();
                Thread.Sleep(200);
                input.Click();
                Thread.Sleep(400);
            }
            input.PressKeyBoard(VirtualKeyCode.F2);
        }

        public void asinhaBuff()
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

        public void anjoBuff()
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

        public void absBuff()
        {
            input.PressKeyBoard(VirtualKeyCode.F6);
            for (int i = 0; i < 3; i++)
            {
                input.Click();
                Thread.Sleep(200);
                input.Click();
                Thread.Sleep(400);
            }
            input.PressKeyBoard(VirtualKeyCode.F2);
        }

        public void reflectBuff()
        {
            input.PressKeyBoard(VirtualKeyCode.F7);
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
