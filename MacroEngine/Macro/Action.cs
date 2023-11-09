using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro
{
    public enum ActionType
    {
        Keyboard,
        Mouse,
        Wait,
        Repeat,
        Search
    }
    
    public class Action
    {
        public ActionType ActionType;
        public string Value;
        public string Description;
        public int HoldTime;
    }
}
