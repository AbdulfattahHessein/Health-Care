using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class AddAccount : Form
    {
        HelthCareEntities db = new HelthCareEntities();

        private string loginID = "";
        public AddAccount()
        {
            InitializeComponent();

            PopulateInfo();

        }
        private void PopulateInfo()
        {
            HelthCareEntities db = new HelthCareEntities();
            {
                dgvContact.DataSource = db.ShowAllAccounts.ToList();
                dgvContact.Columns["EmployeeID"].Visible = false;
                dgvContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btnUpdateSave.Text == "Save")
            {
                //ADD
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("You Should Enter UserName", "Login Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (dgvLoginUsers.SelectedRows.Count > 0)
                {
                    UserLogin user = new UserLogin()
                    {
                        LoginID = txtUserName.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        AccountType = cboRole.Text
                    };
                    if (cboRole.Text == "Doctor")
                    {
                        int docID = (int)dgvLoginUsers.CurrentRow.Cells["DoctorID"].Value;
                        Doctor doctor = db.Doctors.SingleOrDefault(d => d.DoctorID == docID);

                        user.Doctors.Add(doctor);
                        db.UserLogins.Add(user);
                        db.SaveChanges();

                    }
                    else if (cboRole.Text == "Secretary")
                    {
                        int secID = (int)dgvLoginUsers.CurrentRow.Cells["SecretaryID"].Value;
                        Secretary secretary = db.Secretaries.SingleOrDefault(s => s.SecretaryID == secID);
                        user.Secretaries.Add(secretary);
                        db.UserLogins.Add(user);
                        db.SaveChanges();

                    }
                    else if (cboRole.Text == "Admin")
                    {
                        int docID = (int)dgvLoginUsers.CurrentRow.Cells["DoctorID"].Value;

                        int employeeID = db.Doctors.SingleOrDefault(d => d.DoctorID == docID).EmployeeID;
                        Admin admin = new Admin()
                        {
                            EmployeeID = employeeID,
                            UserLogin = user
                        };
                        db.Admins.Add(admin);
                        db.SaveChanges();

                    }
                    MessageBox.Show(" User Added Successfuly", "Add User Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btnUpdateSave.Text == "Update")
            {
                //edit
                UserLogin userLogin = db.UserLogins.SingleOrDefault(u => u.LoginID == loginID);
                userLogin.LoginID = txtUserName.Text.Trim();
                userLogin.Password = txtPassword.Text;
                userLogin.AccountType = cboRole.Text;
                db.UserLogins.Attach(userLogin);
                db.Entry(userLogin).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show(" User Updated Successfuly", "Add User Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Clear();

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab == tabPage2)
            {
                panel1.Hide();
                PopulateInfo();

            }
            else
            {
                panel1.Show();
                PopulateInfo();

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var userid = dgvContact.CurrentRow.Cells["LoginID"].Value.ToString();
            var user = db.UserLogins.Where(u => u.LoginID == userid).FirstOrDefault();
            if (MessageBox.Show("Are You Sure To Delete This User", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes && user != null)
            {
                db.UserLogins.Remove(user);
                db.SaveChanges();
                MessageBox.Show("Account Deleted Successfully");
                PopulateInfo();

            }

        }



        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Users Info";
            printer.PageSettings.Landscape = true;
            printer.PageSettings.PaperSize.Kind.Equals(System.Drawing.Printing.PaperKind.LetterExtra);

            printer.SubTitle = String.Format("Our System Users", printer.SubTitleColor = Color.AliceBlue, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "List of Users ";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvContact);

        }

        private void Clear()
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            cboRole.SelectedText = "";
            loginID = "";
            btnUpdateSave.Text = "Save";

        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            Clear();
            guna2TabControl1.SelectedTab = tabPage2;
        }

        private void edt_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRole.Text == "Doctor" || cboRole.Text == "Admin")
            {
                dgvLoginUsers.DataSource = db.ShowDoctors.ToList();
                dgvLoginUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLoginUsers.Columns["DoctorID"].Visible = false;

            }
            else if (cboRole.Text == "Secretary")
            {
                dgvLoginUsers.DataSource = db.ShowSecretaries.ToList();
                dgvLoginUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLoginUsers.Columns["SecretaryID"].Visible = false;

            }
        }
        private void dgvContact_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dgvContact.CurrentRow.Cells["LoginID"].Value.ToString();
            txtPassword.Text = dgvContact.CurrentRow.Cells["Password"].Value.ToString();
            loginID = dgvContact.CurrentRow.Cells["LoginID"].Value.ToString();

            guna2TabControl1.SelectedTab = tabPage2;
            cboRole.SelectedIndex = cboRole.FindStringExact(db.UserLogins.Where(u => u.LoginID == loginID).Select(u => u.AccountType).SingleOrDefault());
            btnUpdateSave.Text = "Update";
        }
    }
}
