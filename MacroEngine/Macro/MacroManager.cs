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
            macroList = new List<Macro>
            {
                GenerateTemplateMacro2()
            };
        }

        public static Macro GenerateTemplateMacro()
        {
            Macro macro = new Macro("KeyboardTemplate");
            Value value1 = new Value();
            value1.key = "K";
            Value value2 = new Value();
            value2.key = "D";
            KeyboardAction k1 = new KeyboardAction(value1, "Press", KeyboardAction.KeyboardActionType.PressAndRelease, 0);
            KeyboardAction k2 = new KeyboardAction(value2, "Hold", KeyboardAction.KeyboardActionType.HoldAndRelease, 1000);
            macro.AddAction(k1);
            macro.AddAction(k2);

            return macro;
        }

        public static Macro GenerateTemplateMacro2()
        {
            Macro macro = new Macro("MouseTemplate");
            Value value1 = new Value();
            value1.x = 50;
            value1.y = 50;
            Value value2 = new Value();
            value2.x = 250;
            value2.y = 250;
            Value value3 = new Value();
            value3.delay = 500;
            MouseAction m1 = new MouseAction(value1, "Move", MouseAction.MouseActionType.Move);
            MouseAction m2 = new MouseAction(value2, "Move", MouseAction.MouseActionType.Move);
            DelayAction d1 = new DelayAction(value3, "Delay");
            macro.AddAction(m1);
            macro.AddAction(d1);
            macro.AddAction(m2);

            return macro;
        }
    }
}