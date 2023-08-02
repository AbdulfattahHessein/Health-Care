using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HealthCare
{
    public partial class Login : Form
    {


        HelthCareEntities db = new HelthCareEntities();
        Dashboard_Admin da = new Dashboard_Admin();
        DashboardSec ds = new DashboardSec();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Login()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
        private void btn_Login_Click(object sender, EventArgs e)
        {


            HelthCareEntities db = new HelthCareEntities();


            if (edt_UserName.Text == "")
            {
                MessageBox.Show("You Should Enter UserName", "Login Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (edt_Pass.Text == "")
            {
                MessageBox.Show("You Should Enter Password", "Login Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                UserLogin userLogin = new UserLogin();
                userLogin = db.UserLogins.Where(x => x.LoginID == edt_UserName.Text && x.Password == edt_Pass.Text).FirstOrDefault();

                if (userLogin != null)
                {
                    da.lbl_UserName.Text = edt_UserName.Text;
                    ds.lbl_UserName.Text = edt_UserName.Text;
                    if (userLogin.AccountType == "Admin")
                    {
                        da.Show();
                        db.SaveChanges();
                        this.Hide();
                    }
                    else if (userLogin.AccountType == "Secretary")
                    {
                        ds.Show();
                        db.SaveChanges();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Falid Login", "Login Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
