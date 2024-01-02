using Gma.System.MouseKeyHook;
using MacroEngine.Input;
using MacroEngine.Macro.Actions;
using MacroEngine.Macro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MacroEngine.Macro.Actions.KeyboardAction;
using System.Security.Cryptography;
using static MacroEngine.Macro.Actions.MouseAction;

namespace MacroEngine.External
{
    public static class Hooks
    {
        public static event EventHandler UpdateDataGridEvent;

        public const Keys Key_Play = Keys.F10;
        public const Keys Key_Record = Keys.F9;
        public const Keys Key_Stop = Keys.F8;

        public static bool IsHolding = false;
        public static bool IsRecording = false;

        public static bool IsHooked = false;

        private static IKeyboardMouseEvents m_GlobalHook;

        private static long lastTimeStamp = 0;

        public static void Initialize()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += GlobalShortcutHandler;
        }

        public static void ResetTimeStamp()
        {
            lastTimeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        public static void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt += GlobalHookMouseUpExt;

            m_GlobalHook.KeyDown += GlobalHookKeyDown;
            m_GlobalHook.KeyUp += GlobalHookKeyUp;
        }

        public static void Unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt -= GlobalHookMouseUpExt;

            m_GlobalHook.KeyDown -= GlobalHookKeyDown;
            m_GlobalHook.KeyUp -= GlobalHookKeyUp;

            m_GlobalHook.Dispose();
        }

        private static void GlobalShortcutHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Key_Stop && MacroManager.macroList.Count > 0 && MacroManager.IsPlaying)
            {
                MacroManager.IsPlaying = false;
                return;
            }

            if (e.KeyCode == Key_Play && MacroManager.macroList.Count > 0)
            {
                MacroManager.macroList[MacroManager.currentMacroIndex].Play();
                return;
            }

            if (e.KeyCode == Key_Record)
            {
                if (IsRecording)
                {
                    IsRecording = false;
                    Unsubscribe();
                }
                else
                {
                    IsRecording = true;
                    Subscribe();
                }
            }
        }

        private static void GlobalHookKeyDown(object sender, KeyEventArgs e)
        {
            if (IsHolding)
                return;

            if (e.KeyCode == Key_Record)
            {
                return;
            }

            Value value = new Value();
            value.key = e.KeyCode.ToString();
            value._key = e.KeyCode;

            var timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            value.delay = (int)(timestamp - lastTimeStamp);
            lastTimeStamp = timestamp;

            KeyboardAction action = new KeyboardAction(value, "KeyDown", KeyboardActionType.KeyDown);
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            UpdateDataGridEvent?.Invoke(sender, EventArgs.Empty);
            IsHolding = true;
        }

        private static void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Key_Record)
            {
                return;
            }

            Value value = new Value();
            value.key = e.KeyCode.ToString();
            value._key = e.KeyCode;
            var timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            value.delay = (int)(timestamp - lastTimeStamp);
            lastTimeStamp = timestamp;

            KeyboardAction action = new KeyboardAction(value, "KeyUp", KeyboardActionType.KeyUp);
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            UpdateDataGridEvent?.Invoke(sender, EventArgs.Empty);

            IsHolding = false;
        }

        private static void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            Console.WriteLine("MouseDown: \t{0}; \t System Timestamp: \t{1}", e.Button, e.Timestamp);

            Value value = new Value();
            value.key = e.Button.ToString();
            var timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            value.delay = (int)(timestamp - lastTimeStamp);
            lastTimeStamp = timestamp;

            value.x = e.X;
            value.y = e.Y;

            MouseAction action = new MouseAction(value, "MouseDown", MouseActionType.MouseDown);
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            UpdateDataGridEvent?.Invoke(sender, EventArgs.Empty);
        }

        private static void GlobalHookMouseUpExt(object sender, MouseEventExtArgs e)
        {
            Value value = new Value();
            value.key = e.Button.ToString();
            var timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            value.delay = (int)(timestamp - lastTimeStamp);
            lastTimeStamp = timestamp;

            value.x = e.X;
            value.y = e.Y;

            MouseAction action = new MouseAction(value, "MouseUp", MouseActionType.MouseUp);
            MacroManager.macroList[MacroManager.currentMacroIndex].actionList.Add(action);
            UpdateDataGridEvent?.Invoke(sender, EventArgs.Empty);
        }
    }
}