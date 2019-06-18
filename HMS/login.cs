using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Form_LoginUI : Form
    {
        public Form_LoginUI()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_uname.Text == "")
                MessageBox.Show("Enter a Username!");
            else if (textBoxPW.Text == "")
                MessageBox.Show("Enter Password!");
            else
            {
                if (textBox_uname.Text == "admin")
                {
                    if (textBoxPW.Text == "admin")
                        MessageBox.Show("Login Sucessful");
                    else
                        MessageBox.Show("Invalid Password");
                }
                else
                    MessageBox.Show("Invalid Username");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
