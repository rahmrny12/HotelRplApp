namespace HotelRplApp
{
    partial class FormItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputRequestPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCompensationFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // inputName
            // 
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(185, 24);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(402, 25);
            this.inputName.TabIndex = 1;
            // 
            // inputRequestPrice
            // 
            this.inputRequestPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputRequestPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRequestPrice.Location = new System.Drawing.Point(185, 55);
            this.inputRequestPrice.Name = "inputRequestPrice";
            this.inputRequestPrice.Size = new System.Drawing.Size(402, 25);
            this.inputRequestPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Request Price :";
            // 
            // inputCompensationFee
            // 
            this.inputCompensationFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCompensationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCompensationFee.Location = new System.Drawing.Point(185, 86);
            this.inputCompensationFee.Name = "inputCompensationFee";
            this.inputCompensationFee.Size = new System.Drawing.Size(402, 25);
            this.inputCompensationFee.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Compensation Fee :";
            // 
            // dataGridItems
            // 
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Location = new System.Drawing.Point(21, 129);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowTemplate.Height = 24;
            this.dataGridItems.Size = new System.Drawing.Size(566, 224);
            this.dataGridItems.TabIndex = 6;
            this.dataGridItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItems_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Location = new System.Drawing.Point(21, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(451, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(228, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 40);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(6, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(106, 40);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridItems);
            this.Controls.Add(this.inputCompensationFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputRequestPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label1);
            this.Name = "FormItem";
            this.Text = "FormItem";
            this.Load += new System.EventHandler(this.FormItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputRequestPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCompensationFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
    }
}