using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// adding a namespace
using DataModel;

namespace Assignment
{
    public partial class NewAccount : Form
    {
        // creating object Student
        private Student Student { get; set; }

        // delegate and event handlers
        public delegate void StudentAdd(Student student);
        public event StudentAdd OnStudentAdd;

        public NewAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDisplay md = new MainDisplay();
            md.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // instanciate Student
            Student stu = new Student();

            // pass the student from the User control into the stu object
            stu = userAddAccount.Student;

            // the event
            OnStudentAdd(stu);

            this.Close();
        }
    }
}
