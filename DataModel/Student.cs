using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Student
    {
        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string AccountType { get; set; }
        public int AccountNo { get; set; }
        public int SortCode { get; set; }
        public int InitialBalance { get; set; }
        public int OverDraftLimit { get; set; }

        public override string ToString()
        {
            return String.Format("FirstName = {0}, LastName = {1}, Email = {2}, Phone = {3}, Address1 = {4}, Address2 = {5}, City = {6}, County = {7}, AccountTye = {8}, AccountNo = {9}, SortCode = {10}, InitalBalance = {11}, OverDraftLimit = {12}", FirstName, LastName, Email, Phone, Address1, Address2, City, County, AccountType, AccountNo, SortCode, InitialBalance, OverDraftLimit);
        }
    }
}
