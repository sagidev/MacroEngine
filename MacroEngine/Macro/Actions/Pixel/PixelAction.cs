using MacroEngine.PixelColors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroEngine.Macro.Actions.Pixel
{
    public class PixelAction : Action
    {
        private int numberOfTries = 5;
        public Color Pixel_Color;
        public static Rectangle screenRect;

        public PixelAction(Value _value, string description)
        {
            actionType = ActionType.Search;
            value = _value;
            Description = description;
            Pixel_Color = ColorTranslator.FromHtml("#" + value.hex);
        }

        public static Action FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Action>(json);
        }

        public override void Execute()
        {
            numberOfTries = value.tries;
            screenRect = new Rectangle(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            int tries = 0;
            while (tries < numberOfTries)
            {
                var points = PixelSearch.Search(screenRect, Pixel_Color, 0);
                if (points.Length > 0)
                {
                    Input.Mouse.MoveMouse(points[0].X, points[0].Y);
                    MessageBox.Show("Found pixel at: " + points[0].X + ", " + points[0].Y);
                    break;
                }
                tries++;
                Thread.Sleep(value.delay);
            }
        }
    }
}