using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Expenses : Form
    {
        HelthCareEntities db = new HelthCareEntities();

        public Expenses()
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


                btnUpdateSave.Text = "Save";

            }
            else if (btnUpdateSave.Text == "Save")
            {
                txtDate.Enabled = true;
                Expens ex = new Expens()
                {
                    Expenses_Type = txtExpensestype.Text,
                    Expenses_Coast = int.Parse(txtCoast.Text),
                    Date = DateTime.Parse(txtDate.Text),
                };
                db.Expenses.Add(ex);
                db.SaveChanges();
                MessageBox.Show("Expenses Added Successfully");
                Clear();

            }
            else if (btnUpdateSave.Text == "Update")
            {
                txtDate.Enabled = false;

                int exID = (int)dgvClinic.CurrentRow.Cells["Expenses_ID"].Value;
                var Ex = db.Expenses.Where(c => c.Expenses_ID == exID).FirstOrDefault();
                Ex.Expenses_Coast = decimal.Parse(txtCoast.Text.Trim());
                Ex.Expenses_Type = txtExpensestype.Text.Trim();

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

            btnDelete.Enabled = false;
            btnUpdateSave.Text = "Add";
            txtDate.Enabled = true;

            txtExpensestype.Text = "";
            txtCoast.Text = "";
            dgvClinic.DataSource = (from c in db.Expenses
                                    select new
                                    {
                                        c.Expenses_ID,
                                        c.Expenses_Type,
                                        c.Expenses_Coast,
                                        c.Date
                                    }).ToList();
        }




        private void dgvClinic_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Departments_Load(object sender, EventArgs e)
        {
            Clear();



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
            txtDate.Enabled = false;

            int ExpensesID = Convert.ToInt32(dgvClinic.CurrentRow.Cells["Expenses_ID"].Value);

            txtExpensestype.Text = dgvClinic.CurrentRow.Cells["Expenses_Type"].Value.ToString();

            txtCoast.Text = dgvClinic.CurrentRow.Cells["Expenses_Coast"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ExpensesID = (int)dgvClinic.CurrentRow.Cells["Expenses_ID"].Value;
            var Exp = db.Expenses.Where(c => c.Expenses_ID == ExpensesID).FirstOrDefault();
            if (MessageBox.Show("Are You Sure To Delete This Expense", "Delete Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes && Exp != null)
            {
                db.Expenses.Remove(Exp);
                db.SaveChanges();
                MessageBox.Show("Expense Deleted Successfully");
            }
            Clear();
        }
    }
}
