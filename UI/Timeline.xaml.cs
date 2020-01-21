using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Annotations;


namespace AIM_RH
{

    public partial class Timeline : UserControl
    {
        public Timeline()
        {
            InitializeComponent();
            Visibility = Visibility.Visible;
        }
        
    }

    /*
    public class MainViewModel
    {

        public PlotModel MyModel { get; private set; }

        public MainViewModel()
        {
            //this.MyModel = new PlotModel { Title = "Example 1" };
            //this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));

            MyModel = GeneratePlot();

        }

        public static PlotModel GeneratePlot()
        {

            var model = new PlotModel();
            
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

            return model;

        }

    }

    */
}
