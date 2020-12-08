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
using System.Windows.Shapes;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Microsoft.Win32;

namespace Laba1
{
    /// <summary>
    /// Interaction logic for hist.xaml
    /// </summary>
    public partial class hist : Window
    {




        public hist()
        {
            InitializeComponent();

        }

        public void CreatingHistogram(ArrayList myAL)
        {
            chart.ChartAreas.Add(new ChartArea("Default"));
            chart.Series.Add(new Series("Series1"));
            chart.Series["Series1"].ChartArea = "Default";
            chart.Series["Series1"].ChartType = SeriesChartType.Column;

            for (int index = 0; index < myAL.Count; index++)
            {
                chart.Series["Series1"].Points.AddXY(index + 1, (int)myAL[index]);
            }
        }


    }
}
