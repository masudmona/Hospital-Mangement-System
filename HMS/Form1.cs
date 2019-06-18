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
    public partial class Form1_LoginUI : Form
    {
        private SqlConnection conString = new SqlConnection(@"Data Source=S1S1S1-PC\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;
        public Form1_LoginUI()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBox_uname.Text == "")
                    MessageBox.Show("Enter a Username!");
                else if (textBoxPW.Text == "")
                    MessageBox.Show("Enter Password!");
                else
                {
                    conString.Open();
                    cmd = new SqlCommand("select * from Admin where Username = '" + textBox_uname.Text + "' AND Password = '" + textBoxPW.Text + "' ", conString);
                    sda = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    sda.Fill(ds);
                    conString.Close();
                    int i = ds.Tables[0].Rows.Count;                    
                    if (i==1)
                    {
                        MessageBox.Show("Login Successfully");
                        textBox_uname.Clear();
                        textBoxPW.Clear();
                        new Form2_Dashboard().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username OR Password !!!");
                        textBox_uname.Clear();
                        textBoxPW.Clear();
                    }                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
