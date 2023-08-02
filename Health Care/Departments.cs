using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Departments : Form
    {
        HelthCareEntities db = new HelthCareEntities();

        public Departments()
        {
            InitializeComponent();

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


        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (Side_Panel.Width == 50)
            {
                Side_Panel.Width = 376;
                panel3.Height = 959;
                label8.Visible = true;

            }
            else
            {
                label8.Visible = false;
                Side_Panel.Width = 50;
                panel3.Height = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel5.Width == 50)
            {
                panel5.Width = 376;
                panel6.Height = 959;
                label3.Visible = true;

            }
            else
            {
                label3.Visible = false;
                panel5.Width = 50;
                panel6.Height = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Department _Department = new Department();
            _Department.Name = txtDepartmentName.Text;
            db.Departments.Add(_Department);

            db.SaveChanges();
            MessageBox.Show("Department Added Successfully");
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            if (btnUpdateSave.Text == "Add")
            {
                cboDepartmentName.Enabled = true;

                cboDepartmentName.Select();
                btnUpdateSave.Text = "Save";

            }
            else if (btnUpdateSave.Text == "Save")
            {
                cboDepartmentName.Enabled = true;

                Clinic clinic = new Clinic()
                {
                    Department = cboDepartmentName.SelectedItem as Department,
                    ClinicNumber = int.Parse(txtClinicNumber.Text)
                };
                db.Clinics.Add(clinic);
                db.SaveChanges();
                MessageBox.Show("Clinic Added Successfully");
                Clear();

            }
            else if (btnUpdateSave.Text == "Update")
            {
                cboDepartmentName.Enabled = false;
                int clinicId = (int)dgvClinic.CurrentRow.Cells["ClinicID"].Value;
                var clinic = db.Clinics.Where(c => c.ClinicID == clinicId).FirstOrDefault();
                clinic.ClinicNumber = int.Parse(txtClinicNumber.Text.Trim());
                clinic.Department = cboDepartmentName.SelectedItem as Department;

                db.SaveChanges();
                MessageBox.Show("Clinic Updated Successfully");
                Clear();

            }





        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }


        public void Clear()
        {
            cboDepartmentName.DisplayMember = "Name";
            cboDepartmentName.ValueMember = "DepartmentID";
            cboDepartmentName.DataSource = db.Departments.ToList();

            btnDelete.Enabled = false;
            btnUpdateSave.Text = "Add";
            cboDepartmentName.Text = "";
            txtClinicNumber.Text = "";
            dgvClinic.DataSource = (from c in db.Clinics
                                    join d in db.Departments
                                    on c.DepartmentID equals d.DepartmentID
                                    select new
                                    {
                                        c.ClinicID,
                                        c.ClinicNumber,
                                        d.Name
                                    }).ToList();
        }

        private void cboDepartmentName_Click(object sender, EventArgs e)
        {


        }

        private void cboDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvClinic.DataSource = db.Clinics.Where(c => c.DepartmentID == (int)cboDepartmentName.SelectedValue).Select(c => new { c.ClinicID, c.ClinicNumber, c.Department.Name }).ToList();
            dgvClinic.Columns["ClinicID"].Visible = false;
            dgvClinic.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvClinic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Departments_Load(object sender, EventArgs e)
        {
            Clear();

            cboDepartmentName.DisplayMember = "Name";
            cboDepartmentName.ValueMember = "DepartmentID";
            dgvDeparments.DataSource = db.Departments.ToList();


        }

        private void dgvClinic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cboDepartmentName.SelectedItem = db.Clinics
            //  .Where(c => c.ClinicID == (int)dgvClinic.CurrentRow.Cells["ClinicID"].Value)
            //  .Select(c => c.DepartmentID).FirstOrDefault();
        }

        private void dgvClinic_DoubleClick(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdateSave.Text = "Update";

            int clinicID = Convert.ToInt32(dgvClinic.CurrentRow.Cells["ClinicID"].Value);

            cboDepartmentName.SelectedItem = (object)db.Clinics
                                           .Where(c => c.ClinicID == clinicID).FirstOrDefault().Department;

            txtClinicNumber.Text = dgvClinic.CurrentRow.Cells["ClinicNumber"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int clinicId = (int)dgvClinic.CurrentRow.Cells["ClinicID"].Value;
            var clinic = db.Clinics.Where(c => c.ClinicID == clinicId).FirstOrDefault();
            if (MessageBox.Show("Are You Sure To Delete This Clinic", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes && clinic != null)
            {
                db.Clinics.Remove(clinic);
                db.SaveChanges();
                MessageBox.Show("Clinic Deleted Successfully");
            }
            Clear();
        }
    }
}
