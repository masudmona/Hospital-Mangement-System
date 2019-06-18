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
        private SqlConnection connectionString;
        public Form3_patient()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2_Dashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString  = @"Server=s1s1s1-pc\sqlexpress;Database=HMS;Integrated Security=true";

            if (text_name.Text == "")
                MessageBox.Show("Enter Name!");
            else if (text_age.Text == "")
                MessageBox.Show("Enter Age!");
            else if (text_disease.Text == "")
                MessageBox.Show("Enter Disease!");
            else if (text_app.Text == "")
                MessageBox.Show("Enter Appointment_no!");
            else if (dateTimePicker_date.Text == "")
                MessageBox.Show("Enter Date!");
            else
            {

                SqlConnection connection = new SqlConnection(connectionString);
                string query = "INSERT INTO Patient(P_name,Age,Gender,Address,Contact_no,Disease,Blood_group,Appointment_no,Date)"+
                "VALUES('" + text_name.Text + "'," + text_age.Text + " ,'" + comboBox_gender.Text + "','" + text_address.Text + "','" + text_contact.Text + "','" + text_disease.Text + "','" + text_bg.Text + "','" + text_app.Text + "', +'" + dateTimePicker_date.Text + "' ) ";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();


                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data inserted successfully");
                }
                else
                {
                    MessageBox.Show("Data insert failed");
                }
            }
            text_name.Clear();
            comboBox_gender.SelectedIndex = -1;
            text_address.Clear();
            text_contact.Clear();
            text_disease.Clear();
            text_bg.Clear();
            text_app.Clear();
            dateTimePicker_date.Format = DateTimePickerFormat.Custom;
            text_age.Clear();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            /*connectionString.Open();
            string query = "SELECT * FROM Patienet";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView_patient.DataSource = dt;
            connectionString.Close();*/
        }

        private void Form3_patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSDataSet.Patient);

        }

        private void dataGridView_patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*dataGridView_patient.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dataGridView_patient.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 255, 255);*/
        }

        private void dataGridView_patient_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
    }
