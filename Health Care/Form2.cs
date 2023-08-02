using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Form2 : Form
    {
        HelthCareEntities db = new HelthCareEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvServices.DataSource = db.ShowServices.ToList();
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.Columns["ServiceID"].Visible = false;
            dgvServices.Columns["RelatedServiceID"].Visible = false;
            txtPrice.Enabled = false;


        }

        private void dgvServices_Click(object sender, EventArgs e)
        {
            int serviceId = (int)dgvServices.CurrentRow.Cells["ServiceID"].Value;
            dgvServiceDoctors.DataSource = db.ShowServiceDoctors.Where(s => s.ServiceID == serviceId).ToList();
            dgvServiceDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceDoctors.Columns["DoctorID"].Visible =
            dgvServiceDoctors.Columns["ServiceID"].Visible = false;

            txtPrice.Text = db.Services.FirstOrDefault(S => S.ServiceID == serviceId).Price.ToString();
        }
        private void PopulateDoctorShifts()
        {
            if (dgvServiceDoctors.Rows.Count != 0 && dgvServiceDoctors.SelectedRows.Count != 0)
            {
                int doctorID = (int)dgvServiceDoctors.CurrentRow.Cells["DoctorID"].Value;
                dgvAppointment.DataSource = (from ds in db.DoctorShifts where ds.DoctorID == doctorID && ds.Day != null select ds).ToList();
                dgvAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAppointment.Columns["DoctorID"].Visible = false;
                dgvAppointment.Columns["Name"].Visible = false;
                dgvAppointment.Columns["RowNum"].Visible = false;
                dgvAppointment.Columns["ClinicID"].Visible = false;
                dgvAppointment.Columns["ShiftID"].Visible = false;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShiftCancel_Click(object sender, EventArgs e)
        {

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
            txtPrice.Text =
            txtAppointmentDate.Text = "";
            txtPrice.Enabled = false;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                txtFirstName.Select();
                btnAdd.Text = "Save";
            }
            else if (btnAdd.Text == "Save")
            {
                Contact contact = new Contact();
                contact.FirstName = txtFirstName.Text.Trim();
                contact.MiddleName = txtMiddleName.Text.Trim();
                contact.LastName = txtLastName.Text.Trim();
                contact.Gender = rdoMale.Checked == true ? rdoMale.Text : rdoFemale.Text;
                contact.Phone = txtPhone.Text.Trim();
                contact.City = txtCity.Text.Trim();
                contact.Street = txtStreet.Text.Trim();
                contact.BirthDate = DateTime.Parse(txtBirthDate.Text.Trim());

                Patient patient = new Patient();
                patient.Contact = contact;

                int serviceId = (int)dgvServices.CurrentRow.Cells["ServiceID"].Value;
                int DoctorID = (int)dgvServiceDoctors.CurrentRow.Cells["DoctorID"].Value;
                patient.Reservations.Add(new Reservation()
                {
                    Date = DateTime.Now.Date,
                    Appointment = DateTime.Parse(txtAppointmentDate.Text),
                    ServiceID = serviceId,
                    DoctorID = DoctorID,
                    Price = decimal.Parse(txtPrice.Text),
                    SecretaryID = 11
                });

                db.Patients.Add(patient);
                db.SaveChanges();
                MessageBox.Show("Reservation Done Successfully");
                btnAdd.Text = "Add";
                Clear();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvServiceDoctors_Click(object sender, EventArgs e)
        {
            PopulateDoctorShifts();
        }

        private void grpContact_Enter(object sender, EventArgs e)
        {

        }
    }
}
