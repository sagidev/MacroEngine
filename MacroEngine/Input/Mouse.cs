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
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;

        private static bool hasClicked = false;

        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (!Hooks.IsHooked)
            {
                Hooks.Unhook();
                return IntPtr.Zero;
            }
            if (Hooks.IsHooked && nCode >= 0 && wParam == (IntPtr)NativeImports.WM_LBUTTONDOWN)
            {
                // Extract mouse position
                NativeImports.MSLLHOOKSTRUCT hookStruct =
                    (NativeImports.MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(NativeImports.MSLLHOOKSTRUCT));
                int x = hookStruct.pt.x;
                int y = hookStruct.pt.y;

                // Do something with the mouse position
                MessageBox.Show($"Mouse clicked outside the application at X: {x}, Y: {y}, : {hasClicked}");

                hasClicked = true;
                
                // Unhook the mouse event
                Hooks.Unhook();
            }

            return IntPtr.Zero;
            //return NativeImports.CallNextHookEx(NativeImports.WH_MOUSE_LL, nCode, wParam, lParam);
        }

        public static void MoveMouse(float x, float y)
        {
            NativeImports.SetCursorPos((int)x, (int)y);
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

        public static bool IsLeftMouseButtonClicked()
        {
            // Check if the left mouse button is pressed
            return (Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left;
        }
    }
}
