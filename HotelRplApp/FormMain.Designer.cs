namespace HotelRplApp
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.requestAdditionalItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gustsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodAndDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.checkInToolStrip = new System.Windows.Forms.ToolStripButton();
            this.reservationToolStrip = new System.Windows.Forms.ToolStripButton();
            this.checkOutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.employeeToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.exitToolStrip = new System.Windows.Forms.ToolStripButton();
            this.labelDateAndTime = new System.Windows.Forms.ToolStripLabel();
            this.labelJob = new System.Windows.Forms.ToolStripLabel();
            this.timerToolStrip = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fILEToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOut);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.checkInToolStripMenuItem1,
            this.requestAdditionalItemToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // checkInToolStripMenuItem1
            // 
            this.checkInToolStripMenuItem1.Name = "checkInToolStripMenuItem1";
            this.checkInToolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.checkInToolStripMenuItem1.Text = "Check In";
            this.checkInToolStripMenuItem1.Click += new System.EventHandler(this.checkInToolStripMenuItem1_Click);
            // 
            // requestAdditionalItemToolStripMenuItem
            // 
            this.requestAdditionalItemToolStripMenuItem.Name = "requestAdditionalItemToolStripMenuItem";
            this.requestAdditionalItemToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.requestAdditionalItemToolStripMenuItem.Text = "Request Additional Item";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.gustsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.checkInToolStripMenuItem.Text = "Check In";
            // 
            // gustsToolStripMenuItem
            // 
            this.gustsToolStripMenuItem.Name = "gustsToolStripMenuItem";
            this.gustsToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.gustsToolStripMenuItem.Text = "Guests";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.foodAndDrinkToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.roomTypeToolStripMenuItem,
            this.roomToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // foodAndDrinkToolStripMenuItem
            // 
            this.foodAndDrinkToolStripMenuItem.Name = "foodAndDrinkToolStripMenuItem";
            this.foodAndDrinkToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.foodAndDrinkToolStripMenuItem.Text = "Food and Drink";
            this.foodAndDrinkToolStripMenuItem.Click += new System.EventHandler(this.foodAndDrinkToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.itemToolStripMenuItem.Text = "Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // roomTypeToolStripMenuItem
            // 
            this.roomTypeToolStripMenuItem.Name = "roomTypeToolStripMenuItem";
            this.roomTypeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.roomTypeToolStripMenuItem.Text = "Room Type";
            this.roomTypeToolStripMenuItem.Click += new System.EventHandler(this.roomTypeToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStrip,
            this.reservationToolStrip,
            this.checkOutToolStrip,
            this.employeeToolStrip,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.logoutToolStrip,
            this.exitToolStrip,
            this.labelDateAndTime,
            this.labelJob});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // checkInToolStrip
            // 
            this.checkInToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkInToolStrip.Name = "checkInToolStrip";
            this.checkInToolStrip.Size = new System.Drawing.Size(68, 24);
            this.checkInToolStrip.Text = "Check In";
            // 
            // reservationToolStrip
            // 
            this.reservationToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reservationToolStrip.Name = "reservationToolStrip";
            this.reservationToolStrip.Size = new System.Drawing.Size(90, 24);
            this.reservationToolStrip.Text = "Reservation";
            this.reservationToolStrip.Click += new System.EventHandler(this.reservationToolStrip_Click);
            // 
            // checkOutToolStrip
            // 
            this.checkOutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.checkOutToolStrip.Name = "checkOutToolStrip";
            this.checkOutToolStrip.Size = new System.Drawing.Size(80, 24);
            this.checkOutToolStrip.Text = "Check Out";
            // 
            // employeeToolStrip
            // 
            this.employeeToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.employeeToolStrip.Name = "employeeToolStrip";
            this.employeeToolStrip.Size = new System.Drawing.Size(79, 24);
            this.employeeToolStrip.Text = "Employee";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // logoutToolStrip
            // 
            this.logoutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logoutToolStrip.Name = "logoutToolStrip";
            this.logoutToolStrip.Size = new System.Drawing.Size(60, 24);
            this.logoutToolStrip.Text = "Logout";
            this.logoutToolStrip.Click += new System.EventHandler(this.logOut);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(37, 24);
            this.exitToolStrip.Text = "Exit";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStrip_Click);
            // 
            // labelDateAndTime
            // 
            this.labelDateAndTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelDateAndTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labelDateAndTime.Margin = new System.Windows.Forms.Padding(60, 1, 0, 2);
            this.labelDateAndTime.Name = "labelDateAndTime";
            this.labelDateAndTime.Size = new System.Drawing.Size(107, 24);
            this.labelDateAndTime.Text = "Date and Time";
            // 
            // labelJob
            // 
            this.labelJob.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(53, 24);
            this.labelJob.Text = "Admin";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMainAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requestAdditionalItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gustsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exitToolStrip;
        private System.Windows.Forms.ToolStripButton checkInToolStrip;
        private System.Windows.Forms.ToolStripButton reservationToolStrip;
        private System.Windows.Forms.ToolStripButton checkOutToolStrip;
        private System.Windows.Forms.ToolStripButton logoutToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labelJob;
        private System.Windows.Forms.ToolStripLabel labelDateAndTime;
        private System.Windows.Forms.Timer timerToolStrip;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodAndDrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton employeeToolStrip;
    }
}