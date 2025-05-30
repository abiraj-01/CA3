using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            string student = txtStudent.Text;
            string grade = txtGrade.Text;
            lstGrades.Items.Add(student + " - " + grade);
            txtStudent.Clear();
            txtGrade.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student = txtStudent.Text.Trim();
            string gradeText = txtGrade.Text.Trim();

            if (string.IsNullOrEmpty(student) || string.IsNullOrEmpty(gradeText))
            {
                MessageBox.Show("Please enter both student name and grade.");
                return;
            }
            int grade;
            if (!int.TryParse(gradeText, out grade) || grade < 0 || grade > 100)
            {
                MessageBox.Show("Grade must be a number between 0 and 100.");
                return;
            }

            lstGrades.Items.Add(student + " - " + grade);
            txtStudent.Clear();
            txtGrade.Clear();


        }



        private void btnDelete_Click(object sender, EventArgs e)
        {




            if (lstGrades.SelectedIndex != -1)
            {
                lstGrades.Items.RemoveAt(lstGrades.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an entry to delete.");
            }
        }
    }
}