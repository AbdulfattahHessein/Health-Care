using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class OverView : Form
    {
        HelthCareEntities db = new HelthCareEntities();

        public OverView()
        {
            InitializeComponent();

            dgvExpenses.DataSource = (from c in db.Expenses
                                      select new
                                      {
                                          c.Expenses_ID,
                                          c.Expenses_Type,
                                          c.Expenses_Coast,
                                          c.Date
                                      }).ToList();

            //---------------

            dgvSalaries.DataSource = (from c in db.Employees
                                      select new
                                      {
                                          c.ContactID,
                                          c.Title,
                                          c.Salary
                                      }).ToList();

            //---------------


            gdvEmployees.DataSource = db.EmployeesInfoes.ToList();
            gdvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




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

        private void pan_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OverView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\HelthCare.mdf;integrated security=True");

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select count(*) from [dbo].[Employee] where [Title] = 'Doctor'", con);
            SqlCommand cmd2 = new SqlCommand("select count(*) from [dbo].[Employee] where [Title] = 'Nurse' ", con);
            SqlCommand cmd3 = new SqlCommand("select count(*) from [dbo].[Employee] where [Title] = 'Secretary'", con);
            SqlCommand salaries = new SqlCommand("SELECT SUM([Salary])FROM [dbo].[Employee]", con);
            SqlCommand exp = new SqlCommand("SELECT SUM([Expenses_Coast]) FROM [dbo].[Expenses]", con);
            SqlCommand profit = new SqlCommand("SELECT SUM([Price]) FROM  Reservation ", con);

            var DocCount = cmd1.ExecuteScalar();
            var NurCount = cmd2.ExecuteScalar();
            var SecCount = cmd3.ExecuteScalar();
            var Salaries = salaries.ExecuteScalar();
            var Expenses = exp.ExecuteScalar();
            var Profit = profit.ExecuteScalar();

            lbl_DocNumber.Text = DocCount.ToString();
            lbl_NurNumber.Text = NurCount.ToString();
            lblSec_Number.Text = SecCount.ToString();
            lblSalaries.Text = Salaries.ToString();
            lblexpenes.Text = Expenses.ToString();
            lblProfit.Text = Profit.ToString();


            con.Close();


            double _salary = double.Parse(lblSalaries.Text);
            double _Expenses = double.Parse(lblexpenes.Text);
            double _Profit = double.Parse(lblProfit.Text);
            double Total = _Profit - (_salary + _Expenses);

            lblTotal.Text = Total.ToString();

        }
    }
}
