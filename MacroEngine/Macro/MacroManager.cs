using MacroEngine.Macro.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.Macro
{
    public static class MacroManager
    {
        public static int currentMacroIndex = 0;
        public static List<Macro> macroList;

        public static void Initialize()
        {
            macroList = new List<Macro>();
            macroList.Add(GenerateTemplateMacro());
        }

        public static Macro GenerateTemplateMacro()
        {
            Macro macro = new Macro("Template");
            Value value1 = new Value();
            value1.key = "K";
            Value value2 = new Value();
            value2.key = "D";
            KeyboardAction k1 = new KeyboardAction(value1, "Press", KeyboardAction.KeyboardActionType.PressAndRelease, "K", 0);
            KeyboardAction k2 = new KeyboardAction(value2, "Hold", KeyboardAction.KeyboardActionType.HoldAndRelease, "D", 1000);
            macro.AddAction(k1);
            macro.AddAction(k2);

            return macro;
        }
    }
}