using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro.Actions
{
    public class DelayAction : Action
    {
        public DelayAction(string value, string description, int holdTime = 0)
        {
            ActionType = ActionType.Wait;
            Value = value;
            Description = description;
            HoldTime = holdTime;
        }
    }
}