using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HMS
{
    public partial class Form6_Employee : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Form6_Employee()
        {
            InitializeComponent();
        }

        private void employeeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form22_new_acc().Show();
            this.Hide();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Sttings_Click(object sender, EventArgs e)
        {

        }

        private void labTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_Schedule_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_apmnt_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Employee_Load(object sender, EventArgs e)
        {
            display_data();
            // TODO: This line of code loads data into the 'hMSDataSetNew.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hMSDataSetNew.Employee);
            this.employeeDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            this.employeeDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(151, 210, 249);
            this.employeeDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            this.employeeDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openPatientTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Form26_info().Show();
            //this.Hide();
        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form3_patient().Show();
            this.Hide();
        }

        private void labTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form8_LabTest().Show();
            this.Hide();
        }

        private void doctorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Form5_Doctor().Show();
            this.Hide();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new form4_bill().Show();
            this.Hide();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form13_Accounts_Inf().Show();
            this.Hide();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form14_department().Show();
            this.Hide();
        }

        private void storeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form10_medicine().Show();
            this.Hide();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Form11_schedule().Show();
            //this.Hide();
        }

        private void patientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3_patient().Show();
            this.Hide();
        }

        private void inPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7_InPatient().Show();
            this.Hide();
        }

        private void labReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form21_rep().Show();
            this.Hide();
        }

        private void patientBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new form4_bill().Show();
            this.Hide();
        }

        private void doctorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new Form5_Doctor().Show();
            this.Hide();
        }

        private void doctorsScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form12_Doc_schedule().Show();
            this.Hide();
        }

        private void medicalStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form10_medicine().Show();
            this.Hide();
        }

        private void labTestToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Form8_LabTest().Show();
            this.Hide();
        }

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form14_department().Show();
            this.Hide();
        }

        private void accountsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form13_Accounts_Inf().Show();
            this.Hide();
        }

        private void scheduleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form11_Staff_scheduleUI().Show();
            this.Hide();
        }

        private void doctorsScheduleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form12_Doc_schedule().Show();
            this.Hide();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form16_Room().Show();
            this.Hide();
        }

        private void wardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form15_Ward().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form1_LoginUI().Show();
            this.Close();
        }

        private void appointmentInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form9_Appointment().Show();
            this.Hide();
        }

        private void labReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form21_rep().Show();
            this.Hide();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form17_prescription().Show();
            this.Hide();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form18_record().Show();
            this.Hide();
        }

        private void prescriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form17_prescription().Show();
            this.Hide();
        }

        private void appointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form9_Appointment().Show();
            this.Hide();
        }

        private void apointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appointmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form9_Appointment().Show();
            this.Hide();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void labReportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Form21_rep().Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6_Employee().Show();
            this.Hide();
        }

        private void recordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form18_record().Show();
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form19_settings().Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bedAllotmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form24_allotment().Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void display_data() //update concurrently
        {
            sda = new SqlDataAdapter(@"SELECT * FROM Employee", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            employeeDataGridView.DataSource = dt;
            comboBox_search.SelectedIndex = -1;
            textBox_search.Clear();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (text_name.Text == "")
                MessageBox.Show("Enter Name!");
            else if (text_name.Text == "01" || text_name.Text == "/" || text_name.Text == "@")
                MessageBox.Show("Invalid Name");
            else if (text_qualif.Text == "")
                MessageBox.Show("Enter qualification!");
            /*     else if (text_mail.Text == "")
                     MessageBox.Show("Enter mail id!");*/
            else if (text_address.Text == "")
                MessageBox.Show("Enter Address!");
            else if (text_contact.Text == "")
                MessageBox.Show("Enter Contact No!");
               else if (dateTimePicker_dob.Text == "")
                   MessageBox.Show("Enter Date of Birth!");
            else if (dateTimePicker_doj.Text == "")
                MessageBox.Show("Enter Joining Date!");

            else
            {
                string query = @"INSERT INTO Employee (Employee_name,       Employee_type,                  Department,                 Designation,                    Gender,                     Qualification,              DOB,                                Address,                    Contact_no,                    E_mail,                  Joining_date)" +
                                         "VALUES('" + text_name.Text + "','" + comboBox_type.Text + "','" + comboBox_dept.Text + "','" + comboBox_desig.Text + "','" + comboBox_gender.Text + "','" + text_qualif.Text + "','" + dateTimePicker_dob.Text + "','" + text_address.Text + "','" + text_contact.Text + "','" + text_mail.Text + "', '" + dateTimePicker_doj.Text + "' ) ";
                SqlCommand command = new SqlCommand(query, conString);
                conString.Open();
                int rowsAffected = command.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    text_name.Clear();
                    text_address.Clear();
                    text_contact.Clear();
                    text_mail.Clear();
                    text_uid.Clear();
                    text_qualif.Clear();
                    comboBox_dept.SelectedIndex = -1;
                    comboBox_desig.SelectedIndex = -1;
                    comboBox_gender.SelectedIndex = -1;
                    comboBox_type.SelectedIndex = -1;
                    dateTimePicker_dob.Format = DateTimePickerFormat.Custom;
                    dateTimePicker_doj.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    MessageBox.Show("Data insert failed");
                }
            }
            display_data();

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Close();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSetNew);

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_search.Text == "ID")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE E_ID LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Designation")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Designation LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Address")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Address LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Name")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Employee_name LIKE '%" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Contact")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Contact_no LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Employee Type")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Employee_type LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Department")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Department LIKE'" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Mail")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE E_mail LIKE'%" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Joining Date")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Joining_date LIKE '%" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Gender")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Employee WHERE Gender LIKE '%" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                employeeDataGridView.DataSource = dt;
            }   
            
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            display_data();
            textBox_search.Clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    scb = new SqlCommandBuilder(sda);
                    employeeDataGridView.Rows.RemoveAt(employeeDataGridView.CurrentRow.Index);
                    sda.Update(dt);
                    MessageBox.Show("Delete successfully!");
                }

            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(sda);
                int a = sda.Update(dt);
                if (a < 1)
                    MessageBox.Show("No Update is found!");
                else
                    MessageBox.Show("Update successfully!");
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            new Form6_Employee().Show();
            this.Close();
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }    
}
