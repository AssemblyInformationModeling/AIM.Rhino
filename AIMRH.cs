using System;
using Rhino.PlugIns;
using RhinoWindows.Controls;

namespace AIM_RH
{

    public class AIMRH : Rhino.PlugIns.PlugIn
    {

        private TimelineDockBar timeline_bar;

        public AIMRH()
        {
            Instance = this;
        }

        ///<summary>Gets the only instance of the AIMRH plug-in.</summary>
        public static AIMRH Instance
        {
            get; private set;
        }

        protected override LoadReturnCode OnLoad(ref string errorMessage)
        {
            CreateMyDockBar();
            return base.OnLoad(ref errorMessage);
        }

        private void CreateMyDockBar()
        {
            var create_options = new DockBarCreateOptions
            {
                DockLocation = DockBarDockLocation.Bottom,
                Visible = false,
                DockStyle = DockBarDockStyle.Any,
                FloatPoint = new System.Drawing.Point(100, 100)
            };

            timeline_bar = new TimelineDockBar();
            timeline_bar.Create(create_options);
        }
    }

}