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
    public partial class Form7_InPatient : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public Form7_InPatient()
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

        private void Form7_InPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSetNew.Inpatient' table. You can move, or remove it, as needed.
            this.inpatientTableAdapter.Fill(this.hMSDataSetNew.Inpatient);
            // TODO: This line of code loads data into the 'hMSDataSetNew.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSDataSetNew.Patient);
            display_data();
            inpatientDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            inpatientDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            inpatientDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(152, 220, 40);
            inpatientDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);


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

        public void display_data() //update concurrently
        {
            sda = new SqlDataAdapter(@"SELECT * FROM Inpatient", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            inpatientDataGridView.DataSource = dt;
            comboBox_search.SelectedIndex = -1;
            textBox_search.Clear();
        }
       

        private void button_save_Click_1(object sender, EventArgs e)
        {
            if (text_gname.Text == "")
                MessageBox.Show("Enter Name!");
            else if (text_gname.Text == "01" || text_gname.Text == "/" || text_gname.Text == "@")
                MessageBox.Show("Invalid Name");
            else if (comboBox_name.Text == "")
                MessageBox.Show("Enter In Patient name!");
            else if (text_relation.Text == "")
                     MessageBox.Show("Enter Gurdian's relation!");
            else if (comboBox_ward.Text == "")
                MessageBox.Show("Enter Ward name!");
            else if (comboBox_bed.Text == "")
                MessageBox.Show("Enter Bed No!");
            else if (comboBox_room.Text == "")
                MessageBox.Show("Enter Room No!");
            else if (dateTimePicker_doa.Text == "")
                MessageBox.Show("Enter Date of Admission!");
            else if (comboBox_name.Text == "")
                MessageBox.Show("Enter Name!");
            else if (comboBox_name.Text == "01" || comboBox_name.Text == "/" || comboBox_name.Text == "@")
                MessageBox.Show("Invalid Name");


            else
            {       
                string query = @"INSERT INTO Inpatient (IN_Patient_name,             P_ID,                       DOA,                         Gurdian_name,              Gurdian_relation,            Ward_no,                        Bed_no,                       Room_no)" +
                                         "VALUES('" + comboBox_name.Text + "','"+textBox_id.Text+"','" + dateTimePicker_doa.Text + "','" + text_gname.Text + "','" + text_relation.Text + "','" + comboBox_ward.Text + "','" + comboBox_bed.Text + "','" + comboBox_room.Text + "') ";
                SqlCommand command = new SqlCommand(query, conString);
                conString.Open();
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    conString.Close();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully");
                        comboBox_name.SelectedIndex = -1;
                        textBox_id.Clear();
                        comboBox_bed.SelectedIndex = -1;
                        text_gname.Clear();
                        text_relation.Clear();
                        comboBox_room.SelectedIndex = -1;
                        comboBox_ward.SelectedIndex = -1;
                        dateTimePicker_doa.Format = DateTimePickerFormat.Custom;
                    }
                    else
                    {
                        MessageBox.Show("Data insert failed");
                    }

                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message); 
                }

            }
            display_data();                                                        
        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Close();
        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_search.Text == "ID")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE P_ID LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Admission Date")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE DOA LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Gurdian name")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE Gurdian_name LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Patient Name")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE In_Patient_name LIKE '%" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Discharge Date")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE DOD LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Ward")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE Ward_no LIKE '" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Bed")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE Bed_no LIKE'" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
            else if (comboBox_search.Text == "Room")
            {
                sda = new SqlDataAdapter(@"SELECT * FROM Inpatient WHERE Room_no LIKE'%" + textBox_search.Text + "%'", conString);
                dt = new DataTable();
                sda.Fill(dt);
                inpatientDataGridView.DataSource = dt;
            }
           
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
                    inpatientDataGridView.Rows.RemoveAt(inpatientDataGridView.CurrentRow.Index);
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

        private void text_ward_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_doa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_name_SelectedIndexChanged_1(object sender, EventArgs e)// fillup to corresponding data
        {
            try
            {
                string query2 = "select P_ID from Patient where Patient_name like '" + comboBox_name.Text + "'";
                if (conString.State == ConnectionState.Closed)
                {
                    conString.Open();
                }
                SqlCommand cmd0 = new SqlCommand(query2, conString);
                SqlDataReader DR2 = cmd0.ExecuteReader();
                while (DR2.Read())
                {
                    textBox_id.Text = DR2["P_ID"].ToString();
                }
                conString.Close();
                DR2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conString.State == ConnectionState.Open)
                {
                    conString.Close();
                }
            }
        }
    }
}

