using System;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_student_name.Text))
            {
                lbl_message.Text = $"Welcome, {txt_student_name.Text}!";
            }
            else
            {
                lbl_message.Text = "Name cannot be empty.";
            }
        }
    }
}
