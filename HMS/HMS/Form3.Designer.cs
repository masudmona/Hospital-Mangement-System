namespace HMS
{
    partial class Form3_patient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_patient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.openPatientTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_patient = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.text_app = new System.Windows.Forms.TextBox();
            this.label_app = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.text_bg = new System.Windows.Forms.TextBox();
            this.label_bg = new System.Windows.Forms.Label();
            this.text_disease = new System.Windows.Forms.TextBox();
            this.label_disease = new System.Windows.Forms.Label();
            this.text_contact = new System.Windows.Forms.TextBox();
            this.label_contact = new System.Windows.Forms.Label();
            this.text_address = new System.Windows.Forms.TextBox();
            this.label_addrress = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.text_age = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new HMS.HMSDataSetTableAdapters.PatientTableAdapter();
            this.dataGridView_patient = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2.SuspendLayout();
            this.tabControl_patient.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.dashboardToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.apointmentToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1286, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menu";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPatientTableToolStripMenuItem,
            this.doctorToolStripMenuItem1,
            this.employeeTableToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(37, 20);
            this.Menu.Text = "File";
            // 
            // openPatientTableToolStripMenuItem
            // 
            this.openPatientTableToolStripMenuItem.Name = "openPatientTableToolStripMenuItem";
            this.openPatientTableToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.openPatientTableToolStripMenuItem.Text = "Open Patient Table";
            // 
            // doctorToolStripMenuItem1
            // 
            this.doctorToolStripMenuItem1.Name = "doctorToolStripMenuItem1";
            this.doctorToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.doctorToolStripMenuItem1.Text = "Doctor ";
            // 
            // employeeTableToolStripMenuItem
            // 
            this.employeeTableToolStripMenuItem.Name = "employeeTableToolStripMenuItem";
            this.employeeTableToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.employeeTableToolStripMenuItem.Text = "Employee table";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // apointmentToolStripMenuItem
            // 
            this.apointmentToolStripMenuItem.Name = "apointmentToolStripMenuItem";
            this.apointmentToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.apointmentToolStripMenuItem.Text = "Apointment";
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.storeToolStripMenuItem.Text = "Store";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tabControl_patient
            // 
            this.tabControl_patient.Controls.Add(this.tabPage1);
            this.tabControl_patient.Controls.Add(this.tabPage2);
            this.tabControl_patient.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_patient.ItemSize = new System.Drawing.Size(70, 40);
            this.tabControl_patient.Location = new System.Drawing.Point(0, 27);
            this.tabControl_patient.Name = "tabControl_patient";
            this.tabControl_patient.SelectedIndex = 0;
            this.tabControl_patient.Size = new System.Drawing.Size(1302, 681);
            this.tabControl_patient.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.dateTimePicker_date);
            this.tabPage1.Controls.Add(this.comboBox_gender);
            this.tabPage1.Controls.Add(this.button_cancel);
            this.tabPage1.Controls.Add(this.button_save);
            this.tabPage1.Controls.Add(this.text_app);
            this.tabPage1.Controls.Add(this.label_app);
            this.tabPage1.Controls.Add(this.label_date);
            this.tabPage1.Controls.Add(this.text_bg);
            this.tabPage1.Controls.Add(this.label_bg);
            this.tabPage1.Controls.Add(this.text_disease);
            this.tabPage1.Controls.Add(this.label_disease);
            this.tabPage1.Controls.Add(this.text_contact);
            this.tabPage1.Controls.Add(this.label_contact);
            this.tabPage1.Controls.Add(this.text_address);
            this.tabPage1.Controls.Add(this.label_addrress);
            this.tabPage1.Controls.Add(this.label_gender);
            this.tabPage1.Controls.Add(this.text_age);
            this.tabPage1.Controls.Add(this.label_age);
            this.tabPage1.Controls.Add(this.text_name);
            this.tabPage1.Controls.Add(this.label_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Patient";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(179, 379);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(109, 26);
            this.dateTimePicker_date.TabIndex = 4;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(471, 85);
            this.comboBox_gender.MinimumSize = new System.Drawing.Size(126, 0);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(126, 26);
            this.comboBox_gender.TabIndex = 3;
            this.comboBox_gender.Text = "<Select>";
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(587, 409);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(478, 409);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_app
            // 
            this.text_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_app.Location = new System.Drawing.Point(471, 316);
            this.text_app.Name = "text_app";
            this.text_app.Size = new System.Drawing.Size(191, 26);
            this.text_app.TabIndex = 1;
            this.text_app.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label_app
            // 
            this.label_app.AutoSize = true;
            this.label_app.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_app.Location = new System.Drawing.Point(316, 316);
            this.label_app.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_app.Name = "label_app";
            this.label_app.Size = new System.Drawing.Size(122, 25);
            this.label_app.TabIndex = 0;
            this.label_app.Text = "Appointment no";
            this.label_app.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(24, 379);
            this.label_date.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(120, 25);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "Entry Date";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_bg
            // 
            this.text_bg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_bg.Location = new System.Drawing.Point(179, 315);
            this.text_bg.Name = "text_bg";
            this.text_bg.Size = new System.Drawing.Size(109, 26);
            this.text_bg.TabIndex = 1;
            this.text_bg.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label_bg
            // 
            this.label_bg.AutoSize = true;
            this.label_bg.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_bg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bg.Location = new System.Drawing.Point(24, 315);
            this.label_bg.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_bg.Name = "label_bg";
            this.label_bg.Size = new System.Drawing.Size(120, 25);
            this.label_bg.TabIndex = 0;
            this.label_bg.Text = "Blood Group";
            this.label_bg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_disease
            // 
            this.text_disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_disease.Location = new System.Drawing.Point(179, 257);
            this.text_disease.Name = "text_disease";
            this.text_disease.Size = new System.Drawing.Size(395, 26);
            this.text_disease.TabIndex = 1;
            this.text_disease.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label_disease
            // 
            this.label_disease.AutoSize = true;
            this.label_disease.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_disease.Location = new System.Drawing.Point(24, 257);
            this.label_disease.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_disease.Name = "label_disease";
            this.label_disease.Size = new System.Drawing.Size(120, 25);
            this.label_disease.TabIndex = 0;
            this.label_disease.Text = "Disease";
            this.label_disease.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_contact
            // 
            this.text_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_contact.Location = new System.Drawing.Point(179, 197);
            this.text_contact.Name = "text_contact";
            this.text_contact.Size = new System.Drawing.Size(242, 26);
            this.text_contact.TabIndex = 1;
            // 
            // label_contact
            // 
            this.label_contact.AutoSize = true;
            this.label_contact.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact.Location = new System.Drawing.Point(24, 200);
            this.label_contact.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_contact.Name = "label_contact";
            this.label_contact.Size = new System.Drawing.Size(120, 25);
            this.label_contact.TabIndex = 0;
            this.label_contact.Text = "Contact no";
            this.label_contact.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_address
            // 
            this.text_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_address.Location = new System.Drawing.Point(179, 139);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(395, 26);
            this.text_address.TabIndex = 1;
            // 
            // label_addrress
            // 
            this.label_addrress.AutoSize = true;
            this.label_addrress.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_addrress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addrress.Location = new System.Drawing.Point(24, 142);
            this.label_addrress.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_addrress.Name = "label_addrress";
            this.label_addrress.Size = new System.Drawing.Size(120, 25);
            this.label_addrress.TabIndex = 0;
            this.label_addrress.Text = "Address";
            this.label_addrress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(318, 85);
            this.label_gender.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(120, 25);
            this.label_gender.TabIndex = 0;
            this.label_gender.Text = "Gender";
            this.label_gender.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_age
            // 
            this.text_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_age.Location = new System.Drawing.Point(179, 85);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(109, 26);
            this.text_age.TabIndex = 1;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(24, 85);
            this.label_age.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(120, 25);
            this.label_age.TabIndex = 0;
            this.label_age.Text = "Age";
            this.label_age.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name.Location = new System.Drawing.Point(179, 34);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(395, 26);
            this.text_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.LightSlateGray;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(24, 34);
            this.label_name.MinimumSize = new System.Drawing.Size(120, 25);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(120, 25);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Patient Name";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.dataGridView_patient);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button_Update);
            this.tabPage2.Controls.Add(this.button_Delete);
            this.tabPage2.Controls.Add(this.button_Refresh);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1294, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(565, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(442, 402);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(317, 402);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(186, 402);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hMSDataSetBindingSource;
            // 
            // hMSDataSetBindingSource
            // 
            this.hMSDataSetBindingSource.DataSource = this.hMSDataSet;
            this.hMSDataSetBindingSource.Position = 0;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_patient
            // 
            this.dataGridView_patient.AllowUserToOrderColumns = true;
            this.dataGridView_patient.AutoGenerateColumns = false;
            this.dataGridView_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_patient.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.diseaseDataGridViewTextBoxColumn,
            this.bloodgroupDataGridViewTextBoxColumn,
            this.appointmentnoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView_patient.DataSource = this.patientBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_patient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_patient.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_patient.Name = "dataGridView_patient";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_patient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_patient.Size = new System.Drawing.Size(1302, 681);
            this.dataGridView_patient.TabIndex = 2;
            this.dataGridView_patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_patient_CellContentClick_1);
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.FillWeight = 80F;
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "P_name";
            this.pnameDataGridViewTextBoxColumn.FillWeight = 250F;
            this.pnameDataGridViewTextBoxColumn.HeaderText = "P_name";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.FillWeight = 60F;
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.FillWeight = 97F;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 250F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "Contact_no";
            this.contactnoDataGridViewTextBoxColumn.FillWeight = 110F;
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "Contact_no";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            this.contactnoDataGridViewTextBoxColumn.Width = 127;
            // 
            // diseaseDataGridViewTextBoxColumn
            // 
            this.diseaseDataGridViewTextBoxColumn.DataPropertyName = "Disease";
            this.diseaseDataGridViewTextBoxColumn.FillWeight = 250F;
            this.diseaseDataGridViewTextBoxColumn.HeaderText = "Disease";
            this.diseaseDataGridViewTextBoxColumn.Name = "diseaseDataGridViewTextBoxColumn";
            // 
            // bloodgroupDataGridViewTextBoxColumn
            // 
            this.bloodgroupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bloodgroupDataGridViewTextBoxColumn.DataPropertyName = "Blood_group";
            this.bloodgroupDataGridViewTextBoxColumn.FillWeight = 90F;
            this.bloodgroupDataGridViewTextBoxColumn.HeaderText = "Blood_group";
            this.bloodgroupDataGridViewTextBoxColumn.Name = "bloodgroupDataGridViewTextBoxColumn";
            this.bloodgroupDataGridViewTextBoxColumn.Width = 136;
            // 
            // appointmentnoDataGridViewTextBoxColumn
            // 
            this.appointmentnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.appointmentnoDataGridViewTextBoxColumn.DataPropertyName = "Appointment_no";
            this.appointmentnoDataGridViewTextBoxColumn.FillWeight = 120F;
            this.appointmentnoDataGridViewTextBoxColumn.HeaderText = "Appointment_no";
            this.appointmentnoDataGridViewTextBoxColumn.Name = "appointmentnoDataGridViewTextBoxColumn";
            this.appointmentnoDataGridViewTextBoxColumn.Width = 166;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 200F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // Form3_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1286, 643);
            this.Controls.Add(this.tabControl_patient);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form3_patient";
            this.Text = "PatientUI";
            this.Load += new System.EventHandler(this.Form3_patient_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl_patient.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem openPatientTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_patient;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox text_bg;
        private System.Windows.Forms.Label label_bg;
        private System.Windows.Forms.TextBox text_disease;
        private System.Windows.Forms.Label label_disease;
        private System.Windows.Forms.TextBox text_contact;
        private System.Windows.Forms.Label label_contact;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Label label_addrress;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox text_app;
        private System.Windows.Forms.Label label_app;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.BindingSource hMSDataSetBindingSource;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HMSDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;

    }
}