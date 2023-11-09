using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro
{
    public class Macro
    {
        public Macro(string name)
        {
            actionList = new List<Action>();
            Name = name;
        }
        public List<Action> actionList;
        public string Name;

        public void AddAction(Action action)
        {
            actionList.Add(action);
        }
    }
}
