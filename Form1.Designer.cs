namespace StudentManagementApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbl_prompt = new System.Windows.Forms.Label();
            this.txt_student_name = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_prompt
            // 
            this.lbl_prompt.AutoSize = true;
            this.lbl_prompt.Location = new System.Drawing.Point(20, 20);
            this.lbl_prompt.Name = "lbl_prompt";
            this.lbl_prompt.Size = new System.Drawing.Size(95, 15);
            this.lbl_prompt.TabIndex = 0;
            this.lbl_prompt.Text = "Enter student name:";
            // 
            // txt_student_name
            // 
            this.txt_student_name.Location = new System.Drawing.Point(20, 50);
            this.txt_student_name.Name = "txt_student_name";
            this.txt_student_name.Size = new System.Drawing.Size(200, 23);
            this.txt_student_name.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(20, 90);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(80, 30);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(20, 140);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(38, 15);
            this.lbl_message.TabIndex = 3;
            this.lbl_message.Text = "Ready";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_student_name);
            this.Controls.Add(this.lbl_prompt);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_prompt;
        private System.Windows.Forms.TextBox txt_student_name;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_message;
    }
}
