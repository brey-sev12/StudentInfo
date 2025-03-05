using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace StudentInfo
{
    public partial class DeleteForm : DevExpress.XtraEditors.XtraForm
    {
        List<Delete> persons = new List<Delete>();
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete person = new Delete();

            //set Student properties based on text box values
            person.FirstName = teFirstName.Text;
            person.MiddleName = teMiddleName.Text;
            person.LastName = teLastName.Text;

            //remove Student object to the list
            persons.Remove(person);

            XtraMessageBox.Show("Student Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear textboxes
            ClearTextFields();


        }
        private void ClearTextFields()
        {
            teFirstName.Text = string.Empty;
            teMiddleName.Text = string.Empty;
            teLastName.Text = string.Empty;
        }
    }
}