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
            KeyUp,
            KeyDown,
            PressAndRelease,
            HoldAndRelease,
            Combo
        }

        public KeyboardAction(Value _value, string description, KeyboardActionType type, int holdTime = 0)
        {
            actionType = ActionType.Keyboard;
            value = _value;
            Description = description;
            HoldTime = holdTime;
            keyboardActionType = type;
        }

        private void ExecuteKeyPress()
        {
            if (value.key == "None")
                return;

            Input.Keyboard.PressKey(value.key);
        }

        private void ExecuteKeyHold()
        {
            if (value.key == "None" || value.delay == 0)
                return;

            Input.Keyboard.HoldKey(value.key, value.delay);
        }

        private void ExecuteKeyDown()
        {
            Input.Keyboard.KeyDown(value._key);
        }

        private void ExecuteKeyUp()
        {
            Input.Keyboard.KeyUp(value._key);
        }

        public override void Execute()
        {
            switch (keyboardActionType)
            {
                case KeyboardActionType.PressAndRelease:
                    ExecuteKeyPress();
                    break;

                case KeyboardActionType.HoldAndRelease:
                    ExecuteKeyHold();
                    break;

                case KeyboardActionType.KeyUp:
                    ExecuteKeyUp();
                    break;

                case KeyboardActionType.KeyDown:
                    ExecuteKeyDown();
                    break;

                default:
                    break;
            }
        }
    }
}