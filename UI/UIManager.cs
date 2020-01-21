using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.PlugIns;
using RhinoWindows.Controls;

namespace AIM_RH
{

    /// <summary>
    /// Class to create the timeline dockbar
    /// </summary>
    internal class TimelineDockBar : DockBar
    {
        public static Guid BarId => new Guid("{a7e0d232-bba2-459e-b06f-c442d125971d}");
        public TimelineDockBar() : base(AIMRH.Instance, BarId, "Assembly Simulator")
        {
            SetContentControl(new WpfHost(new Timeline(), null));
        }
    }

}
