namespace HotelRplApp
{
    partial class FormFoodAndDrink
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.dataGridFoodsAndDrinks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.openMenuPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodsAndDrinks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(125, 25);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(354, 25);
            this.inputName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type :";
            // 
            // inputPrice
            // 
            this.inputPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPrice.Location = new System.Drawing.Point(125, 87);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(354, 25);
            this.inputPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Photo :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(25, 160);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 41);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxMenu.Location = new System.Drawing.Point(125, 128);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(459, 237);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenu.TabIndex = 8;
            this.pictureBoxMenu.TabStop = false;
            // 
            // dataGridFoodsAndDrinks
            // 
            this.dataGridFoodsAndDrinks.AllowUserToAddRows = false;
            this.dataGridFoodsAndDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFoodsAndDrinks.Location = new System.Drawing.Point(12, 386);
            this.dataGridFoodsAndDrinks.Name = "dataGridFoodsAndDrinks";
            this.dataGridFoodsAndDrinks.RowTemplate.Height = 24;
            this.dataGridFoodsAndDrinks.Size = new System.Drawing.Size(572, 150);
            this.dataGridFoodsAndDrinks.TabIndex = 9;
            this.dataGridFoodsAndDrinks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFoodsAndDrinks_CellClick);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 542);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 60);
            this.groupBox1.TabIndex = 10;
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
            // openMenuPhotoDialog
            // 
            this.openMenuPhotoDialog.FileName = "openFileDialog1";
            // 
            // inputType
            // 
            this.inputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "Food",
            "Drink"});
            this.inputType.Location = new System.Drawing.Point(125, 56);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(354, 26);
            this.inputType.TabIndex = 11;
            // 
            // FormFoodAndDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 613);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridFoodsAndDrinks);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label1);
            this.Name = "FormFoodAndDrink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Food And Drink";
            this.Load += new System.EventHandler(this.FormFoodAndDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodsAndDrinks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.DataGridView dataGridFoodsAndDrinks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.OpenFileDialog openMenuPhotoDialog;
        private System.Windows.Forms.ComboBox inputType;
    }
}