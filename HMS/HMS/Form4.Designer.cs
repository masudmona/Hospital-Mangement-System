namespace HMS
{
    partial class form4_bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_reset = new System.Windows.Forms.Button();
            this.label_DC = new System.Windows.Forms.Label();
            this.label_LC = new System.Windows.Forms.Label();
            this.label_OC = new System.Windows.Forms.Label();
            this.label_MC = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_bill = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.Info;
            this.button_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(205, 411);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 31);
            this.button_reset.TabIndex = 0;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_DC
            // 
            this.label_DC.AutoSize = true;
            this.label_DC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_DC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DC.Location = new System.Drawing.Point(87, 206);
            this.label_DC.Name = "label_DC";
            this.label_DC.Size = new System.Drawing.Size(121, 21);
            this.label_DC.TabIndex = 1;
            this.label_DC.Text = "Doctor Charge";
            this.label_DC.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_LC
            // 
            this.label_LC.AutoSize = true;
            this.label_LC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_LC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LC.Location = new System.Drawing.Point(87, 247);
            this.label_LC.Name = "label_LC";
            this.label_LC.Size = new System.Drawing.Size(97, 21);
            this.label_LC.TabIndex = 1;
            this.label_LC.Text = "Lab Charge";
            this.label_LC.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_OC
            // 
            this.label_OC.AutoSize = true;
            this.label_OC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_OC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OC.Location = new System.Drawing.Point(87, 288);
            this.label_OC.Name = "label_OC";
            this.label_OC.Size = new System.Drawing.Size(142, 21);
            this.label_OC.TabIndex = 1;
            this.label_OC.Text = "Operation Charge";
            this.label_OC.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_MC
            // 
            this.label_MC.AutoSize = true;
            this.label_MC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_MC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MC.Location = new System.Drawing.Point(87, 329);
            this.label_MC.Name = "label_MC";
            this.label_MC.Size = new System.Drawing.Size(136, 21);
            this.label_MC.TabIndex = 1;
            this.label_MC.Text = "Medicine Charge";
            this.label_MC.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_Total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(87, 370);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(112, 21);
            this.label_Total.TabIndex = 1;
            this.label_Total.Text = "Total Amount";
            this.label_Total.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.Info;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(323, 412);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 31);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.Info;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(439, 412);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 31);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(385, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(385, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(385, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(385, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(385, 247);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 22);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(385, 288);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 22);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(385, 329);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(129, 22);
            this.textBox7.TabIndex = 2;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(385, 370);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(129, 22);
            this.textBox8.TabIndex = 2;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(87, 165);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(84, 21);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "Patient ID";
            this.label_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_bill
            // 
            this.label_bill.AutoSize = true;
            this.label_bill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_bill.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bill.Location = new System.Drawing.Point(87, 83);
            this.label_bill.Name = "label_bill";
            this.label_bill.Size = new System.Drawing.Size(67, 21);
            this.label_bill.TabIndex = 1;
            this.label_bill.Text = "Bill No.";
            this.label_bill.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(87, 124);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(44, 21);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date";
            this.label_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // form4_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 466);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_MC);
            this.Controls.Add(this.label_OC);
            this.Controls.Add(this.label_LC);
            this.Controls.Add(this.label_DC);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_bill);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_reset);
            this.Name = "form4_bill";
            this.Text = "Patient_bill_UI";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_DC;
        private System.Windows.Forms.Label label_LC;
        private System.Windows.Forms.Label label_OC;
        private System.Windows.Forms.Label label_MC;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_bill;
        private System.Windows.Forms.Label label_date;
    }
}