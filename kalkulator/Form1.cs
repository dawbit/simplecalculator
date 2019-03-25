using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace kalkulator
{
    public partial class Form1 : Form
    {
        double value = 0d;
        String operation = "";
        bool isoperation = false;

        public Form1()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            InitializeComponent();
        }


        private void numberclick(object sender, EventArgs e)
        {
            if ((result.Text == "0") || isoperation)
                result.Clear();

            isoperation = false;
            alertdivision.Visible = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + button.Text;
            }
            else
                result.Text = result.Text + button.Text;
        }

        private void operatorclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (value != 0)
            {
                breturn.PerformClick();
                operation = button.Text;
                labeloperation.Text = result.Text + " " + operation;
                isoperation = true;
            }

            operation = button.Text;
            value = Double.Parse(result.Text);
            labeloperation.Text = result.Text + " " + operation;
            isoperation = true;
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            labeloperation.Text = "";
        }

        private void breturn_Click(object sender, EventArgs e)
        {

            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    if (result.Text.Equals("0"))
                    {
                        result.Text = (0).ToString();
                        value = 0;
                        alertdivision.Visible = true;
                        break;
                    }
                    else
                    {
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                    }
                    break;

                default:
                    break;
            }
            
            value = Double.Parse(result.Text);
            labeloperation.Text = "";
        }
    }
}