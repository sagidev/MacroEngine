using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroEngine.External
{
    public class DelayedAction
    {
        private List<(Action, DateTime)> delayedFunctions = new List<(Action, DateTime)>();

        public void Add<TFunc, TArgs>(TFunc func, int delayMs, params TArgs[] args)
            where TFunc : Delegate
        {
            DateTime currentTime = DateTime.UtcNow;
            DateTime targetTime = currentTime + TimeSpan.FromMilliseconds(delayMs);
            Action boundFunc = () => func.DynamicInvoke(args);
            delayedFunctions.Add((boundFunc, targetTime));
        }

        public void Update()
        {
            DateTime currentTime = DateTime.UtcNow;

            for (int i = delayedFunctions.Count - 1; i >= 0; i--)
            {
                if (delayedFunctions[i].Item2 <= currentTime)
                {
                    delayedFunctions[i].Item1();
                    delayedFunctions.RemoveAt(i);
                }
            }
        }

        public bool IsUsed { get; set; } = false;
    }
}
