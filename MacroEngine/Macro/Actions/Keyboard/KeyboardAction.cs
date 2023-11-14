using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro.Actions
{
    public class KeyboardAction : Action
    {
        public KeyboardActionType keyboardActionType = KeyboardActionType.None;
        public string keyboardKey = "None";

        public enum KeyboardActionType
        {
            None,
            PressAndRelease,
            HoldAndRelease
        }

        public KeyboardAction(string value, string description, KeyboardActionType type, string key, int holdTime = 0)
        {
            ActionType = ActionType.Keyboard;
            Value = value;
            Description = description;
            HoldTime = holdTime;
            keyboardActionType = type;
            keyboardKey = key;
        }

        public int KeyboardKeyToInt(string key)
        {
            
        }
    }
}