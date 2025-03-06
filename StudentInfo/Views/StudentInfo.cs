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
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            gcStudentInfo.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            //set Student properties based on text box values
            student.FirstName = teFirstName.Text;
            student.MiddleName = teMiddleName.Text;
            student.LastName = teLastName.Text;
            student.Contact = teContact.Text;
            student.Address = teAddress.Text;

            //add Student object to the list
            students.Add(student);
            
            XtraMessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear textboxes
            ClearStudentFields();

            //refresh the grid control to reflect changes
            gcStudentInfo.RefreshDataSource();

        }
        private void ClearStudentFields()
        {
            teFirstName.Text = string.Empty;
            teMiddleName.Text = string.Empty;
            teLastName.Text = string.Empty;
            teContact.Text = string.Empty;
            teAddress.Text = string.Empty;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();    // Opens the Delete form for deleting a student
            delete.ShowDialog();    // Show the Delete form as a modal dialog
        }
    }
}
