namespace HealthCare
{
    partial class Form2
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
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.dgvServiceDoctors = new System.Windows.Forms.DataGridView();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblApointmentDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtStreet = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAppointmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(506, 11);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 26;
            this.dgvServices.Size = new System.Drawing.Size(750, 299);
            this.dgvServices.TabIndex = 33;
            this.dgvServices.Click += new System.EventHandler(this.dgvServices_Click);
            // 
            // dgvServiceDoctors
            // 
            this.dgvServiceDoctors.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvServiceDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceDoctors.Location = new System.Drawing.Point(506, 323);
            this.dgvServiceDoctors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServiceDoctors.Name = "dgvServiceDoctors";
            this.dgvServiceDoctors.RowHeadersWidth = 51;
            this.dgvServiceDoctors.RowTemplate.Height = 26;
            this.dgvServiceDoctors.Size = new System.Drawing.Size(750, 205);
            this.dgvServiceDoctors.TabIndex = 34;
            this.dgvServiceDoctors.Click += new System.EventHandler(this.dgvServiceDoctors_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Location = new System.Drawing.Point(506, 542);
            this.dgvAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersWidth = 51;
            this.dgvAppointment.RowTemplate.Height = 26;
            this.dgvAppointment.Size = new System.Drawing.Size(750, 196);
            this.dgvAppointment.TabIndex = 35;
            // 
            // lblPrice
            // 
            this.lblPrice.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblPrice.Location = new System.Drawing.Point(28, 483);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 20);
            this.lblPrice.TabIndex = 37;
            this.lblPrice.Text = "Price";
            // 
            // lblApointmentDate
            // 
            this.lblApointmentDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblApointmentDate.AutoSize = true;
            this.lblApointmentDate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblApointmentDate.Location = new System.Drawing.Point(28, 548);
            this.lblApointmentDate.Name = "lblApointmentDate";
            this.lblApointmentDate.Size = new System.Drawing.Size(134, 20);
            this.lblApointmentDate.TabIndex = 39;
            this.lblApointmentDate.Text = "Apointment Date";
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 865);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 78);
            this.panel2.TabIndex = 40;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(943, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 62);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(72, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(358, 62);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BorderRadius = 15;
            this.txtBirthDate.Checked = true;
            this.txtBirthDate.FillColor = System.Drawing.Color.White;
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtBirthDate.Location = new System.Drawing.Point(186, 411);
            this.txtBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(251, 34);
            this.txtBirthDate.TabIndex = 195;
            this.txtBirthDate.Value = new System.DateTime(2022, 8, 16, 5, 51, 44, 613);
            // 
            // txtStreet
            // 
            this.txtStreet.BorderRadius = 15;
            this.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStreet.DefaultText = "";
            this.txtStreet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStreet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStreet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStreet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStreet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStreet.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStreet.Location = new System.Drawing.Point(311, 346);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.PasswordChar = '\0';
            this.txtStreet.PlaceholderText = "";
            this.txtStreet.SelectedText = "";
            this.txtStreet.Size = new System.Drawing.Size(119, 34);
            this.txtStreet.TabIndex = 194;
            // 
            // txtCity
            // 
            this.txtCity.BorderRadius = 15;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.DefaultText = "";
            this.txtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCity.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCity.Location = new System.Drawing.Point(186, 346);
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PlaceholderText = "";
            this.txtCity.SelectedText = "";
            this.txtCity.Size = new System.Drawing.Size(119, 34);
            this.txtCity.TabIndex = 193;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label30.Location = new System.Drawing.Point(28, 353);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 20);
            this.label30.TabIndex = 192;
            this.label30.Text = "City , Street";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 15;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(186, 284);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(244, 34);
            this.txtPhone.TabIndex = 191;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderRadius = 15;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(186, 165);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(244, 34);
            this.txtLastName.TabIndex = 190;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderRadius = 15;
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiddleName.DefaultText = "";
            this.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleName.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleName.Location = new System.Drawing.Point(186, 100);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.PlaceholderText = "";
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.Size = new System.Drawing.Size(244, 34);
            this.txtMiddleName.TabIndex = 189;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderRadius = 15;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(186, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(244, 34);
            this.txtFirstName.TabIndex = 188;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblBirthDate.Location = new System.Drawing.Point(28, 418);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(80, 20);
            this.lblBirthDate.TabIndex = 187;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // pnlGender
            // 
            this.pnlGender.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlGender.Controls.Add(this.rdoMale);
            this.pnlGender.Controls.Add(this.rdoFemale);
            this.pnlGender.Location = new System.Drawing.Point(186, 230);
            this.pnlGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(239, 20);
            this.pnlGender.TabIndex = 181;
            // 
            // rdoMale
            // 
            this.rdoMale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(10, 2);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(47, 17);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rdoFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(115, 2);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblGender.Location = new System.Drawing.Point(28, 230);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 20);
            this.lblGender.TabIndex = 185;
            this.lblGender.Text = "Gender";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblMiddleName.Location = new System.Drawing.Point(28, 107);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(108, 20);
            this.lblMiddleName.TabIndex = 186;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblLastName.Location = new System.Drawing.Point(28, 172);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 20);
            this.lblLastName.TabIndex = 183;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblFirstName.Location = new System.Drawing.Point(28, 42);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 184;
            this.lblFirstName.Text = "First Name";
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.BorderRadius = 15;
            this.txtAppointmentDate.Checked = true;
            this.txtAppointmentDate.FillColor = System.Drawing.Color.White;
            this.txtAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtAppointmentDate.Location = new System.Drawing.Point(186, 541);
            this.txtAppointmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtAppointmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(251, 34);
            this.txtAppointmentDate.TabIndex = 197;
            this.txtAppointmentDate.Value = new System.DateTime(2022, 8, 16, 5, 51, 44, 613);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 15;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(186, 476);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(251, 34);
            this.txtPrice.TabIndex = 196;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(22, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 199;
            this.label2.Text = "Phone";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 943);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.pnlGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblApointmentDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dgvAppointment);
            this.Controls.Add(this.dgvServiceDoctors);
            this.Controls.Add(this.dgvServices);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridView dgvServiceDoctors;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblApointmentDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtStreet;
        private Guna.UI2.WinForms.Guna2TextBox txtCity;
        private System.Windows.Forms.Label label30;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtMiddleName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtAppointmentDate;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label2;
    }
}