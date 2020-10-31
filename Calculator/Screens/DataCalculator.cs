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
    public partial class frmdatacalculator : MetroFramework.Forms.MetroForm
    {
        public frmdatacalculator()
        {
            InitializeComponent();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {
        }

        private void DataCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            System.DateTime firstdate = dtpfrom.Value;
            System.DateTime seconddate = dtpto.Value;

            String diff= (seconddate - firstdate).Days.ToString();

            if (lblresult.Text=="0 days")
            {
                lblresult.Text = "Same days";
            }
            if ((seconddate - firstdate).Days == 1)
            {
                lblresult.Text= diff + " day";
            }
            else
            {
                lblresult.Text = diff + " days";
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcalculator ff = new frmcalculator();
            ff.Show();
            this.Hide();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmscientafic fff = new frmscientafic();
            fff.Show();
            this.Hide();
        }

        private void graphingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working on this update. Thanks for your attention. /Bu hissə üzrə yeniləmələr gedir. Diqqətiniz üçün təşəkkürlər!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are working on this update. Thanks for your attention. /Bu hissə üzrə yeniləmələr gedir. Diqqətiniz üçün təşəkkürlər!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
