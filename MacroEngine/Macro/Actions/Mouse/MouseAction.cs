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

        public MouseAction(Value _value, string description, MouseActionType type)
        {
            actionType = ActionType.Mouse;
            this.value = _value;
            Description = description;
            mouseActionType = type;
        }

        public override void Execute()
        {
            switch (mouseActionType)
            {
                case MouseActionType.Move:
                    break;
                case MouseActionType.Press:
                    break;
                case MouseActionType.Drag:
                    break;
                case MouseActionType.Hold:
                    break;
                default:
                    break;
            }   
        }

        public MouseActionType mouseActionType = MouseActionType.None;
    }
}