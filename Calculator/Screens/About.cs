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
    public partial class frmabout : MetroFramework.Forms.MetroForm
    {
        public frmabout()
        {
            InitializeComponent();
        }

        private void VisitLink()
        {
            
            linkLabel1.LinkVisited = true;
            
            System.Diagnostics.Process.Start("https://github.com/MrPnhl");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmsendfeedback frmsendfeedback = new frmsendfeedback();
            frmsendfeedback.Show();
            this.Hide();
        }

        private void frmabout_Load(object sender, EventArgs e)
        {

        }
    }
}
