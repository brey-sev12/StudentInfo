using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StudentInfo
{
    public partial class StudentInfo : DevExpress.XtraEditors.XtraForm
    {
        List<Student> students = new List<Student>();
        public StudentInfo()
        {
            InitializeComponent();
            gcStudentInfo.DataSource = students;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            gcStudentInfo.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if any required field is empty or whitespace
            if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                string.IsNullOrWhiteSpace(teMiddleName.Text) ||
                string.IsNullOrWhiteSpace(teLastName.Text) ||
                string.IsNullOrWhiteSpace(cbeSex.Text) ||
                string.IsNullOrWhiteSpace(cbeCivilStatus.Text) ||
                string.IsNullOrWhiteSpace(teAddress.Text) ||
                string.IsNullOrWhiteSpace(teContact.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if validation fails
            }

            // Create and set Student object
            Student student = new Student
            {
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                Sex = cbeSex.Text,
                CivilStatus = cbeCivilStatus.Text,
                Address = teAddress.Text,
                Contact = teContact.Text
            };

            // Add Student to the list
            students.Add(student);

            XtraMessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearStudentFields();

            // Refresh grid control
            gcStudentInfo.RefreshDataSource();
        }
        private void ClearStudentFields()
        {
            teFirstName.Text = string.Empty;
            teMiddleName.Text = string.Empty;
            teLastName.Text = string.Empty;
            cbeSex.Text = string.Empty;
            cbeCivilStatus.Text = string.Empty;
            teContact.Text = string.Empty;
            teAddress.Text = string.Empty;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected row index from GridView
            int selectedRowHandle = gvStudentInfo.FocusedRowHandle;

            if (selectedRowHandle >= 0) // Ensure a row is selected
            {
                Student selectedStudent = (Student)gvStudentInfo.GetRow(selectedRowHandle);

                if (selectedStudent != null)
                {
                    // Remove the student from the list
                    students.Remove(selectedStudent);

                    // Refresh the grid control
                    gcStudentInfo.RefreshDataSource();

                    XtraMessageBox.Show("Student Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
