using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charts
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            groupBox2.Text = FunctionName2;
        }

        public string FunctionName2
        {
            get
            {
                return string.Format("f(x) = {0}*Sin({1}*x)", numericUpDown4.Value, numericUpDown5.Value);
            }
        }

        public event emptyFunction FunctionChanged;

        public double Value2(double x)
        {
            return (double)numericUpDown4.Value * Math.Sin((double)numericUpDown5.Value * x);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            groupBox2.Text = FunctionName2;
            if (FunctionChanged != null)
            {
                FunctionChanged();
            }
        }
        private void ValueChanged2(object sender, EventArgs e)
        {
            groupBox2.Text = FunctionName2;
            if (FunctionChanged != null)
            {
                FunctionChanged();
            }
        }
    }
}
