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

        public KeyboardAction(Value _value, string description, KeyboardActionType type, string key, int holdTime = 0)
        {
            actionType = ActionType.Keyboard;
            value = _value;
            Description = description;
            HoldTime = holdTime;
            keyboardActionType = type;
            keyboardKey = key;
        }
    }
}