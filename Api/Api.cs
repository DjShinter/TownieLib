using System;
using System.Collections.Generic;
using System.Text;

namespace TownieLib.Api
{
    public static partial class TownieApi
    {
        public static event EventHandler LateInit = delegate { };

        internal static void InvokeLateInit()
        {
#if DEBUG
			LoadedHopLib.LogInfo($"Invoking {nameof(LateInit)}");
#endif
            LateInit.Invoke(null, null);
        }
    }

}
