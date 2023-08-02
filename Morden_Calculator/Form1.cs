using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morden_Calculator
{
    public partial class Calculator : Form
    {
        double num1, num2;
        string oprator;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnplse_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            oprator = "+";
            txtDisplay.Text = "";
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            oprator = "-";
            txtDisplay.Text = "";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            oprator = "*";
            txtDisplay.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            oprator = "/";
            txtDisplay.Text = "";
        }

        private void btnplmin_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * q);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            string f, s;
            f = Convert.ToString(num1);
            s = Convert.ToString(num2);

            f = "";
            s = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0) ;
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text ==  "") ;
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text);

            switch (oprator)
            {
                case "+":
                    txtDisplay.Text = (num1+num2).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (num1 - num2).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (num1 * num2).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (num1 / num2).ToString();
                    break;

                default:
                    break;



            }
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            double p = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(.0 / p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
