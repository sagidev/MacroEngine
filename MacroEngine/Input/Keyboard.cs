using MacroEngine.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Input
{
    public static class Keyboard
    {
        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;

        public static void PressKey(string keyName)
        {
            try
            {
                byte keyCode = (byte)Enum.Parse(typeof(Keys), keyName);
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY, 0);
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_KEYUP, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error simulating key press: {ex.Message}");
            }
        }

        public static void KeyDown(Keys key)
        {
            try
            {
                byte keyCode = (byte)key;
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error simulating key down: {ex.Message}");
            }
        }

        public static void KeyDown(string keyName)
        {
            try
            {
                byte keyCode = (byte)Enum.Parse(typeof(Keys), keyName);
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error simulating key down: {ex.Message}");
            }
        }

        public static void KeyUp(Keys key)
        {
            try
            {
                byte keyCode = (byte)key;
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_KEYUP, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error simulating key up: {ex.Message}");
            }
        }

        public static void KeyUp(string keyName)
        {
            try
            {
                byte keyCode = (byte)Enum.Parse(typeof(Keys), keyName);
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_KEYUP, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error simulating key up: {ex.Message}");
            }
        }

        public static void HoldKey(string keyName, int delay)
        {
            try
            {
                byte keyCode = (byte)Enum.Parse(typeof(Keys), keyName);
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_EXTENDEDKEY, 0);
                Thread.Sleep(delay);
                NativeImports.keybd_event(keyCode, 0, KEYEVENTF_KEYUP, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error holding key: {ex.Message}");
            }
        }
    }
}