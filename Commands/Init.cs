using System;
using System.Collections.Generic;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;


namespace AIM_RH
{
    public class AIMInit : Command
    {
        public AIMInit()
        {
            Instance = this;
        }

        public static AIMInit Instance
        {
            get; private set;
        }

        public override string EnglishName
        {
            get { return "AIMInit"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            var type = typeof(Timeline);
           
            RhinoWindows.Controls.DockBar.Show(TimelineDockBar.BarId, false);

            return Rhino.Commands.Result.Success;
        }
    }
}
