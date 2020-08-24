using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MonitorWaker_v0._1
{
    class CursorMove
    {
        private int time;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        // IMPORT DLL for mouse events
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        /*Variable for pressing left mouse button*/
        //private const int MouseButton_LeftDown = 0x02;
        //private const int MouseButton_LeftUp = 0x04;

        /*Variable for pressing right mouse button*/
        //private const int MouseButton_RightDown = 0x08;
        //private const int MouseButton_RightUp  = 0x10;

        public CursorMove()
        {

        }
        public CursorMove(int time)
        {
            this.time = time;
        }

        public void CursorEvent()
        {
            Cursor.Current = new Cursor(Cursor.Current.Handle);
            Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
            for (int i = 0; i < time; i++)
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    break;
                }

                point.X += 1;
                point.Y += 1;
                Cursor.Position = point;
                mouse_event(0, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                System.Threading.Thread.Sleep(500);

                point.X -= 1;
                point.Y -= 1;
                Cursor.Position = point;
                System.Threading.Thread.Sleep(500);
            }

        }


        private int timeCounter = 0;

        public void CursorEvent2()
        {
            Cursor.Current = new Cursor(Cursor.Current.Handle);
            Point point = new Point(Cursor.Position.X, Cursor.Position.Y);
            
            while (true)
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    break;
                }

                point.X += 1;
                point.Y += 1;
                Cursor.Position = point;
                mouse_event(0, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                System.Threading.Thread.Sleep(500);

                point.X -= 1;
                point.Y -= 1;
                Cursor.Position = point;
                System.Threading.Thread.Sleep(500);

                timeCounter++;
            }
        }

    }
}
