using System;
using System.Windows.Forms;

namespace HealthCare
{

    public partial class Dashboard_Admin : Form
    {
        HelthCareEntities db = new HelthCareEntities();
        OverView _OverView = new OverView();
        Doctors _Doctors = new Doctors();
        Nurse _Nurses = new Nurse();
        Secretary _Secretaries = new Secretary();




        public Dashboard_Admin()
        {
            InitializeComponent();
            //Side_Panel.Width = 50;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Side_Panel.Width == 225)
            {
                Side_Panel.Width = 50;
                panel1.Height = 150;
            }
            else
            {
                Side_Panel.Width = 225;
                panel1.Height = 30;

            }
        }



        private void container(object _form)
        {

            if (Contanier_Panel.Controls.Count > 0) Contanier_Panel.Controls.Clear();
            //Contanier_Panel.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            Contanier_Panel.Controls.Add(fm);
            Contanier_Panel.Tag = fm;
            fm.Show();

        }

        private void btn_Doctors_Click_1(object sender, EventArgs e)
        {
            lbl_home.Text = "Doctors";

            _OverView.Close();
            //_Nurses.Close();
            //_Secretaries.Close();
            container(new Doctors());


        }

        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {

            _Doctors.Close();
            //_Nurses.Close();
            //_Secretaries.Close();
            lbl_home.Text = "Over View";
            container(new OverView());
        }

        private void btn_Nurses_Click_1(object sender, EventArgs e)
        {
            _OverView.Close();
            _Doctors.Close();
            lbl_home.Text = "Over View";
            container(new Patients());
        }

        private void btn_Secertary_Click_1(object sender, EventArgs e)
        {

            lbl_home.Text = "Users";
            container(new AddAccount());

        }

        private void btn_Departments_Click(object sender, EventArgs e)
        {
            lbl_home.Text = "Buildings";
            container(new Departments());
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            lbl_home.Text = "Expenses";
            container(new Expenses());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();

            L.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (Side_Panel.Width == 225)
            {
                Side_Panel.Width = 50;
                panel1.Height = 150;
            }
            else
            {
                Side_Panel.Width = 225;
                panel1.Height = 30;

            }
        }

    }

}
