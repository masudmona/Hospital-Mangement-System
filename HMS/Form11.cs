﻿using System;
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
    public partial class Form11_Staff_scheduleUI : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd;
        DataTable dt = null;
        public Form11_Staff_scheduleUI()
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

        private void Staff_scheduleUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSetNew.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hMSDataSetNew.Department);
            // TODO: This line of code loads data into the 'hMSDataSetNew.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hMSDataSetNew.Employee);
            // TODO: This line of code loads data into the 'hMSDataSetNew.Staff_schedule' table. You can move, or remove it, as needed.
            this.staff_scheduleTableAdapter.Fill(this.hMSDataSetNew.Staff_schedule);

            display_data();
            staff_scheduleDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            staff_scheduleDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            staff_scheduleDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(221, 240, 111);
            staff_scheduleDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
          //  reader();

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
            string query = @"INSERT INTO Staff_schedule (E_ID, Department, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Sturday)
                            VALUES('" + comboBox_EID.Text + "','" + comboBox_dept.Text + "','" + textBox_sun.Text + "','" + textBox_mon.Text + "','" + textBox_tue.Text + "', '" + textBox_wed.Text + "', '" + textBox_thu.Text + "', '" + textBox_fri.Text + "', '" + textBox_sat.Text + "') ";
            try
            {
                conString.Open();
                cmd = new SqlCommand(query, conString);
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    textBox_fri.Clear();
                    textBox_mon.Clear();
                    textBox_sat.Clear();
                    textBox_sun.Clear();
                    textBox_thu.Clear();
                    textBox_tue.Clear();
                    textBox_wed.Clear();
                    comboBox_dept.SelectedIndex = -1;
                    comboBox_EID.SelectedIndex = -1;
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
            sda = new SqlDataAdapter(@"select * from Staff_schedule", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            staff_scheduleDataGridView.DataSource = dt;

        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Close();
        }


        private void doctor_scheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"select * from  Staff_schedule  WHERE   E_ID like '" + textBox_search.Text + "%' or Sunday like '%" + textBox_search.Text + "%' or Monday like '" + textBox_search.Text + "%' or Tuesday like '%" + textBox_search.Text + "%' or Wednesday like '%" + textBox_search.Text + "%' or Thursday like '%" + textBox_search.Text + "%' or Friday like '%" + textBox_search.Text + "%' or Sturday like '%" + textBox_search.Text + "%'", conString);
            dt = new DataTable();
            sda.Fill(dt);
            staff_scheduleDataGridView.DataSource = dt;
            staff_scheduleDataGridView.RowsDefaultCellStyle.BackColor = Color.Blue;
        }

        private void update_btn_Click(object sender, EventArgs e)
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            display_data();
            textBox_search.Clear();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    scb = new SqlCommandBuilder(sda);
                    staff_scheduleDataGridView.Rows.RemoveAt(staff_scheduleDataGridView.CurrentRow.Index);
                    sda.Update(dt);
                    MessageBox.Show("Delete successfully!");
                }
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void comboBox_EID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True"))
                {
                    using (SqlCommand cmd1 = new SqlCommand("select Department from Employee where E_ID like '" + comboBox_EID.Text + "' ", conString))
                    {
                        conString.Open();
                        using (SqlDataReader DR1 = cmd1.ExecuteReader())
                        {
                            while (DR1.Read())
                            {
                                comboBox_dept.Text = DR1["Department"].ToString();
                            }
                        }
                        conString.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }
    
        private void comboBox_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
    }
}
