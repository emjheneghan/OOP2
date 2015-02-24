namespace Assignment
{
    partial class EditAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataModel.Student student1 = new DataModel.Student();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccount));
            this.btnBack = new System.Windows.Forms.Button();
            this.userEditAccount = new Assignment.CustomerTemplate();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(447, 327);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userEditAccount
            // 
            this.userEditAccount.EditOnly = true;
            this.userEditAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.userEditAccount.Location = new System.Drawing.Point(40, 45);
            this.userEditAccount.Name = "userEditAccount";
            this.userEditAccount.ReadOnly = false;
            this.userEditAccount.Size = new System.Drawing.Size(442, 226);
            student1.AccountNo = 0;
            student1.AccountType = "";
            student1.Address1 = "";
            student1.Address2 = "";
            student1.City = "";
            student1.County = "Antrim";
            student1.Email = "";
            student1.FirstName = "";
            student1.InitialBalance = 0;
            student1.LastName = "";
            student1.OverDraftLimit = 0;
            student1.Phone = 0;
            student1.SortCode = 0;
            this.userEditAccount.Student = student1;
            this.userEditAccount.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(357, 327);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(534, 362);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.userEditAccount);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Credit Union - Edit Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private CustomerTemplate userEditAccount;
        private System.Windows.Forms.Button btnEdit;
    }
}