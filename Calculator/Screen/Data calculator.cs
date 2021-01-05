using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Screen
{
    public partial class frmdatacalculator : MetroFramework.Forms.MetroForm
    {
        public frmdatacalculator()
        {
            InitializeComponent();
        }

        private void Data_calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            lblword.Visible = true;

            System.DateTime firstdate = dtpfrom.Value;
            System.DateTime secunddate = dtpto.Value;

            string diff = (secunddate - firstdate).Days.ToString();
            

            if (lblresult.Text=="0 days")
            {
                lblresult.Text = "Same date";
            }
            if ((secunddate-firstdate).Days==1)
            {
                lblresult.Text = diff + " day";
            }
            else
            {
                lblresult.Text = diff + " days";
            }
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcalculator frmcalculator = new frmcalculator();
            frmcalculator.Show();
            this.Hide();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmscientafic frmscientafic = new frmscientafic();
            frmscientafic.Show();
            this.Hide();
        }
    }
}
