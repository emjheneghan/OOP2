using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// adding using directive
using DataModel;

namespace Assignment
{
    public partial class EditAccount : Form
    {
        // private property - bringing Student from the DataModel
        private Student Student { get; set; }

        // creating delegate and event
        public delegate void StudentUpdate(Student student);
        public event StudentUpdate OnStudentUpdated;

        // constructor - forse the user to send an account when creating form
        public EditAccount(Student student)
        {
            InitializeComponent();

            Student = student;

            // calling the user control compopnent
            userEditAccount.Student = Student;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // raising the event - nothing has been subscribes yet
            Student stu = new Student();
            stu = userEditAccount.Student;

            // on the event pass the employee details out to the delegate
            OnStudentUpdated(stu);
            this.Close();
        }
    }
}
