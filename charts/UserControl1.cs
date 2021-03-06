﻿using System;
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
    public partial class UserControl1 : UserControl,IFunction
    {
        public UserControl1()
        {
            InitializeComponent();
            groupBox1.Text = FunctionName;
        }

        public string FunctionName
        {
            get
            {
                return string.Format("f(x) = {0}*x^2 + {1}*x + {2}", numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value);
            }
        }
        public string FunctionName2
        {
            get
            {
                return string.Format("f(x) = {0}*Sin({1}*x)", numericUpDown1.Value, numericUpDown2.Value);
            }
        }

        public event emptyFunction FunctionChanged;

        public double Value(double x)
        {
            return (double)numericUpDown1.Value * x * x + (double)numericUpDown2.Value * x + (double)numericUpDown3.Value;
        }
        public double Value2(double x)
        {
            return (double)numericUpDown1.Value * Math.Sin((double)numericUpDown2.Value * x );
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            groupBox1.Text = FunctionName;
            if(FunctionChanged != null)
            {
                FunctionChanged();
            }
        }
        private void ValueChanged2(object sender, EventArgs e)
        {
            groupBox1.Text = FunctionName2;
            if (FunctionChanged != null)
            {
                FunctionChanged();
            }
        }

    }
}
