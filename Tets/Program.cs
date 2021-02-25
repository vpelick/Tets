using InputSimulatorStandard;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;



namespace Tets
{
    class Program
    {
    
        public static void Main(string[] args)
        {

            /*
            Xama xam = new Xama();

            xam.Run();
            *
            *
            */
            Mago mag = new Mago();

            mag.Run();




        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            // NOTE: If you need error handling
            // bool success = GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }
    }
}
