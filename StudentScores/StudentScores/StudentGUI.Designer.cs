namespace StudentScores
{
    partial class StudentGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rad_commuter = new System.Windows.Forms.RadioButton();
            this.rad_dorm = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_studentName = new System.Windows.Forms.TextBox();
            this.txt_studentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rad_oak = new System.Windows.Forms.RadioButton();
            this.rad_Trustee = new System.Windows.Forms.RadioButton();
            this.rad_Wapello = new System.Windows.Forms.RadioButton();
            this.rad_Appanoose = new System.Windows.Forms.RadioButton();
            this.rad_Mahaska = new System.Windows.Forms.RadioButton();
            this.grp_dorms = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grp_meal = new System.Windows.Forms.GroupBox();
            this.rad_basic = new System.Windows.Forms.RadioButton();
            this.rad_medium = new System.Windows.Forms.RadioButton();
            this.rad_high = new System.Windows.Forms.RadioButton();
            this.btn_display = new System.Windows.Forms.Button();
            this.grp_dorms.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_meal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rad_commuter
            // 
            this.rad_commuter.AutoSize = true;
            this.rad_commuter.Checked = true;
            this.rad_commuter.Location = new System.Drawing.Point(14, 31);
            this.rad_commuter.Name = "rad_commuter";
            this.rad_commuter.Size = new System.Drawing.Size(32, 17);
            this.rad_commuter.TabIndex = 0;
            this.rad_commuter.TabStop = true;
            this.rad_commuter.Text = "C";
            this.rad_commuter.UseVisualStyleBackColor = true;
            // 
            // rad_dorm
            // 
            this.rad_dorm.AutoSize = true;
            this.rad_dorm.Location = new System.Drawing.Point(14, 54);
            this.rad_dorm.Name = "rad_dorm";
            this.rad_dorm.Size = new System.Drawing.Size(33, 17);
            this.rad_dorm.TabIndex = 1;
            this.rad_dorm.Text = "D";
            this.rad_dorm.UseVisualStyleBackColor = true;
            this.rad_dorm.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Commuter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dorm Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Name";
            // 
            // txt_studentName
            // 
            this.txt_studentName.Location = new System.Drawing.Point(136, 53);
            this.txt_studentName.Name = "txt_studentName";
            this.txt_studentName.Size = new System.Drawing.Size(127, 20);
            this.txt_studentName.TabIndex = 6;
            // 
            // txt_studentID
            // 
            this.txt_studentID.Location = new System.Drawing.Point(136, 118);
            this.txt_studentID.Name = "txt_studentID";
            this.txt_studentID.Size = new System.Drawing.Size(127, 20);
            this.txt_studentID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student ID";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(12, 375);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rad_oak
            // 
            this.rad_oak.AutoSize = true;
            this.rad_oak.Checked = true;
            this.rad_oak.Location = new System.Drawing.Point(22, 27);
            this.rad_oak.Name = "rad_oak";
            this.rad_oak.Size = new System.Drawing.Size(45, 17);
            this.rad_oak.TabIndex = 12;
            this.rad_oak.TabStop = true;
            this.rad_oak.Text = "Oak";
            this.rad_oak.UseVisualStyleBackColor = true;
            // 
            // rad_Trustee
            // 
            this.rad_Trustee.AutoSize = true;
            this.rad_Trustee.Location = new System.Drawing.Point(22, 50);
            this.rad_Trustee.Name = "rad_Trustee";
            this.rad_Trustee.Size = new System.Drawing.Size(61, 17);
            this.rad_Trustee.TabIndex = 13;
            this.rad_Trustee.Text = "Trustee";
            this.rad_Trustee.UseVisualStyleBackColor = true;
            // 
            // rad_Wapello
            // 
            this.rad_Wapello.AutoSize = true;
            this.rad_Wapello.Location = new System.Drawing.Point(22, 73);
            this.rad_Wapello.Name = "rad_Wapello";
            this.rad_Wapello.Size = new System.Drawing.Size(64, 17);
            this.rad_Wapello.TabIndex = 14;
            this.rad_Wapello.Text = "Wapello";
            this.rad_Wapello.UseVisualStyleBackColor = true;
            // 
            // rad_Appanoose
            // 
            this.rad_Appanoose.AutoSize = true;
            this.rad_Appanoose.Location = new System.Drawing.Point(22, 96);
            this.rad_Appanoose.Name = "rad_Appanoose";
            this.rad_Appanoose.Size = new System.Drawing.Size(79, 17);
            this.rad_Appanoose.TabIndex = 15;
            this.rad_Appanoose.Text = "Appanoose";
            this.rad_Appanoose.UseVisualStyleBackColor = true;
            // 
            // rad_Mahaska
            // 
            this.rad_Mahaska.AutoSize = true;
            this.rad_Mahaska.Location = new System.Drawing.Point(22, 119);
            this.rad_Mahaska.Name = "rad_Mahaska";
            this.rad_Mahaska.Size = new System.Drawing.Size(69, 17);
            this.rad_Mahaska.TabIndex = 16;
            this.rad_Mahaska.Text = "Mahaska";
            this.rad_Mahaska.UseVisualStyleBackColor = true;
            // 
            // grp_dorms
            // 
            this.grp_dorms.Controls.Add(this.rad_Wapello);
            this.grp_dorms.Controls.Add(this.rad_Mahaska);
            this.grp_dorms.Controls.Add(this.rad_oak);
            this.grp_dorms.Controls.Add(this.rad_Appanoose);
            this.grp_dorms.Controls.Add(this.rad_Trustee);
            this.grp_dorms.Enabled = false;
            this.grp_dorms.Location = new System.Drawing.Point(346, 183);
            this.grp_dorms.Name = "grp_dorms";
            this.grp_dorms.Size = new System.Drawing.Size(166, 165);
            this.grp_dorms.TabIndex = 17;
            this.grp_dorms.TabStop = false;
            this.grp_dorms.Text = "Dormitory";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rad_commuter);
            this.groupBox2.Controls.Add(this.rad_dorm);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(149, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 101);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Type";
            // 
            // grp_meal
            // 
            this.grp_meal.Controls.Add(this.rad_high);
            this.grp_meal.Controls.Add(this.rad_medium);
            this.grp_meal.Controls.Add(this.rad_basic);
            this.grp_meal.Enabled = false;
            this.grp_meal.Location = new System.Drawing.Point(570, 191);
            this.grp_meal.Name = "grp_meal";
            this.grp_meal.Size = new System.Drawing.Size(120, 136);
            this.grp_meal.TabIndex = 19;
            this.grp_meal.TabStop = false;
            this.grp_meal.Text = "Meal Plan";
            // 
            // rad_basic
            // 
            this.rad_basic.AutoSize = true;
            this.rad_basic.Checked = true;
            this.rad_basic.Location = new System.Drawing.Point(27, 34);
            this.rad_basic.Name = "rad_basic";
            this.rad_basic.Size = new System.Drawing.Size(50, 17);
            this.rad_basic.TabIndex = 0;
            this.rad_basic.TabStop = true;
            this.rad_basic.Text = "basic";
            this.rad_basic.UseVisualStyleBackColor = true;
            // 
            // rad_medium
            // 
            this.rad_medium.AutoSize = true;
            this.rad_medium.Location = new System.Drawing.Point(27, 62);
            this.rad_medium.Name = "rad_medium";
            this.rad_medium.Size = new System.Drawing.Size(61, 17);
            this.rad_medium.TabIndex = 1;
            this.rad_medium.Text = "medium";
            this.rad_medium.UseVisualStyleBackColor = true;
            // 
            // rad_high
            // 
            this.rad_high.AutoSize = true;
            this.rad_high.Location = new System.Drawing.Point(27, 92);
            this.rad_high.Name = "rad_high";
            this.rad_high.Size = new System.Drawing.Size(45, 17);
            this.rad_high.TabIndex = 2;
            this.rad_high.Text = "high";
            this.rad_high.UseVisualStyleBackColor = true;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(202, 375);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 20;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // StudentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.grp_meal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_dorms);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_studentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_studentName);
            this.Controls.Add(this.label3);
            this.Name = "StudentGUI";
            this.Text = "StudentGUI";
            this.grp_dorms.ResumeLayout(false);
            this.grp_dorms.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_meal.ResumeLayout(false);
            this.grp_meal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_commuter;
        private System.Windows.Forms.RadioButton rad_dorm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_studentName;
        private System.Windows.Forms.TextBox txt_studentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rad_oak;
        private System.Windows.Forms.RadioButton rad_Trustee;
        private System.Windows.Forms.RadioButton rad_Wapello;
        private System.Windows.Forms.RadioButton rad_Appanoose;
        private System.Windows.Forms.RadioButton rad_Mahaska;
        private System.Windows.Forms.GroupBox grp_dorms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grp_meal;
        private System.Windows.Forms.RadioButton rad_high;
        private System.Windows.Forms.RadioButton rad_medium;
        private System.Windows.Forms.RadioButton rad_basic;
        private System.Windows.Forms.Button btn_display;
    }
}