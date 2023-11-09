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
            KeyboardAction k1 = new KeyboardAction("K", "Press", KeyboardAction.KeyboardActionType.PressAndRelease, 0);
            KeyboardAction k2 = new KeyboardAction("D", "Hold", KeyboardAction.KeyboardActionType.HoldAndRelease, 1000);
            macro.AddAction(k1);
            macro.AddAction(k2);

            return macro;
        }
    }
}
