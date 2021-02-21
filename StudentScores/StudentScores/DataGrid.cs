using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class DataGrid : Form
    {

        public static List<CurrentStudent> StudentAssignments = new List<CurrentStudent>();

        public DataGrid()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //build a list of Authors and their Books
            //Stephen King
            StudentAssignments.Add(new CurrentStudent("Instantiate an object", 78));
            StudentAssignments[0].AssignGrades = new List<CurrentStudent>();
            StudentAssignments[0].AssignGrades.Add(new CurrentStudent("Serialization", 87));
            StudentAssignments[0].AssignGrades.Add(new CurrentStudent("Setters and Getters", 35));

            //John Steinbeck
            StudentAssignments.Add(new CurrentStudent("Compare To Method", 45));
            StudentAssignments[1].AssignGrades = new List<CurrentStudent>() {new CurrentStudent("2-D Arrays", 20),
                                                    new CurrentStudent("Two String Method", 50),
                                                    new CurrentStudent("Deserialization", 19),
                                                    new CurrentStudent("Compare To Method", 100),
                                                    new CurrentStudent("Compare To Method", 100) };




            //add the CurrentStudent ID's to the listbox on the form
            foreach (var item in StudentAssignments)
            {
                listStudents.Items.Add(item.StudentID);
            }

            listStudents.SelectedIndex = 0;

        }


        //each time a different author is selected:
        //  1. Clear the rows of the DataGridView
        //  2. Build rows for the DataGridView for each of the author's books
        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            dgvStudents.Rows.Clear();

            foreach (var item in StudentAssignments[listStudents.SelectedIndex].AssignGrades)
            {
              //  dgvStudents.Rows.Add();
               // dgvStudents.Rows[i].Cells[0].Value = item.Add;
               // dgvStudents.Rows[i].Cells[1].Value = item.Delete;
               // dgvStudents.Rows[i].Cells[2].Value = item.Edit.ToString("f2");
                i++;
            }

         
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //authList[listStudents.SelectedIndex].AuthBooks.Clear();            //either remove the books from the selected author, OR
            StudentAssignments[listStudents.SelectedIndex].AssignGrades = new List<CurrentStudent>();   //allocate a new book list for that author

            foreach (DataGridViewRow dr in dgvStudents.Rows)
            {
                if (dr.Cells[0].Value != null)  //to avoid processing past the last datagridview row
                {
                    string t = dr.Cells[0].Value.ToString();
                    int n = Convert.ToInt32(dr.Cells[1].Value);
                    double p = Convert.ToDouble(dr.Cells[2].Value);
                    CurrentStudent b = new CurrentStudent(t, n);

                    StudentAssignments[listStudents.SelectedIndex].AssignGrades.Add(b);
                }
            }
        }
    }
}
