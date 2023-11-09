using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro.Actions
{
    public class KeyboardAction : Action
    {
        public event EventHandler SubmitButtonClicked;

        public enum KeyboardActionType
        {
            PressAndRelease,
            HoldAndRelease
        }

        public KeyboardAction(string value, string description, KeyboardActionType type, int holdTime = 0)
        {
            ActionType = ActionType.Keyboard;
            Value = value;
            Description = description;
            HoldTime = holdTime;
            keyboardActionType = type;
        }

        public KeyboardActionType keyboardActionType;
    }
}