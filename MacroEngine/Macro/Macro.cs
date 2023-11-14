using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Macro
{
    public struct Value
    {
        public float x, y;
        public int delay;
        public string key;

        public override string ToString()
        {
            string output = "";
            if (x != 0.0 && y != 0.0)
            {
                output += $"[x: {x}, y: {y}]";
            }
            if (delay != 0)
            {
                output += $"[delay: {delay}ms]";
            }
            if(!string.IsNullOrEmpty(key))
            {
                output += $"[key: {key}]";
            }

            return output;
        }
    }
    
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

        public void Play()
        {
            foreach(Action action in actionList)
            {
                action.Execute();
            }
            MessageBox.Show("Finished!");
        }
    }
}
