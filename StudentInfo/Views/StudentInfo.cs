using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace StudentInfo
{
    public partial class StudentInfo : DevExpress.XtraEditors.XtraForm
    {
        List<Student> students = new List<Student>();// List to hold student information

        public StudentInfo()
        {
            InitializeComponent();
            gcStudentInfo.DataSource = students;// Set the data source of the grid control to the list of students
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // i-Check if any of the required input fields kay empty or ga white space
            if (string.IsNullOrWhiteSpace(teFirstName.Text.Trim()) ||
                string.IsNullOrWhiteSpace(teMiddleName.Text.Trim()) ||
                string.IsNullOrWhiteSpace(teLastName.Text.Trim()) ||
                string.IsNullOrWhiteSpace(cbeSex.Text.Trim()) ||
                string.IsNullOrWhiteSpace(cbeCivilStatus.Text.Trim()) ||
                string.IsNullOrWhiteSpace(teAddress.Text.Trim()) ||
                string.IsNullOrWhiteSpace(teContact.Text.Trim()))
            {
                XtraMessageBox.Show("Please fill in all required fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution if validation fails
            }

            // Confirmation dialog before saving
            DialogResult result = XtraMessageBox.Show("Are you sure you want to add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // Stop execution if the user cancels
            }

            Student student = new Student   // Create and set Student object
            {
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                Sex = cbeSex.Text,
                CivilStatus = cbeCivilStatus.Text,
                Address = teAddress.Text,
                Contact = teContact.Text
            };
            students.Add(student);// Add student to the list

            XtraMessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearStudentFields(); // Clear input fields
            gcStudentInfo.RefreshDataSource();// Refresh grid control

        }
        private void ClearStudentFields()// Method for clearing input fields
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
            int selectedRowHandle = gvStudentInfo.FocusedRowHandle;// Get the index of the currently selected row in the GridView.

            if (selectedRowHandle < 0)// Check if naay giselect nga row
            {
                XtraMessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if no student is selected
            }

            // Get the selected student
            Student selectedStudent = (Student)gvStudentInfo.GetRow(selectedRowHandle);

            // Confirmation of delete action
            if (XtraMessageBox.Show("Do you really want to delete this student record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                students.Remove(selectedStudent); // Remove the student
                gcStudentInfo.DataSource = null; // Clear the current data source
                gcStudentInfo.DataSource = students; // Rebind the updated list
                XtraMessageBox.Show("Student Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gvStudentInfo.FocusedRowHandle;// Get the selected row index from the GridView

            if (selectedRowHandle < 0)// Check if naay giselect nga row
            {
                XtraMessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK);
                return; // Exit if no walay giselect na row 
            }

            // Gikuha ang student nga object from the GridView sa giselect nga row index ug i-cast padulon sa class nga Student
            Student selectedStudent = (Student)gvStudentInfo.GetRow(selectedRowHandle);

            if (selectedStudent == null)// Check if the selected student is valid
            {
                XtraMessageBox.Show("No valid student selected.", "Error", MessageBoxButtons.OK);
                return; // Exit if the selected student is null
            }

            // Confirmation of update action
            if (XtraMessageBox.Show("Do you confirm you want to update this student?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return; // Exit if the user cancels the update

            // Set/Update the student's properties using the trimmed input values from the text fields
            selectedStudent.FirstName = teFirstName.Text.Trim();
            selectedStudent.MiddleName = teMiddleName.Text.Trim();
            selectedStudent.LastName = teLastName.Text.Trim();
            selectedStudent.Sex = cbeSex.Text.Trim();
            selectedStudent.CivilStatus = cbeCivilStatus.Text.Trim();
            selectedStudent.Address = teAddress.Text.Trim();
            selectedStudent.Contact = teContact.Text.Trim();

            gcStudentInfo.RefreshDataSource();// Refresh the grid to show updated data

            // Show success message
            XtraMessageBox.Show("Student Updated Successfully!", "Success", MessageBoxButtons.OK);
            
            ClearStudentFields();// Clear input fields for the next entry
        }
    }
}
