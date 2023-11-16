using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro.Actions
{
    public class DelayAction : Action
    {
        public DelayAction(Value _value, string description, int holdTime = 0)
        {
            actionType = ActionType.Wait;
            value = _value;
            Description = description;
            HoldTime = holdTime;
        }
        public override void Execute()
        {
            System.Threading.Thread.Sleep(value.delay);
        }
    }
}