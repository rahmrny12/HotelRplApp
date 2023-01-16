namespace HotelRplApp
{
    partial class FormReservation
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
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.inputDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.inputSearchCustomer = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inputPhoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputNIK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.inputStaying = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputRoomType = new System.Windows.Forms.ComboBox();
            this.roomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_HOTEL_RPLDataSet = new HotelRplApp.DB_HOTEL_RPLDataSet();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridAvailableRooms = new System.Windows.Forms.DataGridView();
            this.dataGridSelectedRooms = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.roomTypeTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.RoomTypeTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.ItemTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedRooms)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridCustomer);
            this.groupBox1.Controls.Add(this.inputDateOfBirth);
            this.groupBox1.Controls.Add(this.inputGender);
            this.groupBox1.Controls.Add(this.inputSearchCustomer);
            this.groupBox1.Controls.Add(this.labelSearch);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.inputPhoneNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.inputEmail);
            this.groupBox1.Controls.Add(this.inputCustomerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.inputNIK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer\'s Information";
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(13, 64);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowTemplate.Height = 24;
            this.dataGridCustomer.Size = new System.Drawing.Size(559, 185);
            this.dataGridCustomer.TabIndex = 26;
            // 
            // inputDateOfBirth
            // 
            this.inputDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDateOfBirth.CustomFormat = "dd MMM yyyy";
            this.inputDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDateOfBirth.Location = new System.Drawing.Point(141, 217);
            this.inputDateOfBirth.Name = "inputDateOfBirth";
            this.inputDateOfBirth.Size = new System.Drawing.Size(425, 22);
            this.inputDateOfBirth.TabIndex = 22;
            // 
            // inputGender
            // 
            this.inputGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.inputGender.Location = new System.Drawing.Point(141, 157);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(425, 24);
            this.inputGender.TabIndex = 21;
            // 
            // inputSearchCustomer
            // 
            this.inputSearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSearchCustomer.Location = new System.Drawing.Point(272, 31);
            this.inputSearchCustomer.Name = "inputSearchCustomer";
            this.inputSearchCustomer.Size = new System.Drawing.Size(294, 22);
            this.inputSearchCustomer.TabIndex = 20;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(205, 34);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(61, 17);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Search :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(114, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 21);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Search";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "Add New";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date Of Birth :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gender :";
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPhoneNumber.Location = new System.Drawing.Point(141, 187);
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Size = new System.Drawing.Size(425, 22);
            this.inputPhoneNumber.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Phone Number :";
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputEmail.Location = new System.Drawing.Point(141, 131);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(425, 22);
            this.inputEmail.TabIndex = 11;
            // 
            // inputCustomerName
            // 
            this.inputCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCustomerName.Location = new System.Drawing.Point(141, 75);
            this.inputCustomerName.Name = "inputCustomerName";
            this.inputCustomerName.Size = new System.Drawing.Size(425, 22);
            this.inputCustomerName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Customer Name :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // inputNIK
            // 
            this.inputNIK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNIK.Location = new System.Drawing.Point(141, 103);
            this.inputNIK.Name = "inputNIK";
            this.inputNIK.Size = new System.Drawing.Size(425, 22);
            this.inputNIK.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "NIK :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.inputStaying);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(603, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation\'s Information";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(140, 89);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(291, 22);
            this.dateTimePicker3.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(139, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(291, 22);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Check Out Date :";
            // 
            // inputStaying
            // 
            this.inputStaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputStaying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputStaying.Location = new System.Drawing.Point(139, 59);
            this.inputStaying.Name = "inputStaying";
            this.inputStaying.Size = new System.Drawing.Size(291, 22);
            this.inputStaying.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staying :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In Date :";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.inputRoomType);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(603, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 129);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room\'s Information";
            // 
            // inputRoomType
            // 
            this.inputRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRoomType.DataSource = this.roomTypeBindingSource;
            this.inputRoomType.DisplayMember = "Name";
            this.inputRoomType.FormattingEnabled = true;
            this.inputRoomType.Location = new System.Drawing.Point(135, 33);
            this.inputRoomType.Name = "inputRoomType";
            this.inputRoomType.Size = new System.Drawing.Size(290, 24);
            this.inputRoomType.TabIndex = 27;
            this.inputRoomType.ValueMember = "ID";
            // 
            // roomTypeBindingSource
            // 
            this.roomTypeBindingSource.DataMember = "RoomType";
            this.roomTypeBindingSource.DataSource = this.dB_HOTEL_RPLDataSet;
            // 
            // dB_HOTEL_RPLDataSet
            // 
            this.dB_HOTEL_RPLDataSet.DataSetName = "DB_HOTEL_RPLDataSet";
            this.dB_HOTEL_RPLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(134, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 40);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Type :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.label12.Location = new System.Drawing.Point(26, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Available Rooms :";
            // 
            // dataGridAvailableRooms
            // 
            this.dataGridAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAvailableRooms.Location = new System.Drawing.Point(25, 309);
            this.dataGridAvailableRooms.Name = "dataGridAvailableRooms";
            this.dataGridAvailableRooms.RowTemplate.Height = 24;
            this.dataGridAvailableRooms.Size = new System.Drawing.Size(443, 150);
            this.dataGridAvailableRooms.TabIndex = 22;
            // 
            // dataGridSelectedRooms
            // 
            this.dataGridSelectedRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSelectedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelectedRooms.Location = new System.Drawing.Point(603, 309);
            this.dataGridSelectedRooms.Name = "dataGridSelectedRooms";
            this.dataGridSelectedRooms.RowTemplate.Height = 24;
            this.dataGridSelectedRooms.Size = new System.Drawing.Size(436, 150);
            this.dataGridSelectedRooms.TabIndex = 24;
            this.dataGridSelectedRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.label13.Location = new System.Drawing.Point(602, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Selected Rooms :";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(25, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(724, 216);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request Additional Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // roomTypeTableAdapter
            // 
            this.roomTypeTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Item :";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(96, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 22);
            this.textBox2.TabIndex = 28;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Quantity :";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(472, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 22);
            this.textBox3.TabIndex = 30;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Price :";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(472, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(236, 22);
            this.textBox4.TabIndex = 32;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(380, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Sub Total :";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(779, 494);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Total Price : 1400000";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(782, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 40);
            this.button3.TabIndex = 28;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 119);
            this.dataGridView1.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.itemBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "ID";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dB_HOTEL_RPLDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 713);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridSelectedRooms);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridAvailableRooms);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReservation";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAvailableRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectedRooms)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox inputStaying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inputPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.TextBox inputCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputNIK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox inputSearchCustomer;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridAvailableRooms;
        private System.Windows.Forms.DataGridView dataGridSelectedRooms;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker inputDateOfBirth;
        private System.Windows.Forms.ComboBox inputGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.ComboBox inputRoomType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DB_HOTEL_RPLDataSet dB_HOTEL_RPLDataSet;
        private System.Windows.Forms.BindingSource roomTypeBindingSource;
        private DB_HOTEL_RPLDataSetTableAdapters.RoomTypeTableAdapter roomTypeTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DB_HOTEL_RPLDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
    }
}