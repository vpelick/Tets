using System;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;

namespace Tets
{
    class Program
    {
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        static void Main(string[] args)
        {
            while (true)
            {
                if (Console.CapsLock)
                {
                    Console.WriteLine("ATIVO");
                    //MouseSimulator.MouseDown(MouseButton.Left);

                    // Let Left Mouse Button Up
                    //MouseSimulator.MouseUp(MouseButton.Left);

                    

                }
                ClickRightMouseButtonMouseEvent();
                Thread.Sleep(1000);
            }
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private static void ClickLeftMouseButtonMouseEvent()
        {
            //Send a left click down followed by a left click up to simulate a  
            //full left click  
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private static void ClickRightMouseButtonMouseEvent()
        {
            //Send a left click down followed by a right click up to simulate a  
            //full right click  
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }
    }
}
