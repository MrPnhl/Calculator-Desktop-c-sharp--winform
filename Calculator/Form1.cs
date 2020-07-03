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
    public partial class frmcalculator : Form
    {
        //                                          Created By Memmed Penahli 03.07.2020 05:30PM 
        double firstnum;   // first number
        string Operation;

        public frmcalculator()
        {
            InitializeComponent();
        }

        //Control Box is false
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Function that handles event created when user clicks Numpad1
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "1";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "1";
            }
        }
        //Function that handles event created when user clicks Numpad2
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "2";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "2";
            }
        }
        //Function that handles event created when user clicks Numpad3
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "3";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "3";
            }
        }
        //Function that handles event created when user clicks Numpad4
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "4";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "4";
            }
        }
        //Function that handles event created when user clicks Numpad5
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "5";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "5";
            }
        }
        //Function that handles event created when user clicks Numpad6
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "6";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "6";
            }
        }
        //Function that handles event created when user clicks Numpad7
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "7";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "7";
            }
        }
        //Function that handles event created when user clicks Numpad8
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "8";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "8";
            }
        }
        //Function that handles event created when user clicks Numpad9
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0" && txtscreen.Text != null)
            {
                txtscreen.Text = "9";
            }
            else
            {
                txtscreen.Text = txtscreen.Text + "9";
            }
        }
        //Function that handles event created when user clicks Numpad0
        private void btn0_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "0";
        }
        ////Function that handles event created when user clicks plus button 
        private void btntoplam_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreen.Text);
            Operation = "+";
            lblresultscreen.Text = txtscreen.Text + "+";  //result label on screen
            txtscreen.Text = "";
        }
        ////Function that handles event created when user clicks minus button
        private void btncixma_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreen.Text);
            Operation = "-";
            lblresultscreen.Text = txtscreen.Text + "-";
            txtscreen.Text = "";
        }
        ////Function that handles event created when user clicks multiply button
        private void btnvurma_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreen.Text);
            Operation = "*";
            lblresultscreen.Text = txtscreen.Text + "x";
            txtscreen.Text = "";
        }
        //Function that handles event created when user clicks divide button
        private void btnbolme_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreen.Text);
            Operation = "/";
            lblresultscreen.Text = txtscreen.Text + "/";
            txtscreen.Text = "";
        }
        //Function that handles event created when user clicks mod button
        private void btnmod_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(txtscreen.Text);
            Operation = "%";
            lblresultscreen.Text = txtscreen.Text + "% (mod)";
            txtscreen.Text = "";
        }
        //Function that handles event created when user clicks esc button
        private void btnc_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
            lblresultscreen.Text = "";
        }
        //Clear textbox input
        private void ClearDisplay()
        {
            txtscreen.Text = "0";
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
        //Function that handles event created when user clicks Enter button

        private void btnberaber_Click(object sender, EventArgs e)
        {
            double secundnum;  
            double result;

            secundnum = Convert.ToDouble(txtscreen.Text);

            if (Operation=="+")
            {
                result = (firstnum + secundnum);
                txtscreen.Text = Convert.ToString(result);
                firstnum = result;
                lblresultscreen.Text = lblresultscreen.Text + secundnum;
            }
            if (Operation=="-")
            {
                result = (firstnum - secundnum);
                txtscreen.Text = Convert.ToString(result);
                firstnum = result;
            }
            if (Operation == "*")
            {
                result = (firstnum * secundnum);
                txtscreen.Text = Convert.ToString(result);
                firstnum = result;
                lblresultscreen.Text = lblresultscreen.Text + secundnum;
            }
            if (Operation == "/")
            {
                if (secundnum==0)
                {
                    txtscreen.Text = "Cannot divide by zero";
                    lblresultscreen.Text = "";
                }
                else
                {
                    result = (firstnum / secundnum);
                    txtscreen.Text = Convert.ToString(result);
                    firstnum = result;
                    lblresultscreen.Text = lblresultscreen.Text + secundnum;
                }
            }
            if (Operation == "%")
            {
                result = (firstnum % secundnum);
                txtscreen.Text = Convert.ToString(result);
                firstnum = result;
                lblresultscreen.Text = "";
            }
        }
        //Function that handles event created when user clicks bacsspace button
        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text.Length == 1)
            {
                ClearDisplay();
            }
            else
            {
                txtscreen.Text = txtscreen.Text.Remove(txtscreen.Text.Length - 1);
            }
        }
        //Function that handles event created when user clicks . button
        private void btndot_Click_1(object sender, EventArgs e)
        {
            if (txtscreen.Text !="")
            {
                txtscreen.Text = txtscreen.Text + ".";
            }
        }
    }
}
