using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// adding namespace directive
using DataModel;

namespace Assignment
{
    public partial class CustomerTemplate : UserControl
    {
        // creating Enum for combobox drop down list
        public enum Countys
        {
            Antrim,
            Armagh,
            Carlow,
            Cavan,
            Clare,
            Cork,
            Derry,
            Donegal,
            Down,
            Dublin,
            Fermanagh,
            Galway,
            Kerry,
            Kildare,
            Kilkenny,
            Laois,
            Leitrim,
            Limerick,
            Longford,
            Louth,
            Mayo,
            Meath,
            Monaghan,
            Offaly,
            Roscommon,
            Sligo,
            Tipperary,
            Tyrone,
            Waterford,
            Westmeath,
            Wexford,
            Wicklow
        }

        // adding two properties - edit only, read only
        public bool EditOnly { get; set; }
        public bool ReadOnly { get; set; }

        private Student fldStudent; // this private field is the backing store

        public Student Student // property denoted by uppercase
        {
            get
            {
                // if the student hasnt been instanciated or created
                if (null == fldStudent)
                {
                    fldStudent = new Student();
                }
                // call populate employees method
                PopulateStudent();
                return fldStudent;
            }
            set
            {
                fldStudent = value;
            }
        }

        public CustomerTemplate()
        {
            InitializeComponent();

            // using Enum to populate the values in the combo box
            cboCounty.DataSource = Enum.GetValues(typeof(Countys));
        }

        private void PopulateStudent()
        {
            int phone = 0, balance = 0, overDraft = 0;

            fldStudent.FirstName = txtFirstName.Text;
            fldStudent.LastName = txtLastName.Text;
            fldStudent.Email = txtEmail.Text;
            int.TryParse(txtPhone.Text, out phone);
            fldStudent.Phone = phone;
            fldStudent.Address1 = txtAddress1.Text;
            fldStudent.Address2 = txtAddress2.Text;
            fldStudent.City = txtCity.Text;
            fldStudent.County = Convert.ToString(cboCounty.SelectedItem);
            int.TryParse(txtInitialBalance.Text, out balance);
            fldStudent.InitialBalance = balance;
            int.TryParse(txtOverdraft.Text, out overDraft);
            fldStudent.OverDraftLimit = overDraft;

            string accType = "";
            if (rdoCurrentAcc.Checked)
            {
                accType = "Current";
            }
            else if (rdoSavingsAcc.Checked)
            {
                accType = "Savings";
            }
            fldStudent.AccountType = accType;

        }

        private void CustomerTemplate_Load(object sender, EventArgs e)
        {
            if (EditOnly)
            {
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                txtAddress1.Enabled = false;
                txtAddress2.Enabled = false;
                txtCity.Enabled = false;
                cboCounty.Enabled = false;
                txtSortCode.Enabled = false;
                txtOverdraft.Enabled = false;
            }
            else if (ReadOnly)
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                txtAddress1.Enabled = false;
                txtAddress2.Enabled = false;
                txtCity.Enabled = false;
                cboCounty.Enabled = false;
                rdoCurrentAcc.Enabled = false;
                rdoSavingsAcc.Enabled = false;
                txtAccountNum.Enabled = false;
                txtSortCode.Enabled = false;
                txtInitialBalance.Enabled = false;
                txtOverdraft.Enabled = false;
            }

            if (fldStudent != null)
            {
                txtFirstName.Text = fldStudent.FirstName;
                txtLastName.Text = fldStudent.LastName;
                txtEmail.Text = fldStudent.Email;
                txtPhone.Text = fldStudent.Phone.ToString();
                txtAddress1.Text = fldStudent.Address1;
                txtAddress2.Text = fldStudent.Address2;
                txtCity.Text = fldStudent.City;
                cboCounty.SelectedItem = fldStudent.County;
                txtInitialBalance.Text = fldStudent.InitialBalance.ToString();
                txtOverdraft.Text = fldStudent.OverDraftLimit.ToString();

                string accType = "Current";
                if (fldStudent.AccountType == accType)
                {
                    rdoCurrentAcc.Checked = true;
                }
                else
                {
                    rdoSavingsAcc.Checked = true;
                }
            }
        }
    }
}
