using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Annotations;

namespace AIM_RH
{
    public class TimelineManager
    {
        public PlotModel model { get; private set; } //= new PlotModel();

        public TimelineManager()
        {
            model = new PlotModel();
            GenerateTimelineTemplate();
            PopulateTimeline();
        }

        /// <summary>
        /// Populate timeline with some data - Here just some random data, later from the ADM model
        /// </summary>
        private void PopulateTimeline()
        {
            var rectangleBarSeries1 = new RectangleBarSeries();
            rectangleBarSeries1.Title = "RectangleBarSeries 1";
            rectangleBarSeries1.Items.Add(new RectangleBarItem(2, 1, 8, 4));
            rectangleBarSeries1.Items.Add(new RectangleBarItem(6, 6, 12, 7));
            model.Series.Add(rectangleBarSeries1);

            var rectangleBarSeries2 = new RectangleBarSeries();
            rectangleBarSeries2.Title = "RectangleBarSeries 2";
            rectangleBarSeries2.Items.Add(new RectangleBarItem(2, -4, 8, -1));
            rectangleBarSeries2.Items.Add(new RectangleBarItem(6, -7, 12, -6));
            model.Series.Add(rectangleBarSeries2);
        }


        /// <summary>
        /// Generate the time line general stuff (lines, axis, line annotation and so on..)
        /// </summary>
        /// <returns></returns>
        public void GenerateTimelineTemplate()
        {

            // Generate Axis
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = -20,
                Maximum = 80
                //IsAxisVisible = false
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = -10,
                Maximum = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
                //IsAxisVisible = false
            });


            var la = new LineAnnotation { Type = LineAnnotationType.Vertical, X = 4 };
            la.MouseDown += (s, e) =>
            {
                if (e.ChangedButton != OxyMouseButton.Left)
                {
                    return;
                }

                la.StrokeThickness *= 5;
                model.InvalidatePlot(false);
                e.Handled = true;
            };

            // Handle mouse movements (note: this is only called when the mousedown event was handled)
            la.MouseMove += (s, e) =>
            {
                la.X = la.InverseTransform(e.Position).X;
                model.InvalidatePlot(false);
                e.Handled = true;
            };
            la.MouseUp += (s, e) =>
            {
                la.StrokeThickness /= 5;
                model.InvalidatePlot(false);
                e.Handled = true;
            };

            model.Annotations.Add(la);

        }
    }
}
