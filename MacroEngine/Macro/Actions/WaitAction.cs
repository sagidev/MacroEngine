using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro.Actions
{
    public class WaitAction : Action
    {
        public WaitAction(int milliseconds, string description)
        {
            ActionType = ActionType.Wait;
            Value = milliseconds.ToString();
            Description = description;
        }
    }
}
