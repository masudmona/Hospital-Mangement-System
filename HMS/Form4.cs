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
    public partial class form4_bill : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        SqlCommand cmd;
        SqlCommand cmd1;
        DataTable dt = null;
        public form4_bill()
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

        private void form4_bill_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'hMSDataSetNew.Lab_Test' table. You can move, or remove it, as needed.
            this.lab_TestTableAdapter.Fill(this.hMSDataSetNew.Lab_Test);
            // TODO: This line of code loads data into the 'hMSDataSetNew.Patient_Bill' table. You can move, or remove it, as needed.
            this.patient_BillTableAdapter.Fill(this.hMSDataSetNew.Patient_Bill);

            display_data();            
            patient_BillDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            patient_BillDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            patient_BillDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(221, 140, 181);
            patient_BillDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            reader();
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click1(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Patient_Bill(Date,P_ID,Doctor_charge,Lab_charge,Operation_charge,Room_charge,Nursing_charge,Medicine_charge,Account_status)
                            VALUES('" + dateTimePicker_date.Text + "'," + comboBox_id.Text + "," + textBox_dc.Text + "," + textBox_lc.Text + ", " + textBox_oc.Text + ", " + textBox_rc.Text + ", " + textBox_nc.Text + ", " + textBox_mc.Text + ", '"+comboBox_status.Text+"') ";
            try
            {
                conString.Open();
                cmd = new SqlCommand(query, conString);
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    textBox_dc.Clear();
                    textBox_lc.Clear();
                    textBox_mc.Clear();
                    textBox_oc.Clear();
                    textBox_rc.Clear();
                    comboBox_id.SelectedIndex = -1;
                    comboBox_status.SelectedIndex = -1;
                    textBox_nc.Clear();
                    dateTimePicker_date.Format = DateTimePickerFormat.Custom;
                }
                conString.Open();// fro addition
                cmd1 = new SqlCommand(@" UPDATE Patient_Bill 
                                     SET Total_amount = Doctor_charge + Lab_charge + Operation_charge + Room_charge + Nursing_charge + Medicine_charge ", conString);
                cmd1.ExecuteNonQuery();
                conString.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conString.Close();
            display_data();
            reader();
        }

        public void display_data() //update concurrently
        { 
            sda = new SqlDataAdapter(@"select * from Patient_Bill", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            patient_BillDataGridView.DataSource = dt;

        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Close();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            display_data();
            textBox_search.Clear();
            comboBox_id.SelectedIndex = -1;
            textBox_lc.Clear();
        }

        private void patientBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Failed !!!");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    scb = new SqlCommandBuilder(sda);
                    patient_BillDataGridView.Rows.RemoveAt(patient_BillDataGridView.CurrentRow.Index);
                    sda.Update(dt);
                    MessageBox.Show("Delete successfully!");
                }
            }
            catch
            {
                MessageBox.Show("Failed");
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"select * from Patient_Bill WHERE P_ID LIKE '" + textBox_search.Text + "%'  or  Bill_no LIKE '" + textBox_search.Text + "%' or  Date LIKE '" + textBox_search.Text + "%' or Total_amount LIKE '" + textBox_search.Text + "%' ", conString);
            dt = new DataTable();
            sda.Fill(dt);
            patient_BillDataGridView.DataSource = dt;
            patient_BillDataGridView.RowsDefaultCellStyle.BackColor = Color.Red;
        }

        public void reader()//for auto fill-up textbox Bill_no
        {
            
            try
            {                
                string query1 = "select Bill_no from Patient_Bill";
                if (conString.State == ConnectionState.Closed)
                { 
                    conString.Open();
                }
                SqlCommand cmd = new SqlCommand(query1, conString);
                SqlDataReader DR1 = cmd.ExecuteReader();
                 while (DR1.Read())
                   {
                       textBox_bill.Text = DR1["Bill_no"].ToString();
                   }               
                int value = int.Parse(textBox_bill.Text);//
                value = value + 10;                     // to adjust with auto increment with db
                textBox_bill.Text = value.ToString();   //
                conString.Close();
                DR1.Close();
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

        private void textBox_bill_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query2 = "select Lab_charge from Lab_Test where P_ID like '"+comboBox_id.Text+"'";
                if (conString.State == ConnectionState.Closed)
                {
                    conString.Open();
                }
                SqlCommand cmd0 = new SqlCommand(query2, conString);
                SqlDataReader DR2 = cmd0.ExecuteReader();
                while (DR2.Read())
                {
                    textBox_lc.Text = DR2["Lab_charge"].ToString();
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
