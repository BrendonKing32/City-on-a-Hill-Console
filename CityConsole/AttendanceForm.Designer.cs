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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adults = new System.Windows.Forms.TextBox();
            this.textBox_Children = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Notes = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adults";
            // 
            // textBox_Adults
            // 
            this.textBox_Adults.Location = new System.Drawing.Point(95, 44);
            this.textBox_Adults.Name = "textBox_Adults";
            this.textBox_Adults.Size = new System.Drawing.Size(186, 22);
            this.textBox_Adults.TabIndex = 1;
            // 
            // textBox_Children
            // 
            this.textBox_Children.Location = new System.Drawing.Point(95, 72);
            this.textBox_Children.Name = "textBox_Children";
            this.textBox_Children.Size = new System.Drawing.Size(186, 22);
            this.textBox_Children.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Children";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(212, 171);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 5;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
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
            this.comboBox_Notes.Location = new System.Drawing.Point(95, 100);
            this.comboBox_Notes.Name = "comboBox_Notes";
            this.comboBox_Notes.Size = new System.Drawing.Size(186, 24);
            this.comboBox_Notes.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 206);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox_Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Children);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Adults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}