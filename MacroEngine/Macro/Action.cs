using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public ActionType actionType;
        public Value value;
        public string Description;

        public virtual void Execute()
        {
            MessageBox.Show("Action is missing a definition!");
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Action FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Action>(json);
        }

        public override string ToString()
        {
            return $"{actionType} {value}";
        }
    }
}