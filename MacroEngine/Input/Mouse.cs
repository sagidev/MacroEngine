using MacroEngine.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Input
{
    public enum MouseButton
    {
        Left,
        Middle,
        Right
    }
    internal class Mouse
    {
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        public static void MoveMouse(float x, float y)
        {
            int screenX = (int)(x * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width);
            int screenY = (int)(y * 65535 / System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
            NativeImports.mouse_event(MOUSEEVENTF_MOVE, screenX, screenY, 0, 0);
        }

        public static void PressMouseButton(MouseButton button)
        {
            uint flagsDown = 0;
            uint flagsUp = 0;

            switch (button)
            {
                case MouseButton.Left:
                    flagsDown = MOUSEEVENTF_LEFTDOWN;
                    flagsUp = MOUSEEVENTF_LEFTUP;
                    break;
                case MouseButton.Middle:
                    flagsDown = MOUSEEVENTF_MIDDLEDOWN;
                    flagsUp = MOUSEEVENTF_MIDDLEUP;
                    break;
                case MouseButton.Right:
                    flagsDown = MOUSEEVENTF_RIGHTDOWN;
                    flagsUp = MOUSEEVENTF_RIGHTUP;
                    break;
            }

            NativeImports.mouse_event(flagsDown, 0, 0, 0, 0);
            NativeImports.mouse_event(flagsUp, 0, 0, 0, 0);
        }
    }
}
