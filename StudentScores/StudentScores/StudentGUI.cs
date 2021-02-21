using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace StudentScores
{
    public partial class StudentGUI : Form
    {

        public static List<CurrentStudent> stuList = new List<CurrentStudent>();

       



        public StudentGUI()
        {
            InitializeComponent();
            LoadTheStudentFile();
        }


        void LoadTheStudentFile()
        {
            MessageBox.Show("Welcome to IHCC", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {

                if (File.Exists("studentList.ser"))
                {
                    FileStream inFile = new FileStream("studentList.ser", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();


                    while (inFile.Position < inFile.Length)
                    {
                        CurrentStudent inventory = (CurrentStudent)bf.Deserialize(inFile);
                        stuList.Add(inventory);
               
                    }

                    inFile.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


 

        int StudentName()
        {
            int errors = 0;

            // trims extra whitespace 
            if (String.IsNullOrEmpty(txt_studentName.Text.Trim()))
            {
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors++;
            }

            return errors;
        }


        int StudentID()
        {
            int errors = 0;


            if (int.TryParse(txt_studentID.Text, out int num))
            {
                try
                {
                    if (num < 5 )
                    {
                        errors++;
                        throw new IDException();
                    }
                }
                catch (IDException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errors++;
                MessageBox.Show("Student ID must be 5 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return errors;
        }





       void SerializeOrders()
        {
                if (rad_commuter.Checked)
                {


                CurrentStudent inventory = new CurrentStudent(txt_studentName.Text, int.Parse(txt_studentID.Text));
                stuList.Add(inventory);
                
                
                }
                else
            {
                char dorm;

                if (rad_oak.Checked)
                {
                    dorm = 'O';
                }
                else if (rad_Trustee.Checked)
                {
                    dorm = 'T';
                }
                else if (rad_Wapello.Checked)
                {
                    dorm = 'W';
                }

                else if (rad_Appanoose.Checked)
                {
                    dorm = 'A';
                }
                else 
                {
                    dorm = 'M';
                }

                char meals;

                if(rad_basic.Checked)
                  
                {
                    meals = 'B';
                }
                else if (rad_medium.Checked)
                {
                    meals = 'M';
                }
                else 
                {
                    meals = 'H';
                }

                //instantiate your dorm student after youve collected all the parts needed to make a whole object

                DormStudent inventory = new DormStudent(txt_studentName.Text, int.Parse(txt_studentID.Text), dorm, meals);
                stuList.Add(inventory);

            }
            

      
            
        }

        void Display_Click(object sender, EventArgs e)
        {
            // Checks if there are any orders to display
            if (stuList.Count > 0)
            {
                DisplayStudents disord = new DisplayStudents(stuList);
                {
                    Height = 750;
                };
                disord.ShowDialog();    // displays the new form
            }
            else
            {
                MessageBox.Show("There are no students to display", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Exit_Click(object sender, EventArgs e)
        {
            bool inValid = false;


            while (!inValid)
            {
                DialogResult result = MessageBox.Show("Want to close this form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    inValid = true;


                    if (stuList.Count > 0)
                    {
                        SaveOrders();
                    }

                    this.Close();
                }
                else
                {
                    inValid = true;
                }
            }
        }


        void SaveOrders()
        {
            bool inValid = false;


            while (!inValid)
            {
                DialogResult result = MessageBox.Show("Do you want to save this student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    SerializeOrders();
                    inValid = true;
                }
                else
                {
                    inValid = true;
                }
            }
        }




        private void btn_submit_Click(object sender, EventArgs e)
        {
            int errorCtr = 0;

           
            errorCtr += StudentName();
            errorCtr += StudentID();
         

            if (errorCtr == 0)
            {
           
                SerializeOrders();

             
                MessageBox.Show("Order was saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (File.Exists("studentList.ser"))
                {
                    FileStream inFile = new FileStream("studentList.ser", FileMode.Open, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();

                    //binary formatter is your best friend

                    foreach (var item in stuList)
                    {
                        bf.Serialize(inFile, item);
                    }

                    inFile.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Writing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

      

            bool inValid = false;


            while (!inValid)
            {
                DialogResult result = MessageBox.Show("Want to close this form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes && result != DialogResult.No)
                {
                    MessageBox.Show("Unknown button was pressed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result == DialogResult.Yes)
                {
                    inValid = true;


                    if (stuList.Count > 0)
                    {
                        SaveOrders();
                    }

                    this.Close();
                }
                else
                {
                    inValid = true;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_dorm.Checked)
            {
                grp_dorms.Enabled = true;
                grp_meal.Enabled = true;
            }
            else
            {
                grp_dorms.Enabled = false;
                grp_meal.Enabled = false;
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            DisplayStudents df = new DisplayStudents(stuList);
            df.ShowDialog();
        }
    }
}
