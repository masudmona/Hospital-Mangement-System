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
    public partial class Form3_patient : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Form3_patient()
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

        private void Form3_patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSetNew.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSDataSetNew.Patient);
            display_data();
            patientDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            patientDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 255, 255);
            patientDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            patientDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
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
            new Form11_Staff_scheduleUI().Show();
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
            new Form11_Staff_scheduleUI().Show();
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
            new Form1_LoginUI ().Show();
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

        private void button_save_Click(object sender, EventArgs e)
        {    
        }
        public void display_data() //update concurrently
        {
            sda = new SqlDataAdapter(@"SELECT * FROM Patient", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            patientDataGridView.DataSource = dt;
            textBox_search.Clear();
            comboBox_search.SelectedIndex = -1;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {

        }

       private void button_save_Click_1(object sender, EventArgs e)
        {
            if (text_name.Text == "")
                MessageBox.Show("Enter Name!");
            else if (text_name.Text == "salauddin" || text_name.Text == "SALAUDDIN" || text_name.Text == "Salauddin")
                MessageBox.Show("Invalid Name");
            else if (text_age.Text == "")
                MessageBox.Show("Enter Age!");
            else if (text_disease.Text == "")
                MessageBox.Show("Enter Disease!");
            else if (dateTimePicker_date.Text == "")
                MessageBox.Show("Enter Date!");
            else
            {
                string query = @"INSERT INTO Patient(Patient_name,Age,Gender,Address,Contact_no,Disease,Blood_group,Date)" +
                "VALUES('" + text_name.Text + "'," + text_age.Text + " ,'" + comboBox_gender.Text + "','" + text_address.Text + "','" + text_contact.Text + "','" + text_disease.Text + "','" + comboBox_bg.Text + "', +'" + dateTimePicker_date.Text + "' ) ";
                SqlCommand command = new SqlCommand(query, conString);
                conString.Open();
                int rowsAffected = command.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    text_name.Clear();
                    comboBox_gender.SelectedIndex = -1;
                    text_address.Clear();
                    text_contact.Clear();
                    text_disease.Clear();
                    comboBox_bg.SelectedIndex = -1;
                    dateTimePicker_date.Format = DateTimePickerFormat.Custom;
                    text_age.Clear();
                }
                else
                {
                    MessageBox.Show("Data insert failed");
                }
            }
            display_data();     
        }

       private void button_Refresh_Click(object sender, EventArgs e)
       {
            display_data(); 
       }

       private void button_Delete_Click(object sender, EventArgs e)
       {
           try
           {
               if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                   scb = new SqlCommandBuilder(sda);
                   patientDataGridView.Rows.RemoveAt(patientDataGridView.CurrentRow.Index);
                   sda.Update(dt);
                   MessageBox.Show("Delete successfully");
               }

           }
           catch(Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }
       private void button_Update_Click(object sender, EventArgs e)
       {
            try
            {
              scb = new SqlCommandBuilder(sda);
              int a =  sda.Update(dt);
              if (a < 1)
                   MessageBox.Show("No Update is found!"); 
              else
                MessageBox.Show("Update successfully");
            }
            catch
            {
                MessageBox.Show("Failed !!!");
            }
       }

       private void button_Back_Click(object sender, EventArgs e)
       {
           new Form3_patient().Show();
           this.Close();
       }

       private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
       {
           this.Validate();
           this.patientBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(this.hMSDataSetNew);
       }

       private void button_cancel_Click_1(object sender, EventArgs e)
       {
           new Form2_Dashboard().Show();
           this.Close();
       }

       private void textBox_search_TextChanged(object sender, EventArgs e)
       {
           if (comboBox_search.Text == "ID")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE P_ID LIKE '" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Age")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Age LIKE '" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Address")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Address LIKE '" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Name")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Patient_name LIKE '%" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Gender")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Gender LIKE '" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Contact")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Contact_no LIKE '" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Blood Group")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Blood_group LIKE '%" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Disease")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Disease LIKE '" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
           else if (comboBox_search.Text == "Date")
           {
               sda = new SqlDataAdapter(@"SELECT * FROM Patient WHERE Date LIKE '%" + textBox_search.Text + "%'", conString);
               dt = new DataTable();
               sda.Fill(dt);
               patientDataGridView.DataSource = dt;
           }
       }

       private void patientBindingSource_CurrentChanged(object sender, EventArgs e)
       {

       }

    }
}
