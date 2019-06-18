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
    public partial class Form10_medicine : Form
    {
        public Form10_medicine()
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

        private void Form10_medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSetNew.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.hMSDataSetNew.Medicine);
            display_data();
            medicineDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
            medicineDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(253, 85, 45);
            medicineDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            medicineDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;

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
            string query = @"INSERT INTO Medicine (Product_name,Description,Company,Price,Quantity,Supply_date,Expiration_date)
                            VALUES('" + text_name.Text + "','" + textBox_des.Text + "','" + text_brand.Text + "', " + text_price.Text + "," + text_quantity.Text + ",  +'" + dateTimePicker_sdate.Text + "','" + dateTimePicker_edate.Text + "') ";
            try
            {
                conString.Open();
                cmd = new SqlCommand(query, conString);
                int rowsAffected = cmd.ExecuteNonQuery();
                conString.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                    text_brand.Clear();
                    text_name.Clear();
                    text_price.Clear();
                    textBox_des.Clear();
                    text_quantity.Clear();
                    dateTimePicker_edate.Format = DateTimePickerFormat.Custom;
                    dateTimePicker_sdate.Format = DateTimePickerFormat.Custom;
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
            sda = new SqlDataAdapter(@"select * from Medicine", conString); //sda=cmd
            dt = new DataTable();
            sda.Fill(dt);
            medicineDataGridView.DataSource = dt;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Close();
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void label_brand_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_price_Click(object sender, EventArgs e)
        {

        }

        private void medicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSetNew);

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter(@"select * from  Medicine  WHERE Produdct_ID LIKE '" + textBox_search.Text + "%' or Product_name like '" + textBox_search.Text + "%' or Description like '" + textBox_search.Text + "%' or Company like '%" + textBox_search.Text + "%' or Price like '" + textBox_search.Text + "%' or Quantity like '" + textBox_search.Text + "%' or Supply_date like '%" + textBox_search.Text + "%' or Expiration_date like '%" + textBox_search.Text + "%' ", conString);
            dt = new DataTable();
            sda.Fill(dt);
            medicineDataGridView.DataSource = dt;
            medicineDataGridView.RowsDefaultCellStyle.BackColor = Color.Cyan;
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    scb = new SqlCommandBuilder(sda);
                    medicineDataGridView.Rows.RemoveAt(medicineDataGridView.CurrentRow.Index);
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
            
        }      
    }
}
