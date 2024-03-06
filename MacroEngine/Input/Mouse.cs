using MacroEngine.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Input
{
    public enum MouseButton
    {
        None,
        Left,
        Middle,
        Right
    }

    internal class Mouse
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        public static void MoveMouse(float x, float y)
        {
            NativeImports.SetCursorPos((int)x, (int)y);
        }

        public static void MouseDown(MouseButton button)
        {
            uint flags = 0;

            switch (button)
            {
                case MouseButton.Left:
                    flags = MOUSEEVENTF_LEFTDOWN;
                    break;

                case MouseButton.Middle:
                    flags = MOUSEEVENTF_MIDDLEDOWN;
                    break;

                case MouseButton.Right:
                    flags = MOUSEEVENTF_RIGHTDOWN;
                    break;
            }

            NativeImports.mouse_event(flags, 0, 0, 0, 0);
        }

        public static void MouseUp(MouseButton button)
        {
            uint flags = 0;

            switch (button)
            {
                case MouseButton.Left:
                    flags = MOUSEEVENTF_LEFTUP;
                    break;

                case MouseButton.Middle:
                    flags = MOUSEEVENTF_MIDDLEUP;
                    break;

                case MouseButton.Right:
                    flags = MOUSEEVENTF_RIGHTUP;
                    break;
            }

            NativeImports.mouse_event(flags, 0, 0, 0, 0);
        }

        public static void PressMouse(MouseButton button)
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