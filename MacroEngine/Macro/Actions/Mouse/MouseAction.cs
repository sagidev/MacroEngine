using MacroEngine.Input;
using Newtonsoft.Json;
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
            Press,
            MouseDown,
            MouseUp
        }

        public MouseAction(Value _value, string description, MouseActionType type)
        {
            actionType = ActionType.Mouse;
            this.value = _value;
            Description = description;
            mouseActionType = type;
        }

        private void ExecuteMouseMove()
        {
            if (value.x == 0 || value.y == 0)
                return;

            Input.Mouse.MoveMouse(value.x, value.y);
        }

        private void ExecuteMousePress()
        {
            if (value.key == MouseButton.None.ToString())
                return;

            MouseButton key;
            switch (value.key.ToString())
            {
                case "Left":
                    key = MouseButton.Left;
                    break;

                case "Middle":
                    key = MouseButton.Middle;
                    break;

                case "Right":
                    key = MouseButton.Right;
                    break;

                default:
                    key = MouseButton.None;
                    break;
            }
            if (key == MouseButton.None)
                return;

            Input.Mouse.PressMouse(key);
        }

        private void ExecuteMouseDrag()
        {
        }

        private void ExecuteMouseHold()
        {
        }

        private void ExecuteMouseDown()
        {
            if (value.key == MouseButton.None.ToString())
                return;

            MouseButton key;
            switch (value.key.ToString())
            {
                case "Left":
                    key = MouseButton.Left;
                    break;

                case "Middle":
                    key = MouseButton.Middle;
                    break;

                case "Right":
                    key = MouseButton.Right;
                    break;

                default:
                    key = MouseButton.None;
                    break;
            }
            Input.Mouse.MoveMouse(value.x, value.y);
            Input.Mouse.MouseDown(key);
        }

        private void ExecuteMouseUp()
        {
            if (value.key == MouseButton.None.ToString())
                return;

            MouseButton key;
            switch (value.key.ToString())
            {
                case "Left":
                    key = MouseButton.Left;
                    break;

                case "Middle":
                    key = MouseButton.Middle;
                    break;

                case "Right":
                    key = MouseButton.Right;
                    break;

                default:
                    key = MouseButton.None;
                    break;
            }
            Input.Mouse.MoveMouse(value.x, value.y);
            Input.Mouse.MouseUp(key);
        }

        public override void Execute()
        {
            switch (mouseActionType)
            {
                case MouseActionType.Move:
                    ExecuteMouseMove();
                    break;

                case MouseActionType.Press:
                    ExecuteMousePress();
                    break;

                case MouseActionType.Drag:
                    ExecuteMouseDrag();
                    break;

                case MouseActionType.Hold:
                    ExecuteMouseHold();
                    break;

                case MouseActionType.MouseDown:
                    ExecuteMouseDown();
                    break;

                case MouseActionType.MouseUp:
                    ExecuteMouseUp();
                    break;

                default:
                    break;
            }
        }

        public MouseActionType mouseActionType = MouseActionType.None;
        public MouseButton mouseActionKey = MouseButton.None;
    }
}