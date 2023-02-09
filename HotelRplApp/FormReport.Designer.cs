namespace HotelRplApp
{
    partial class FormReport
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheckInToday = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.inputToday = new System.Windows.Forms.TextBox();
            this.inputDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnGoPreview = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoPreview);
            this.groupBox2.Controls.Add(this.inputDateTo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.inputDateFrom);
            this.groupBox2.Controls.Add(this.inputToday);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.btnCheckInToday);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 201);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Preview Option";
            // 
            // btnCheckInToday
            // 
            this.btnCheckInToday.AutoSize = true;
            this.btnCheckInToday.Checked = true;
            this.btnCheckInToday.Location = new System.Drawing.Point(24, 31);
            this.btnCheckInToday.Name = "btnCheckInToday";
            this.btnCheckInToday.Size = new System.Drawing.Size(122, 20);
            this.btnCheckInToday.TabIndex = 0;
            this.btnCheckInToday.TabStop = true;
            this.btnCheckInToday.Text = "Check In Today";
            this.btnCheckInToday.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 68);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(113, 20);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Check In From";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // inputToday
            // 
            this.inputToday.Location = new System.Drawing.Point(159, 30);
            this.inputToday.Name = "inputToday";
            this.inputToday.Size = new System.Drawing.Size(284, 22);
            this.inputToday.TabIndex = 2;
            // 
            // inputDateFrom
            // 
            this.inputDateFrom.CustomFormat = "dd-MMM-yyyy";
            this.inputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDateFrom.Location = new System.Drawing.Point(159, 68);
            this.inputDateFrom.Name = "inputDateFrom";
            this.inputDateFrom.Size = new System.Drawing.Size(124, 22);
            this.inputDateFrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // inputDateTo
            // 
            this.inputDateTo.CustomFormat = "dd-MMM-yyyy";
            this.inputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDateTo.Location = new System.Drawing.Point(319, 68);
            this.inputDateTo.Name = "inputDateTo";
            this.inputDateTo.Size = new System.Drawing.Size(124, 22);
            this.inputDateTo.TabIndex = 4;
            // 
            // btnGoPreview
            // 
            this.btnGoPreview.Location = new System.Drawing.Point(159, 113);
            this.btnGoPreview.Name = "btnGoPreview";
            this.btnGoPreview.Size = new System.Drawing.Size(104, 44);
            this.btnGoPreview.TabIndex = 5;
            this.btnGoPreview.Text = "Preview";
            this.btnGoPreview.UseVisualStyleBackColor = true;
            this.btnGoPreview.Click += new System.EventHandler(this.btnGoPreview_Click);
            // 
            // FormReport
            // 
            this.ClientSize = new System.Drawing.Size(536, 226);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputToday;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton btnCheckInToday;
        private System.Windows.Forms.DateTimePicker inputDateFrom;
        private System.Windows.Forms.DateTimePicker inputDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoPreview;
    }
}