using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace charts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.ChartAreas.First().AxisX.Crossing = 0.0;
            chart1.ChartAreas.First().AxisY.Crossing = 0.0;

            chart1.ChartAreas.First().AxisX.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas.First().AxisY.MajorGrid.LineColor = Color.LightGray;

            chart1.ChartAreas.First().AxisX.ArrowStyle = AxisArrowStyle.SharpTriangle;
            chart1.ChartAreas.First().AxisY.ArrowStyle = AxisArrowStyle.SharpTriangle;

            button1_Click(null, null);
            functionChanged();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 newPolynomial = new UserControl1();
            flowLayoutPanel.Controls.Add(newPolynomial);

            newPolynomial.FunctionChanged += functionChanged;
            functionChanged();
        }

        private void functionChanged()
        {
            chart1.Series.Clear();
            int i = 1;
            foreach (IFunction f in flowLayoutPanel.Controls)
            {
                Series s = new Series();
                s.Name = i.ToString() + ". " + f.FunctionName;
                i++;
                s.ChartType = SeriesChartType.Line;

                for (double x = -9.9; x <= 10; x += 0.1)
                {
                    s.Points.AddXY(x, f.Value(x));
                }

                chart1.Series.Add(s);
            }
            chart1.ChartAreas.First().RecalculateAxesScale();
        }
    }
}
