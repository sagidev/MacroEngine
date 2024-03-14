using MacroEngine.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

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
            if (value.x == 0 || value.y == 0)
                return;

            if (value.delay <= 0)
                return;

            float endX = value.x;
            float endY = value.y;
            float startX = Cursor.Position.X;
            float startY = Cursor.Position.Y;

            const int steps = 100;
            float deltaX = (endX - startX) / steps;
            float deltaY = (endY - startY) / steps;

            for (int i = 0; i <= steps; i++)
            {
                float currentX = startX + deltaX * i;
                float currentY = startY + deltaY * i;
                Input.Mouse.MoveMouse(currentX, currentY);
                System.Threading.Thread.Sleep(value.delay / steps);
            }
        }

        private void ExecuteMouseHold()
        {
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
            Input.Mouse.MouseDown(key);
            System.Threading.Thread.Sleep(value.delay);
            Input.Mouse.MouseUp(key);
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