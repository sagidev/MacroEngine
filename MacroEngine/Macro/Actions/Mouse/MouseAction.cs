using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro.Actions
{
    public class MouseAction : Action
    {
        public MouseAction(string value, string description)
        {
            ActionType = ActionType.Mouse;
            Value = value;
            Description = description;
        }
    }
}
