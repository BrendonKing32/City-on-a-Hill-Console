namespace CityConsole
{
    partial class ShowAttendance
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
            this.components = new System.ComponentModel.Container();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityonaHillDataSet = new CityConsole.CityonaHillDataSet();
            this.attendanceTableAdapter = new CityConsole.CityonaHillDataSetTableAdapters.AttendanceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cityonaHillDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityonaHillDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityonaHillDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.cityonaHillDataSet;
            // 
            // cityonaHillDataSet
            // 
            this.cityonaHillDataSet.DataSetName = "CityonaHillDataSet";
            this.cityonaHillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceDateDataGridViewTextBoxColumn,
            this.adultsDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // cityonaHillDataSetBindingSource
            // 
            this.cityonaHillDataSetBindingSource.DataSource = this.cityonaHillDataSet;
            this.cityonaHillDataSetBindingSource.Position = 0;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(380, 381);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(299, 381);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "Service Date";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
            // 
            // adultsDataGridViewTextBoxColumn
            // 
            this.adultsDataGridViewTextBoxColumn.DataPropertyName = "Adults";
            this.adultsDataGridViewTextBoxColumn.HeaderText = "Adults";
            this.adultsDataGridViewTextBoxColumn.Name = "adultsDataGridViewTextBoxColumn";
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "Children";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Children";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // ShowAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 416);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowAttendance";
            this.Text = "Attendance History";
            this.Load += new System.EventHandler(this.ShowAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityonaHillDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityonaHillDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CityonaHillDataSet cityonaHillDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private CityonaHillDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cityonaHillDataSetBindingSource;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}