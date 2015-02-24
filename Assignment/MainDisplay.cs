using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// adding using directives
using DataModel;

namespace Assignment
{
    public partial class MainDisplay : Form
    {
        // making a list for students
        private List<Student> stuList = new List<Student>();
        // binding source - data dound controls - bind to the list, to display the data
        private BindingSource bSrc = new BindingSource();

        public MainDisplay()
        {
            InitializeComponent();

            //// set auto generate columns to false
            dgvDisplay.AutoGenerateColumns = false;
            dgvDisplay.ColumnCount = 4;

            //setting the headers
            dgvDisplay.Columns[0].HeaderText = "Account Number";
            dgvDisplay.Columns[0].DataPropertyName = "AccountNo"; // from tables in SQL Server

            dgvDisplay.Columns[1].HeaderText = "Account Type";
            dgvDisplay.Columns[1].DataPropertyName = "AccountType";

            dgvDisplay.Columns[2].HeaderText = "Current Balance";
            dgvDisplay.Columns[2].DataPropertyName = "CurrentBalance";

            dgvDisplay.Columns[3].HeaderText = "Over Draft Limit";
            dgvDisplay.Columns[3].DataPropertyName = "OverDraftLimit";

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry f1 = new Entry();
            f1.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NewAccount na = new NewAccount())
            {
                // bring up Add Employee
                na.OnStudentAdd += StudentAdd;
                na.ShowDialog();
                this.Hide();
            }
        }

        // method for subscriber or event handler AddEmployee
        private void StudentAdd(Student stu)
        {
            //startagain:
            // foreach employee on the list
            foreach (Student s in stuList)
            {
                // if the id added matches an id on the list 
                //if (stu.Id == s.Id) //** need to change this to student Id number ************************
                {
                    MessageBox.Show("User ID already in use.");
                }
                stuList.Add(stu);
                //goto startagain;
            }

            // reset bindings
            bSrc.ResetBindings(false);
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student selStudent = GetSelectedStudent();
            if (selStudent != null)
            {
                using (EditAccount ea = new EditAccount(selStudent))
                {
                    ea.OnStudentUpdated += UpdateStudent;
                    ea.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("No Active Selection made. Please select the whole row.");
            }
        }

        private Student GetSelectedStudent()
        {
            Student selStudent = null;
            int stuId = 0;
            int columnIndex = 0;
            int rowIndex = 0;

            if (dgvDisplay.SelectedRows.Count > 0)
            {
                // this ensures you select only 1 row, not multi-select
                rowIndex = dgvDisplay.SelectedRows[0].Index;

                stuId = (int)dgvDisplay.Rows[rowIndex].Cells[columnIndex].Value;

                for (int i = 0; i < stuList.Count; i++)
                {
                    // if (stuList[i].Id == stuId)  ** need to change this to student Id number ************************
                    {
                        selStudent = stuList[i];
                        break;
                    }
                }
            }
            return selStudent;
        }

        private void UpdateStudent(Student stu)
        {
            // going to interate between a match of the employee on the list
            for (int i = 0; i < stuList.Count; i++)
            {
               // if (stuList[i].Id == stu.Id) ** need to change this to student Id number ************************
                {
                    stuList[i] = stu;
                    // reset binding source
                    bSrc.ResetBindings(false);

                    // if you dont want to use the binding source
                    //dgvDisplay.DataSource = null;
                    //dgvDisplay.DataSource = stuList;

                    break;
                }
            }
        }

        private void depositFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositFunds df = new DepositFunds();
            df.Show();
            this.Hide();
        }

        private void withdrawFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawFunds wf = new WithdrawFunds();
            wf.Show();
            this.Hide();
        }

        private void transferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferFunds tf = new TransferFunds();
            tf.Show();
            this.Hide();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions tra = new Transactions();
            tra.Show();
            this.Hide();
        }
    }
}
