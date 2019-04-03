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
            Button button = (Button)sender;

            alert.Visible = false;

            if (result.TextLength > 20)
            {
                result.Text = "0";
                alert.Visible = true;
                alert.Text = "Wpisano zbyt dużą wartość!";
            }
            else
            {
                if ((result.Text == "0") || isoperation)
                    result.Clear();

                isoperation = false;

                if (button.Text == ".")
                {
                    if (!result.Text.Contains("."))
                        result.Text = result.Text + button.Text;
                }
                else
                    result.Text = result.Text + button.Text;
            }
        }

        private void operatorclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result.Text == ".")
                result.Text = "0";

            if (value != 0)
            {
                breturn.PerformClick();
                operation = button.Text;
                labeloperation.Text = (Double.Parse(result.Text)) + " " + operation;
                isoperation = true;
            }

            operation = button.Text;

            if ((value >= double.MaxValue || value <= double.MinValue) 
                || (Double.Parse(result.Text) >= double.MaxValue || 
                Double.Parse(result.Text) <= double.MinValue))
            {
                labeloperation.Text = "";
                value = 0;
                alert.Visible = true;
                alert.Text = "Przekroczono zakres zmiennej!";
                result.Text = "0";
            }
            else
            {
                value = Double.Parse(result.Text);
            }

            labeloperation.Text = (Double.Parse(result.Text)) + " " + operation;
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
            if (result.Text == ".") result.Text = "0.";
            else if (result.Text == "") result.Text = "0";

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
                    if (Double.Parse(result.Text)==0)
                    {
                        result.Text = (0).ToString();
                        value = 0;
                        alert.Visible = true;
                        alert.Text = "Nie można dzielić przez 0!";
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

            if ((Double.Parse(result.Text) >= double.MaxValue || Double.Parse(result.Text) <= double.MinValue)
                || (result.Text=="NaN" || result.Text == "∞"))
            {
                labeloperation.Text = "";
                value = 0;
                alert.Visible = true;
                alert.Text = "Przekroczono zakres zmiennej!";
                result.Text = "0";
            }

            value = Double.Parse(result.Text);

            isoperation = false;
            value = 0;
            labeloperation.Text = "";
        }
    }
}