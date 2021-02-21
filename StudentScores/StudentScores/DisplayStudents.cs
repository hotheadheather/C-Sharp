using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//this is the form that displays the student objects

namespace StudentScores
{
    public partial class DisplayStudents : Form
    {
        public  DisplayStudents(List<CurrentStudent> stuList)
        {
            InitializeComponent();
            student_inv.DataSource = stuList;
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            bool inValid = false;

            while (!inValid)
            {
                DialogResult result = MessageBox.Show("Would you like to return to the student form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    inValid = true;
                    this.Close();
                }
                else
                {
                    inValid = true;
                }
            }
        }


    }
}
