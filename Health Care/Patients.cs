using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Patients : Form
    {
        HelthCareEntities db = new HelthCareEntities();


        public Patients()
        {
            InitializeComponent();

            PopulateDepartmentAndDaysData();
            ShiftClear();
        }
        private void PopulateEmployeesInfo()
        {
            using (HelthCareEntities db = new HelthCareEntities()
)
            {
                dgvContact.DataSource = db.EmployeesInfoes.ToList();
                dgvContact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public void Clear()
        {

        }

        public void ShiftClear()
        {
            cboEmployeeTypeShift.Text
               = cboDepartment.Text = cboClinic.Text
               = cboDay.Text = cboShiftName.Text = txtStartTime.Text
               = txtEndTime.Text = "";
            btnShiftUpdateSave.Text = "Update / Save";
            btnShiftUpdateSave.Enabled = false;
            btnShifDelete.Enabled = false;
            pnlDepClinic.Enabled = false;
        }
        private void PopulateDoctorShifts()
        {
            int doctorID = (int)dgvAddShift.CurrentRow.Cells["DoctorID"].Value;
            dgvAppointment.DataSource = (from ds in db.DoctorShifts where ds.DoctorID == doctorID && ds.Day != null select ds).ToList();
            dgvAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointment.Columns["DoctorID"].Visible = false;
            dgvAppointment.Columns["Name"].Visible = false;
            dgvAppointment.Columns["RowNum"].Visible = false;
            dgvAppointment.Columns["ClinicID"].Visible = false;
            dgvAppointment.Columns["ShiftID"].Visible = false;
        }
        private void PopulateNurseShifts()
        {
            int NurseID = (int)dgvAddShift.CurrentRow.Cells["NurseID"].Value;
            dgvAppointment.DataSource = (from n in db.NurseShifts where n.NurseID == NurseID && n.Day != null select n).ToList();
            dgvAppointment.Columns["NurseID"].Visible = false;
            dgvAppointment.Columns["Name"].Visible = false;
            dgvAppointment.Columns["RowNum"].Visible = false;
            dgvAppointment.Columns["ClinicID"].Visible = false;
            dgvAppointment.Columns["ShiftID"].Visible = false;

        }
        private void PopulateSecretaryShifts()
        {
            int secID = (int)dgvAddShift.CurrentRow.Cells["SecretaryID"].Value;
            dgvAppointment.DataSource = (from ss in db.SecretaryShifts where ss.SecretaryID == secID && ss.Day != null select ss).ToList();
            dgvAppointment.Columns["SecretaryID"].Visible = false;
            dgvAppointment.Columns["Name"].Visible = false;
            dgvAppointment.Columns["RowNum"].Visible = false;
            dgvAppointment.Columns["ShiftID"].Visible = false;

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
            ////Employee
            //employee.NationalIDNumber = txtNationalID.Text.Trim();
            //employee.Email = txtEmail.Text;
            //employee.HireDate = DateTime.Parse(txtHireDate.Text.Trim());
            //employee.Salary = Convert.ToDecimal(txtSalary.Text.Trim());
            //employee.Title = cboEmployeeType.Text;

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
                //if (cboEmployeeType.SelectedIndex == ((int)EmployeeType.Doctor))
                //{
                //    doctor.Specialization = txtSpecialization.Text.Trim();
                //    doctor.Employee = employee;
                //    doctor.Employee.Contact = contact;
                //    db.Doctors.Add(doctor);
                //}
                //else if (cboEmployeeType.SelectedIndex == ((int)EmployeeType.Nurse))
                //{
                //    nurse.Employee = employee;
                //    nurse.Employee.Contact = contact;
                //    db.Nurses.Add(nurse);
                //}
                //else if (cboEmployeeType.SelectedIndex == ((int)EmployeeType.Secretary))
                //{
                //    secretary.Employee = employee;
                //    secretary.Employee.Contact = contact;
                //    db.Secretaries.Add(secretary);
                //}

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
                panel1.Hide();
            }
            else
            {
                panel1.Show();
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

            printer.SubTitle = String.Format("Our System Doctors", printer.SubTitleColor = Color.AliceBlue, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "List of Doctors ";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvContact);

        }



        enum EmployeeType
        {
            Doctor = 0,
            Nurse,
            Secretary

        }
        private void dgvContact_DoubleClick(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            if (Side_Panel.Width == 50)
            {
                Side_Panel.Width = 379;
                panel3.Height = 915;
            }
            else
            {

                Side_Panel.Width = 50;
                panel3.Height = 0;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (btnShiftUpdateSave.Text == "Save")
            {
                if (cboEmployeeTypeShift.SelectedItem.ToString() == "Doctor")
                {
                    int doctorID = (int)dgvAddShift.CurrentRow.Cells["DoctorID"].Value;
                    db.Doctor_Clinic_Shifts.Add(new Doctor_Clinic_Shifts()
                    {
                        DoctorID = doctorID,
                        ClinicID = (int)cboClinic.SelectedValue,
                        ShiftID = (int)cboShiftName.SelectedValue,
                        Day = cboDay.Text
                    });
                    db.SaveChanges();
                    MessageBox.Show("Shift Added Successfully");
                    PopulateDoctorShifts();

                }
                else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Secretary")
                {
                    int secID = (int)dgvAddShift.CurrentRow.Cells["SecretaryID"].Value;
                    db.Secretary_Shifts.Add(new Secretary_Shifts()
                    {
                        SecretaryID = secID,
                        ShiftID = (int)cboShiftName.SelectedValue,
                        Day = cboDay.Text
                    });
                    db.SaveChanges();
                    MessageBox.Show("Shift Added Successfully");
                    PopulateSecretaryShifts();

                }
                else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Nurse")
                {
                    int nurseID = (int)dgvAddShift.CurrentRow.Cells["NurseID"].Value;
                    db.Nurse_Clinic_Shifts.Add(new Nurse_Clinic_Shifts()
                    {
                        NurseID = nurseID,
                        ClinicID = (int)cboClinic.SelectedValue,
                        ShiftID = (int)cboShiftName.SelectedValue,
                        Day = cboDay.Text
                    });
                    db.SaveChanges();
                    MessageBox.Show("Shift Added Successfully");
                    PopulateNurseShifts();
                }
                ShiftClear();

            }
        }

        private void PopulateShiftData()
        {
            var Days = CultureInfo.GetCultureInfo("ar-BH").DateTimeFormat.DayNames.ToList();
            cboDay.DataSource = Days;
        }
        private void PopulateDepartmentAndDaysData()
        {
            cboDepartment.DisplayMember = "Name";
            cboDepartment.ValueMember = "DepartmentID";
            //cboDepartment.DataSource = db.Departments.ToList();
            var Days = CultureInfo.GetCultureInfo("ar-BH").DateTimeFormat.DayNames.ToList();
            cboDay.DataSource = Days;
        }
        private void cboShiftName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStartTime.Text = ((Shift)cboShiftName.SelectedItem).StartTime.ToString();
            txtEndTime.Text = ((Shift)cboShiftName.SelectedItem).EndTime.ToString();
        }

        private void dgvAddShift_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void cboDay_Click(object sender, EventArgs e)
        {
            var Days = CultureInfo.GetCultureInfo("ar-BH").DateTimeFormat.DayNames.ToList();
            cboDay.DataSource = Days;
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int depID = (int)cboDepartment.SelectedValue; // or use GetHashCode() and go up and reorder the Department data Source
            cboClinic.DataSource = db.Clinics.Where(cl => cl.DepartmentID == depID).ToList();
            cboClinic.DisplayMember = "ClinicNumber";
            cboClinic.ValueMember = "ClinicID";
        }

        private void cboDepartment_Click(object sender, EventArgs e)
        {
            cboDepartment.DisplayMember = "Name";
            cboDepartment.ValueMember = "DepartmentID";
            cboDepartment.DataSource = db.Departments.ToList();
            // go down
        }

        private void cboShiftName_Click(object sender, EventArgs e)
        {
            cboShiftName.DisplayMember = "Name";
            cboShiftName.ValueMember = "ShiftID";
            cboShiftName.DataSource = db.Shifts.ToList();
        }

        private void cboEmployeeTypeShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmployeeTypeShift.SelectedItem.ToString() == "Doctor")
            {
                dgvAddShift.DataSource = db.ShowDoctors.ToList();
                pnlDepClinic.Enabled = true;
                dgvAddShift.Columns["DoctorID"].Visible = false;
                dgvAddShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Secretary")
            {
                dgvAddShift.DataSource = db.ShowSecretaries.ToList();
                dgvAddShift.Columns["SecretaryID"].Visible = false;
                dgvAddShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Nurse")
            {
                dgvAddShift.DataSource = db.ShowNurses.ToList();
                dgvAddShift.Columns["NurseID"].Visible = false;
                dgvAddShift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnShifDelete_Click(object sender, EventArgs e)
        {
            int shiftID = (int)dgvAppointment.CurrentRow.Cells["ShiftID"].Value;
            if (cboEmployeeTypeShift.SelectedItem.ToString() == "Doctor")
            {
                int clinicID = (int)dgvAppointment.CurrentRow.Cells["ClinicID"].Value;
                int doctorID = (int)dgvAddShift.CurrentRow.Cells["DoctorID"].Value;
                var docotorShift = db.Doctor_Clinic_Shifts
                                   .SingleOrDefault(d => d.ShiftID == shiftID && d.ClinicID == clinicID && d.DoctorID == doctorID && d.Day == cboDay.Text);
                db.Doctor_Clinic_Shifts.Remove(docotorShift);
                db.SaveChanges();
                PopulateDoctorShifts();

            }
            else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Secretary")
            {
                int secID = (int)dgvAddShift.CurrentRow.Cells["SecretaryID"].Value;
                var secretaryShift = db.Secretary_Shifts
                                   .SingleOrDefault(d => d.ShiftID == shiftID && d.SecretaryID == secID && d.Day == cboDay.Text);
                db.Secretary_Shifts.Remove(secretaryShift);
                db.SaveChanges();
                PopulateSecretaryShifts();

            }
            else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Nurse")
            {
                int NurseID = (int)dgvAddShift.CurrentRow.Cells["NurseID"].Value;
                int clinicID = (int)dgvAppointment.CurrentRow.Cells["ClinicID"].Value;
                var nurseShift = db.Nurse_Clinic_Shifts
                                   .SingleOrDefault(d => d.ShiftID == shiftID && d.ClinicID == clinicID && d.NurseID == NurseID && d.Day == cboDay.Text);
                db.Nurse_Clinic_Shifts.Remove(nurseShift);
                db.SaveChanges();
                PopulateNurseShifts();

            }

            MessageBox.Show("Shift Deleted Successfully");

        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            ShiftClear();

        }

        private void dgvAddShift_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvAddShift_Click(object sender, EventArgs e)
        {

            if (cboEmployeeTypeShift.SelectedItem.ToString() == "Doctor")
            {
                PopulateDoctorShifts();
            }
            else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Secretary")
            {
                PopulateSecretaryShifts();
            }
            else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Nurse")
            {

                PopulateNurseShifts();
            }
            txtEmployeeName.Text = dgvAddShift.CurrentRow.Cells["Full_Name"].Value.ToString();

        }

        private void btnShiftAdd_Click(object sender, EventArgs e)
        {
            ShiftClear();
            btnShiftUpdateSave.Text = "Save";
            btnShiftUpdateSave.Enabled = true;

        }

        private void dgvAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointment.Rows.Count != 0)
            {
                if (cboEmployeeTypeShift.SelectedItem.ToString() == "Doctor")
                {
                    int doctorID = (int)dgvAddShift.CurrentRow.Cells["DoctorID"].Value;
                    int clinicID = (int)dgvAppointment.CurrentRow.Cells["ClinicID"].Value;
                    var clinic = db.Clinics.SingleOrDefault(s => s.ClinicID == clinicID);
                    cboDepartment.SelectedItem = clinic.Department;
                    cboClinic.SelectedItem = clinic;

                }
                else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Secretary")
                {
                    int secID = (int)dgvAddShift.CurrentRow.Cells["SecretaryID"].Value;
                }
                else if (cboEmployeeTypeShift.SelectedItem.ToString() == "Nurse")
                {
                    int NurseID = (int)dgvAddShift.CurrentRow.Cells["NurseID"].Value;
                    int clinicID = (int)dgvAppointment.CurrentRow.Cells["ClinicID"].Value;
                    var clinic = db.Clinics.SingleOrDefault(s => s.ClinicID == clinicID);
                    cboDepartment.SelectedItem = clinic.Department;
                    cboClinic.SelectedItem = clinic;
                }

                int shiftID = (int)dgvAppointment.CurrentRow.Cells["ShiftID"].Value;
                cboShiftName.SelectedItem = db.Shifts.SingleOrDefault(s => s.ShiftID == shiftID);
                cboDay.Text = dgvAppointment.CurrentRow.Cells["Day"].Value.ToString();
                btnShifDelete.Enabled = true;
                btnShiftUpdateSave.Text = "Update";
                btnShiftUpdateSave.Enabled = true;
            }
        }

        private void dgvAddShift_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboShiftName.DisplayMember = "Name";
            cboShiftName.ValueMember = "ShiftID";
            cboShiftName.DataSource = db.Shifts.ToList();

        }

    }
}
