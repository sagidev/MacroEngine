using MacroEngine.Macro.Actions;
using MacroEngine.Macro.Actions.Pixel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MacroEngine.Macro
{
    public static class MacroManager
    {
        public static int currentMacroIndex = 0;
        public static List<Macro> macroList;
        public static bool IsPlaying = false;

        public static void Initialize()
        {
            macroList = new List<Macro>
            {
                GenerateTemplatePixelMacro()
                //GenerateTemplateMacro2()
            };
        }

        public static void SaveMacro(int index)
        {
            var macro = macroList[index];
            string jsonString = macro.ToJson();
            using (StreamWriter writetext = new StreamWriter(macro.Name + ".json"))
            {
                writetext.WriteLine(jsonString);
            }
        }

        public static Macro ReadFromJsonFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return Macro.FromJson(jsonString);
        }

        public static Macro GenerateTemplatePixelMacro()
        {
            Macro macro = new Macro("PianoTiles macro");
            Value value1 = new Value();
            value1.hex = "000000";
            value1.tries = 150;
            value1.delay = 100;
            PixelAction pixelAction = new PixelAction(value1, "PixelSearch");
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            macro.AddAction(pixelAction);
            return macro;
        }

        public static Macro GenerateTemplateMacro()
        {
            Macro macro = new Macro("KeyboardTemplate");
            Value value1 = new Value();
            value1.key = "K";
            Value value2 = new Value();
            value2.key = "D";
            value2.delay = 1000;
            KeyboardAction k1 = new KeyboardAction(value1, "Press", KeyboardAction.KeyboardActionType.PressAndRelease);
            KeyboardAction k2 = new KeyboardAction(value2, "Hold", KeyboardAction.KeyboardActionType.HoldAndRelease);
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