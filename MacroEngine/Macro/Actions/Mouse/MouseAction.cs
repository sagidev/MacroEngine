using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro.Actions
{
    public class MouseAction : Action
    {
        public enum MouseActionType
        {
            None,
            Move,
            Drag,
            Hold,
            Press
        }

        public enum MouseActionKey
        {
            None,
            Left,
            Middle,
            Right
        }

        public MouseAction(string value, string description, MouseActionType type)
        {
            ActionType = ActionType.Mouse;
            Value = value;
            Description = description;
            mouseActionType = type;
        }

        public MouseActionType mouseActionType = MouseActionType.None;
    }
}