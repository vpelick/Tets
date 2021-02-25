using InputSimulatorStandard;
using InputSimulatorStandard.Native;
using System;
using System.Runtime.InteropServices;
using System.Threading;


namespace Tets
{
    class Mago
    {
        Inputs input;
        public Mago() 
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
            int meteoroCount = 0;
            int watornadoCount = 0;
            int bolhaCount = 0;
            int buffCount1 = 0;
            int buffCount2 = 0;
            int stamPot = 0;
            int stamCount = 0;
            Thread thDamage = new Thread(input.ContinuousDamage);
            Thread thLeft = new Thread(input.PressArrowLeftDown);
            thDamage.Start();
            thLeft.Start();
            while (true)
            {
                if (Console.CapsLock)
                {
                    input.Click();
                    meteoroCount++;
                    watornadoCount++;
                    bolhaCount++;
                    buffCount1++;
                    buffCount2++;
                    stamPot++;

                    if (meteoroCount == 4)
                    {
                        meteoroCount = 0;
                        meteoro();
                    }

                    if (watornadoCount == 15)
                    {
                        watornadoCount = 0;
                        watornado();
                        stamPot = stamPot + 10;
                    }

                    if (bolhaCount == 35)
                    {
                        bolhaCount = 0;
                        def();
                    }

                    if (buffCount1 == 50)
                    {
                        buffCount1 = 0;
                        buff();
                    }

                    if (buffCount2 == 50)
                    {
                        buffCount2 = 0;
                        buff2();
                    }

                    if (stamPot == 25)
                    {
                        stamPot = 0;
                        stamCount++;
                        if (stamCount <= 95)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_3);
                        }
                        
                        if(stamCount >95 && stamCount <= 190)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_2);
                        }

                        if (stamCount > 190 && stamCount <= 285)
                        {
                            input.PressKeyBoard(VirtualKeyCode.VK_1);
                        }

                        if (stamCount == 285)
                        {
                            stamCount = 0;
                        }

                    }

                    Thread.Sleep(900);

                }
                else
                {
                    meteoroCount = 0;
                    watornadoCount = 0;
                    bolhaCount = 0;
                    buffCount1 = 0;
                    buffCount2 = 0;
                    stamPot = 0;
                    stamPot = 0;
                    stamCount = 0;
                }
            }
        }

        public void meteoro()
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

        public void watornado()
        {
            input.PressKeyBoard(VirtualKeyCode.F6);
            for (int i = 0; i < 10; i++)
            {
                input.Click();
                Thread.Sleep(500);
                input.Click();
                Thread.Sleep(500);
            }
            input.PressKeyBoard(VirtualKeyCode.F2);
        }

        public void def()
        {
            input.PressKeyBoard(VirtualKeyCode.F3);
            for (int i = 0; i < 5; i++)
            {
                input.Click();
                Thread.Sleep(400);
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

        public void buff2()
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
