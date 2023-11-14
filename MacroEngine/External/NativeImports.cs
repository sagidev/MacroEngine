using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.External
{
    internal class NativeImports
    {
        //keybd_event
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
    }
}
