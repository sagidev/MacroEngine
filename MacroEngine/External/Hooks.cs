using MacroEngine.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.External
{
    public class Hooks
    {
        public static bool IsHooked = false;
        public static void SetHook()
        {
            NativeImports.SetWindowsHookEx(NativeImports.WH_MOUSE_LL, Mouse.HookCallback, NativeImports.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
            IsHooked = true;
        }

        public static void Unhook()
        {
            NativeImports.UnhookWindowsHookEx(NativeImports.WH_MOUSE_LL);
            IsHooked = false;
        }
    }
}
