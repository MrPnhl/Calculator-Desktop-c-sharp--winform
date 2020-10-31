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
    public partial class frmsendfeedback : MetroFramework.Forms.MetroForm
    {
        public frmsendfeedback()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="" && txtemail.Text=="" && txtfeedback.Text=="" )
            {
                MessageBox.Show("Fill the all blanks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Thanks for your feedback :)" +
                    "", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmsendfeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
