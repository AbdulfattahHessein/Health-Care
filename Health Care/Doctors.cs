using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Doctors : Form
    {
        HelthCareEntities db = new HelthCareEntities();

        public Doctors()
        {
            InitializeComponent();

            Clear();
            PopulateEmployeesInfo();
        }
        private void PopulateEmployeesInfo()
        {
            using (HelthCareEntities db = new HelthCareEntities()
)
            {
                dgvContact.DataSource = db.EmployeesInfoes.ToList();
                dgvContact.Columns["ContactId"].Visible = false;
                dgvContact.Columns["EmployeeId"].Visible = false;

                dgvContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
        }
        public void Clear()
        {
            rdoMale.Checked = rdoFemale.Checked = false;
            txtFirstName.Text =
            txtMiddleName.Text =
            txtLastName.Text =
            txtPhone.Text =
            txtCity.Text =
            txtStreet.Text =
            txtBirthDate.Text =
            txtNationalID.Text =
            txtEmail.Text =
            txtHireDate.Text =
            txtSalary.Text =
            txtSpecialization.Text =
            cboEmployeeType.Text = "";
            //btnDelete.Enabled = false;
            //btnUpdateSave.Enabled = false;
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
        private void EmployeeContact(Employee employee, Contact contact)
        {
            //Contact
            contact.FirstName = txtFirstName.Text.Trim();
            contact.MiddleName = txtMiddleName.Text.Trim();
            contact.LastName = txtLastName.Text.Trim();
            contact.Gender = rdoMale.Checked == true ? rdoMale.Text : rdoFemale.Text;
            contact.Phone = txtPhone.Text.Trim();
            contact.City = txtCity.Text.Trim();
            contact.Street = txtStreet.Text.Trim();
            contact.BirthDate = DateTime.Parse(txtBirthDate.Text.Trim());
            //Employee
            employee.NationalIDNumber = txtNationalID.Text.Trim();
            employee.Email = txtEmail.Text;
            employee.HireDate = DateTime.Parse(txtHireDate.Text.Trim());
            employee.Salary = Convert.ToDecimal(txtSalary.Text.Trim());
            employee.Title = cboEmployeeType.Text;

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {



            if (btnUpdateSave.Text == "Save")
            {
                Contact contact = new Contact();
                Employee employee = new Employee();
                Doctor doctor = new Doctor();
                Nurse nurse = new Nurse();
                Secretary secretary = new Secretary();
                EmployeeContact(employee, contact);
                if (cboEmployeeType.SelectedIndex == ((int)EmployeeType.Doctor))
                {
                    doctor.Specialization = txtSpecialization.Text.Trim();
                    doctor.Employee = employee;
                    doctor.Employee.Contact = contact;
                    db.Doctors.Add(doctor);
                }
                else if (cboEmployeeType.SelectedIndex == ((int)EmployeeType.Nurse))
                {
                    nurse.Employee = employee;
                    nurse.Employee.Contact = contact;
                    db.Nurses.Add(nurse);
                }
                else if (cboEmployeeType.SelectedIndex == ((int)EmployeeType.Secretary))
                {
                    secretary.Employee = employee;
                    secretary.Employee.Contact = contact;
                    db.Secretaries.Add(secretary);
                }

                db.SaveChanges();
                MessageBox.Show("Employee Added Successfully");
            }
            else if (btnUpdateSave.Text == "Update")
            {
                int contactID = Convert.ToInt32(dgvContact.CurrentRow.Cells["ContactID"].Value);
                int employeeID = Convert.ToInt32(dgvContact.CurrentRow.Cells["EmployeeID"].Value);
                Contact contact = db.Contacts.Where(c => c.ContactID == contactID).SingleOrDefault();
                Employee employee = db.Employees.Where(em => em.EmployeeID == employeeID).SingleOrDefault();
                EmployeeContact(employee, contact);
                db.SaveChanges();
                MessageBox.Show("Employee Updated Successfully");
            }
            Clear();
            PopulateEmployeesInfo();


        }



        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab == tabPage2)
            {
                //panel1.Hide();
            }
            else
            {
                //panel1.Show();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32(dgvContact.CurrentRow.Cells["ContactID"].Value);
            int employeeID = Convert.ToInt32(dgvContact.CurrentRow.Cells["EmployeeID"].Value);

            Contact contact = db.Contacts.Where(c => c.ContactID == contactID).SingleOrDefault();
            Employee employee = db.Employees.Where(em => em.EmployeeID == employeeID).SingleOrDefault();
            db.Employees.Remove(employee);
            if (MessageBox.Show("Are You Sure To Delete This Record", "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes && contact != null)
                db.Contacts.Remove(contact);
            db.SaveChanges();

            PopulateEmployeesInfo();
            Clear();

        }



        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //guna2TabControl1.SelectedTab= tabPage2; 
            //int contactID = Convert.ToInt32(dgvContact.CurrentRow.Cells["ContactID"].Value);
            //int employeeID = Convert.ToInt32(dgvContact.CurrentRow.Cells["EmployeeID"].Value);
            //Contact contact = db.Contacts.Where(c => c.ContactID == contactID).SingleOrDefault();
            //Employee employee = db.Employees.Where(em => em.EmployeeID == employeeID).SingleOrDefault();
            //EmployeeContact(employee, contact);
            //db.SaveChanges();
            //MessageBox.Show("Employee Updated Successfully");

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Doctors Info";
            printer.PageSettings.Landscape = true;
            printer.PageSettings.PaperSize.Kind.Equals(System.Drawing.Printing.PaperKind.LetterExtra);
            //printer.CellAlignment.Equals()

            printer.SubTitle = String.Format("Our System Doctors", printer.SubTitleColor = Color.AliceBlue, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "List of Doctors ";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvContact);


            //using (HelthCenterEntities db = new HelthCenterEntities())
            //{



            //int height = dgvContact.Height;
            //dgvContact.Height = dgvContact.RowCount * dgvContact.RowTemplate.Height * 2;
            //bmp = new Bitmap(dgvContact.Width, dgvContact.Height);
            //dgvContact.DrawToBitmap(bmp,new Rectangle(0,0,dgvContact.Width,dgvContact.Height));
            //dgvContact.Height = height;
            //printPreviewDialog1.Show();

            //}

        }



        enum EmployeeType
        {
            Doctor = 0,
            Nurse,
            Secretary

        }
        private void dgvContact_DoubleClick(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedTab = tabPage2;
            tabPage2.Text = "Edit Employee";
            if (dgvContact.CurrentRow.Index != -1)
            {
                btnUpdateSave.Text = "Update";
                int contactID = Convert.ToInt32(dgvContact.CurrentRow.Cells["ContactID"].Value);
                int employeeID = Convert.ToInt32(dgvContact.CurrentRow.Cells["EmployeeID"].Value);

                Contact contact = db.Contacts.Where(c => c.ContactID == contactID).SingleOrDefault();
                //Contact
                txtFirstName.Text = contact.FirstName;
                txtMiddleName.Text = contact.MiddleName;
                txtLastName.Text = contact.LastName;

                if (contact.Gender == rdoMale.Text)
                    rdoMale.Checked = true;
                else rdoFemale.Checked = true;

                txtPhone.Text = contact.Phone;
                txtCity.Text = contact.City;
                txtStreet.Text = contact.Street;
                txtBirthDate.Text = contact.BirthDate.ToString();
                Employee employee = db.Employees.Where(em => em.EmployeeID == employeeID).SingleOrDefault();
                //Employee
                txtNationalID.Text = employee.NationalIDNumber;
                txtEmail.Text = employee.Email;
                txtHireDate.Text = employee.HireDate.ToString();
                txtSalary.Text = employee.Salary.ToString();

                Doctor doctor = db.Doctors.Where(d => d.EmployeeID == employeeID).SingleOrDefault();
                Nurse nurse = db.Nurses.Where(n => n.EmployeeID == employeeID).SingleOrDefault();
                Secretary secretary = db.Secretaries.Where(s => s.EmployeeID == employeeID).SingleOrDefault();

                if (employee.Title == EmployeeType.Nurse.ToString())
                {
                    cboEmployeeType.SelectedIndex = (int)EmployeeType.Nurse;
                }
                else if (employee.Title == EmployeeType.Doctor.ToString())
                {
                    cboEmployeeType.SelectedIndex = (int)EmployeeType.Doctor;
                    txtSpecialization.Text = doctor.Specialization;

                }
                else if (employee.Title == EmployeeType.Secretary.ToString())
                {
                    cboEmployeeType.SelectedIndex = (int)EmployeeType.Secretary;
                }
                cboEmployeeType.Enabled = false;
            }
        }

        private void dgvContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnDelete.Enabled = true;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            tabPage2.Text = "Add Employee";
            btnUpdateSave.Text = "Save";
            guna2TabControl1.SelectedTab = tabPage1;
            cboEmployeeType.Enabled = true;
            PopulateEmployeesInfo();
            Clear();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            tabPage2.Text = "Add Employee";
            btnUpdateSave.Text = "Save";
            guna2TabControl1.SelectedTab = tabPage2;

        }

        private void cboEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmployeeType.Text == "Doctor")
            {

                label2.Visible = true;
                txtSpecialization.Visible = true;
            }
            else
            {
                label2.Visible = false;
                txtSpecialization.Visible = false;

            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string no = txtPhone.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{9}$)+$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                lbl_PhoneErorr.ForeColor = Color.Green;
                lbl_PhoneErorr.Text = "Correct";

            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_Click(object sender, EventArgs e)
        {
            string no = txtPhone.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{9}$)+$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                lbl_PhoneErorr.ForeColor = Color.Green;
                lbl_PhoneErorr.Text = "Correct";

            }
            else
            {
                lbl_PhoneErorr.ForeColor = Color.Red;
                lbl_PhoneErorr.Text = "Phone number Must be 11 Degit";

            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            string no = txtNationalID.Text;
            Regex regex = new Regex(@"^([1-9]{1})([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{2})[0-9]{3}([0-9]{1})[0-9]{1}$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Correct";

            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "National ID Must be 14 Degit";

            }
        }

        private void txtNationalID_TextChanged(object sender, EventArgs e)
        {
            string no = txtNationalID.Text;
            Regex regex = new Regex(@"^([1-9]{1})([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{2})[0-9]{3}([0-9]{1})[0-9]{1}$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Correct";

            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string no = txtEmail.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Correct";

            }
            //else
            //{
            //    label3.ForeColor = Color.Red;
            //    label3.Text = "National ID Must be 14 Degit";

            //}
        }

        private void txtHireDate_Click(object sender, EventArgs e)
        {
            string no = txtEmail.Text;
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Correct";

            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Email Must be Valid ( Examble@gmail.com )";

            }
        }

        private void btn_image_Upload_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Doctors_Load(object sender, EventArgs e)
        {

            //dgvContact.DataSource = db.Departments.ToList();

        }


    }
}
