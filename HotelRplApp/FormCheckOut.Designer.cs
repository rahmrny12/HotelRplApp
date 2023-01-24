namespace HotelRplApp
{
    partial class FormCheckOut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputRoom = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_HOTEL_RPLDataSet = new HotelRplApp.DB_HOTEL_RPLDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.inputCompensation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputItemStatus = new System.Windows.Forms.ComboBox();
            this.itemStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.inputItem = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridItem = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.inputSubTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTotalFoodsAndDrinks = new System.Windows.Forms.Label();
            this.dataGridFoodsAndDrinks = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.roomTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.RoomTableAdapter();
            this.reservationRoomTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.ReservationRoomTableAdapter();
            this.itemTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.ItemTableAdapter();
            this.itemStatusTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.ItemStatusTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodsAndDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room\'s Occupied";
            // 
            // inputRoom
            // 
            this.inputRoom.DataSource = this.roomBindingSource;
            this.inputRoom.DisplayMember = "RoomNumber";
            this.inputRoom.FormattingEnabled = true;
            this.inputRoom.Location = new System.Drawing.Point(132, 36);
            this.inputRoom.Name = "inputRoom";
            this.inputRoom.Size = new System.Drawing.Size(247, 24);
            this.inputRoom.TabIndex = 1;
            this.inputRoom.ValueMember = "ID";
            this.inputRoom.SelectedIndexChanged += new System.EventHandler(this.inputRoomNumber_SelectedIndexChanged);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.dB_HOTEL_RPLDataSet;
            // 
            // dB_HOTEL_RPLDataSet
            // 
            this.dB_HOTEL_RPLDataSet.DataSetName = "DB_HOTEL_RPLDataSet";
            this.dB_HOTEL_RPLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.labelTotalItem);
            this.groupBox4.Controls.Add(this.inputCompensation);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.inputItemStatus);
            this.groupBox4.Controls.Add(this.inputQuantity);
            this.groupBox4.Controls.Add(this.btnAddItem);
            this.groupBox4.Controls.Add(this.inputItem);
            this.groupBox4.Controls.Add(this.dataGridItem);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.inputSubTotal);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(11, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(727, 310);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item\'s Detail";
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Location = new System.Drawing.Point(546, 277);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(122, 17);
            this.labelTotalItem.TabIndex = 37;
            this.labelTotalItem.Text = "Total Price : Rp. 0";
            // 
            // inputCompensation
            // 
            this.inputCompensation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCompensation.Enabled = false;
            this.inputCompensation.Location = new System.Drawing.Point(158, 98);
            this.inputCompensation.Name = "inputCompensation";
            this.inputCompensation.Size = new System.Drawing.Size(200, 22);
            this.inputCompensation.TabIndex = 36;
            this.inputCompensation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Compensation Fee :";
            // 
            // inputItemStatus
            // 
            this.inputItemStatus.DataSource = this.itemStatusBindingSource;
            this.inputItemStatus.DisplayMember = "Name";
            this.inputItemStatus.FormattingEnabled = true;
            this.inputItemStatus.Location = new System.Drawing.Point(472, 61);
            this.inputItemStatus.Name = "inputItemStatus";
            this.inputItemStatus.Size = new System.Drawing.Size(236, 24);
            this.inputItemStatus.TabIndex = 2;
            this.inputItemStatus.Tag = " ";
            this.inputItemStatus.ValueMember = "ID";
            this.inputItemStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // itemStatusBindingSource
            // 
            this.itemStatusBindingSource.DataMember = "ItemStatus";
            this.itemStatusBindingSource.DataSource = this.dB_HOTEL_RPLDataSet;
            // 
            // inputQuantity
            // 
            this.inputQuantity.Location = new System.Drawing.Point(96, 64);
            this.inputQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(262, 22);
            this.inputQuantity.TabIndex = 26;
            this.inputQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputQuantity.ValueChanged += new System.EventHandler(this.inputQuantity_ValueChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(625, 89);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(85, 40);
            this.btnAddItem.TabIndex = 34;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // inputItem
            // 
            this.inputItem.DataSource = this.itemBindingSource;
            this.inputItem.DisplayMember = "Name";
            this.inputItem.FormattingEnabled = true;
            this.inputItem.Location = new System.Drawing.Point(96, 34);
            this.inputItem.Name = "inputItem";
            this.inputItem.Size = new System.Drawing.Size(262, 24);
            this.inputItem.TabIndex = 28;
            this.inputItem.ValueMember = "ID";
            this.inputItem.SelectedIndexChanged += new System.EventHandler(this.inputItem_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dB_HOTEL_RPLDataSet;
            // 
            // dataGridItem
            // 
            this.dataGridItem.AllowUserToAddRows = false;
            this.dataGridItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItem.Location = new System.Drawing.Point(18, 139);
            this.dataGridItem.Name = "dataGridItem";
            this.dataGridItem.RowTemplate.Height = 24;
            this.dataGridItem.Size = new System.Drawing.Size(692, 119);
            this.dataGridItem.TabIndex = 34;
            this.dataGridItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItem_CellContentClick);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(380, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Item Status :";
            // 
            // inputSubTotal
            // 
            this.inputSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSubTotal.Enabled = false;
            this.inputSubTotal.Location = new System.Drawing.Point(472, 34);
            this.inputSubTotal.Name = "inputSubTotal";
            this.inputSubTotal.Size = new System.Drawing.Size(236, 22);
            this.inputSubTotal.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Sub Total :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Quantity :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Item :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelTotalFoodsAndDrinks);
            this.groupBox2.Controls.Add(this.dataGridFoodsAndDrinks);
            this.groupBox2.Location = new System.Drawing.Point(12, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 211);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foods And Drinks Detail";
            // 
            // labelTotalFoodsAndDrinks
            // 
            this.labelTotalFoodsAndDrinks.AutoSize = true;
            this.labelTotalFoodsAndDrinks.Location = new System.Drawing.Point(543, 174);
            this.labelTotalFoodsAndDrinks.Name = "labelTotalFoodsAndDrinks";
            this.labelTotalFoodsAndDrinks.Size = new System.Drawing.Size(122, 17);
            this.labelTotalFoodsAndDrinks.TabIndex = 37;
            this.labelTotalFoodsAndDrinks.Text = "Total Price : Rp. 0";
            // 
            // dataGridFoodsAndDrinks
            // 
            this.dataGridFoodsAndDrinks.AllowUserToAddRows = false;
            this.dataGridFoodsAndDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFoodsAndDrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFoodsAndDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFoodsAndDrinks.Location = new System.Drawing.Point(15, 36);
            this.dataGridFoodsAndDrinks.Name = "dataGridFoodsAndDrinks";
            this.dataGridFoodsAndDrinks.RowTemplate.Height = 24;
            this.dataGridFoodsAndDrinks.Size = new System.Drawing.Size(692, 119);
            this.dataGridFoodsAndDrinks.TabIndex = 34;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 664);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 40);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.labelTotalPrice.Location = new System.Drawing.Point(526, 674);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(150, 20);
            this.labelTotalPrice.TabIndex = 38;
            this.labelTotalPrice.Text = "Total Charge : Rp. 0";
            this.labelTotalPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // reservationRoomTableAdapter
            // 
            this.reservationRoomTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // itemStatusTableAdapter
            // 
            this.itemStatusTableAdapter.ClearBeforeFill = true;
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 716);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.Load += new System.EventHandler(this.FormCheckOut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodsAndDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox inputRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown inputQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox inputItem;
        private System.Windows.Forms.DataGridView dataGridItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox inputSubTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox inputItemStatus;
        private System.Windows.Forms.TextBox inputCompensation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTotalFoodsAndDrinks;
        private System.Windows.Forms.DataGridView dataGridFoodsAndDrinks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelTotalPrice;
        private DB_HOTEL_RPLDataSet dB_HOTEL_RPLDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private DB_HOTEL_RPLDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private DB_HOTEL_RPLDataSetTableAdapters.ReservationRoomTableAdapter reservationRoomTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DB_HOTEL_RPLDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource itemStatusBindingSource;
        private DB_HOTEL_RPLDataSetTableAdapters.ItemStatusTableAdapter itemStatusTableAdapter;
    }
}