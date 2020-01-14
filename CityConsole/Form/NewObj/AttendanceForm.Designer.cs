namespace CityConsole
{
    partial class AttendanceForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adults = new System.Windows.Forms.TextBox();
            this.textBox_Children = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Notes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adults";
            // 
            // textBox_Adults
            // 
            this.textBox_Adults.Location = new System.Drawing.Point(71, 36);
            this.textBox_Adults.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Adults.Name = "textBox_Adults";
            this.textBox_Adults.Size = new System.Drawing.Size(141, 20);
            this.textBox_Adults.TabIndex = 1;
            // 
            // textBox_Children
            // 
            this.textBox_Children.Location = new System.Drawing.Point(71, 58);
            this.textBox_Children.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Children.Name = "textBox_Children";
            this.textBox_Children.Size = new System.Drawing.Size(141, 20);
            this.textBox_Children.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Children";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(157, 106);
            this.button_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(56, 19);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Notes";
            // 
            // comboBox_Notes
            // 
            this.comboBox_Notes.FormattingEnabled = true;
            this.comboBox_Notes.Items.AddRange(new object[] {
            "Sunday Service",
            "Potluck",
            "5th Sunday",
            "Special Speaker",
            "Special Event"});
            this.comboBox_Notes.Location = new System.Drawing.Point(71, 81);
            this.comboBox_Notes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Notes.Name = "comboBox_Notes";
            this.comboBox_Notes.Size = new System.Drawing.Size(141, 21);
            this.comboBox_Notes.TabIndex = 3;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 134);
            this.Controls.Add(this.comboBox_Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Children);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Adults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AttendanceForm";
            this.Text = "Attendance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Adults;
        private System.Windows.Forms.TextBox textBox_Children;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Notes;
    }
}