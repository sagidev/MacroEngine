using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Macro
{
    public struct Value
    {
        public float x, y;
        public int delay;
        public string key;
        public Keys _key;
        public int r, g, b;
        public string hex;
        public int tries;

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
            if (!string.IsNullOrEmpty(key))
            {
                output += $"[key: {key}]";
            }
            if (_key != Keys.None)
            {
                output += $"[key: {_key}]";
            }
            if (r != 0 && g != 0 && b != 0)
            {
                output += $"[r: {r}, g: {g}, b: {b}]";
            }
            if (!string.IsNullOrEmpty(hex))
            {
                output += $"[hex: #{hex}]";
            }
            if (tries != 0)
            {
                output += $"[tries: {tries}]";
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
            foreach (Action action in actionList)
            {
                action.Execute();
                Thread.Sleep(action.value.delay);
            }
            MessageBox.Show("Finished!");
        }
    }
}