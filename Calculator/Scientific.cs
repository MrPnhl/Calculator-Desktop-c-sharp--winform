using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmscientafic : Form
    {
        double firstnum;   // first number
        string Operation;

        public frmscientafic()
        {
            InitializeComponent();
        }

        private void Scientific_Load(object sender, EventArgs e)
        {

        }
        
        //Override ProcessCmdKey so that the form receives keyboard input before any other components and handle the event
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.NumPad9:
                    btn9.PerformClick();
                    return true;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    return true;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    return true;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    return true;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    return true;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    return true;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    return true;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    return true;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    return true;
                case Keys.NumPad0:
                    btn0.PerformClick();
                    return true;
                case Keys.Subtract:
                    btncixma.PerformClick();
                    return true;
                case Keys.Add:
                    btntoplam.PerformClick();
                    return true;
                case Keys.Multiply:
                    btnvurma.PerformClick();
                    return true;
                case Keys.Divide:
                    btnbolme.PerformClick();
                    return true;
                case Keys.Enter:
                    btnberaber.PerformClick();
                    return true;
                case Keys.Escape:
                    btnc.PerformClick();
                    return true;
                case Keys.Back:
                    btndel.PerformClick();
                    return true;
                case Keys.Decimal:
                    btndot.PerformClick();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcalculator frmcalculator = new frmcalculator();
            frmcalculator.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "1";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "1";
            }
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "2";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "2";
            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "3";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "3";
            }
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "4";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "4";
            }
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "5";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "5";
            }
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "6";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "6";
            }
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "7";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "7";
            }
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "8";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "8";
            }
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text == "0" && txtscreens.Text != null)
            {
                txtscreens.Text = "9";
            }
            else
            {
                txtscreens.Text = txtscreens.Text + "9";
            }
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            txtscreens.Text = txtscreens.Text + "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (txtscreens.Text != "")
            {
                txtscreens.Text = txtscreens.Text + ".";
            }
        }

        private void btntoplam_Click_1(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreens.Text);
            Operation = "+";
            lblresultscreen.Text = txtscreens.Text + "+";  //result label on screen
            txtscreens.Text = "";
        }

        private void btncixma_Click_1(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreens.Text);
            Operation = "-";
            lblresultscreen.Text = txtscreens.Text + "-";
            txtscreens.Text = "";
        }

        private void btnvurma_Click_1(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreens.Text);
            Operation = "*";
            lblresultscreen.Text = txtscreens.Text + "x";
            txtscreens.Text = "";
        }

        private void btnbolme_Click_1(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreens.Text);
            Operation = "/";
            lblresultscreen.Text = txtscreens.Text + "/";
            txtscreens.Text = "";
        }

        private void btnmod_Click_1(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreens.Text);
            Operation = "%";
            lblresultscreen.Text = txtscreens.Text + "% (mod)";
            txtscreens.Text = "";
        }

        private void btnberaber_Click_1(object sender, EventArgs e)
        {
            double secundnum;
            double result;

            secundnum = Convert.ToDouble(txtscreens.Text);

            if (Operation == "+")
            {
                result = (firstnum + secundnum);
                txtscreens.Text = Convert.ToString(result);
                firstnum = result;
                lblresultscreen.Text = lblresultscreen.Text + secundnum;
            }
            if (Operation == "-")
            {
                result = (firstnum - secundnum);
                txtscreens.Text = Convert.ToString(result);
                firstnum = result;
                lblresultscreen.Text = lblresultscreen.Text + secundnum;
            }
            if (Operation == "*")
            {
                result = (firstnum * secundnum);
                txtscreens.Text = Convert.ToString(result);
                firstnum = result;
                lblresultscreen.Text = lblresultscreen.Text + secundnum;
            }
            if (Operation == "/")
            {
                if (secundnum == 0)
                {
                    txtscreens.Text = "Cannot divide by zero";
                    lblresultscreen.Text = "";
                }
                else
                {
                    result = (firstnum / secundnum);
                    txtscreens.Text = Convert.ToString(result);
                    firstnum = result;
                    lblresultscreen.Text = lblresultscreen.Text + secundnum;
                }
            }
            if (Operation == "%")
            {
                result = (firstnum % secundnum);
                txtscreens.Text = Convert.ToString(result);
                firstnum = result;
                lblresultscreen.Text = "";
            }
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            if (txtscreens.Text.Length == 1)
            {
                ClearDisplay();
            }
            else
            {
                txtscreens.Text = txtscreens.Text.Remove(txtscreens.Text.Length - 1);
            }
        }

        private void ClearDisplay()
        {
            txtscreens.Text = "0";
        }

        private void btnc_Click_1(object sender, EventArgs e)
        {
            txtscreens.Text = "0";
            lblresultscreen.Text = "";
        }
    }
}
