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
    public partial class Form8_LabTest : Form
    {
        public Form8_LabTest()
        {
            InitializeComponent();
        }
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd;
        DataTable dt;
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

        private void Form8_LabTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSetNew.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSDataSetNew.Patient);
            display_data();
            lab_TestDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            lab_TestDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            lab_TestDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(229, 208, 177);
            lab_TestDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
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

            
            

            string query = @"INSERT INTO Lab_Test(P_ID,Test_date,Test_name,Lab_charge,Report_delivery_date)
                            VALUES(" + comboBox_patient.Text + ",'" + dateTimePicker_date.Text + "','" + comboBox_name.Text + "'," + text_charge.Text + ", +'" + dateTimePicker_rdd.Text + "' ) ";
            try
            {
                conString.Open();
                cmd = new SqlCommand(query, conString);
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    text_charge.Clear();
                    comboBox_patient.SelectedIndex = -1;
                    comboBox_name.SelectedIndex = -1;
                    dateTimePicker_rdd.ResetText();
                    dateTimePicker_date.ResetText();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conString.Close();
            display_data();
        }

        public void display_data() //update concurrently
        {
            sda = new SqlDataAdapter(@"select * from Lab_Test", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            lab_TestDataGridView.DataSource = dt;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(sda);
                int a = sda.Update(dt);
                if (a < 1)
                    MessageBox.Show("No Update is found!");
                else
                    MessageBox.Show("Update successfully");
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"select * from  Lab_Test  WHERE P_ID LIKE '" + textBox_search.Text + "%' or Test_ID like '" + textBox_search.Text + "%' or Test_name like '%" + textBox_search.Text + "%' or Lab_charge like '" + textBox_search.Text + "%' or Report_delivery_date like '%" + textBox_search.Text + "%'", conString);
            dt = new DataTable();
            sda.Fill(dt);
            lab_TestDataGridView.DataSource = dt;
            lab_TestDataGridView.RowsDefaultCellStyle.BackColor = Color.Orange;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    scb = new SqlCommandBuilder(sda);
                    lab_TestDataGridView.Rows.RemoveAt(lab_TestDataGridView.CurrentRow.Index);
                    sda.Update(dt);
                    MessageBox.Show("Delete successfully!");
                }
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            display_data();
            textBox_search.Clear();
            text_charge.Clear();
        }

        private void comboBox_patient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lab_TestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_name.Text == "Blood Sugar Test")
                text_charge.Text = "150";
            else if (comboBox_name.Text == "C-Reactive Protein Test (CRP)")
                text_charge.Text = "950";
            else if (comboBox_name.Text == "CBC – Complete Blood Count")
                text_charge.Text = "200";
            else if (comboBox_name.Text == "CT Scans")
                text_charge.Text = "6000";
            else if (comboBox_name.Text == "Echocardiogram")
                text_charge.Text = "2200";
            else if (comboBox_name.Text == "Endoscopy")
                text_charge.Text = "2200";
            else if (comboBox_name.Text == "MRI Scans")
                text_charge.Text = "7500";
            else if (comboBox_name.Text == "Ultrasonography")
                text_charge.Text = "1200";
            else if (comboBox_name.Text == "Urine Tests")
                text_charge.Text = "150";
            else if (comboBox_name.Text == "X-Rays")
                text_charge.Text = "350";
            else if(comboBox_name.Text=="Electrocardiogram (ECG)")
                text_charge.Text = "450";

        }

        
    }
}
