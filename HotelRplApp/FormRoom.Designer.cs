namespace HotelRplApp
{
    partial class FormRoom
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
            this.inputRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputRoomFloor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridRoom = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.inputRoomType = new System.Windows.Forms.ComboBox();
            this.roomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_HOTEL_RPLDataSet = new HotelRplApp.DB_HOTEL_RPLDataSet();
            this.roomTypeTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.RoomTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inputRoomNumber
            // 
            this.inputRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRoomNumber.Location = new System.Drawing.Point(162, 21);
            this.inputRoomNumber.Name = "inputRoomNumber";
            this.inputRoomNumber.Size = new System.Drawing.Size(389, 25);
            this.inputRoomNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Room Type :";
            // 
            // inputRoomFloor
            // 
            this.inputRoomFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputRoomFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRoomFloor.Location = new System.Drawing.Point(162, 99);
            this.inputRoomFloor.Name = "inputRoomFloor";
            this.inputRoomFloor.Size = new System.Drawing.Size(389, 25);
            this.inputRoomFloor.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Room Floor :";
            // 
            // inputDescription
            // 
            this.inputDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDescription.Location = new System.Drawing.Point(162, 138);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(389, 103);
            this.inputDescription.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description :";
            // 
            // dataGridRoom
            // 
            this.dataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoom.Location = new System.Drawing.Point(12, 267);
            this.dataGridRoom.Name = "dataGridRoom";
            this.dataGridRoom.RowTemplate.Height = 24;
            this.dataGridRoom.Size = new System.Drawing.Size(539, 150);
            this.dataGridRoom.TabIndex = 14;
            this.dataGridRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoom_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Location = new System.Drawing.Point(12, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 59);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(423, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(321, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 33);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 33);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 33);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(15, 18);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 33);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // inputRoomType
            // 
            this.inputRoomType.DataSource = this.roomTypeBindingSource;
            this.inputRoomType.DisplayMember = "Name";
            this.inputRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRoomType.FormattingEnabled = true;
            this.inputRoomType.Location = new System.Drawing.Point(162, 59);
            this.inputRoomType.Name = "inputRoomType";
            this.inputRoomType.Size = new System.Drawing.Size(389, 26);
            this.inputRoomType.TabIndex = 19;
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
            // roomTypeTableAdapter
            // 
            this.roomTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 505);
            this.Controls.Add(this.inputRoomType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridRoom);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputRoomFloor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputRoomNumber);
            this.Controls.Add(this.label3);
            this.Name = "FormRoom";
            this.Text = "FormRoom";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputRoomFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox inputRoomType;
        private DB_HOTEL_RPLDataSet dB_HOTEL_RPLDataSet;
        private System.Windows.Forms.BindingSource roomTypeBindingSource;
        private DB_HOTEL_RPLDataSetTableAdapters.RoomTypeTableAdapter roomTypeTableAdapter;
    }
}