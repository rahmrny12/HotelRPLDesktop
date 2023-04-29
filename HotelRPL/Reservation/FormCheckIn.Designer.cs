using System.Windows.Forms;

namespace HotelRPLApp3.Reservation
{
    partial class FormCheckIn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchBooking = new System.Windows.Forms.Button();
            this.inputSearchBooking = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.optionFemale = new System.Windows.Forms.RadioButton();
            this.optionMale = new System.Windows.Forms.RadioButton();
            this.inputNIK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.btmClose = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchBooking);
            this.groupBox1.Controls.Add(this.inputSearchBooking);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Code Search";
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBooking.Location = new System.Drawing.Point(477, 32);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.Size = new System.Drawing.Size(91, 37);
            this.btnSearchBooking.TabIndex = 2;
            this.btnSearchBooking.Text = "Search";
            this.btnSearchBooking.UseVisualStyleBackColor = true;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
            // 
            // inputSearchBooking
            // 
            this.inputSearchBooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearchBooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSearchBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.inputSearchBooking.Location = new System.Drawing.Point(146, 37);
            this.inputSearchBooking.Name = "inputSearchBooking";
            this.inputSearchBooking.Size = new System.Drawing.Size(309, 25);
            this.inputSearchBooking.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Code :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Age :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gender :";
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputEmail.Location = new System.Drawing.Point(128, 94);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.ReadOnly = true;
            this.inputEmail.Size = new System.Drawing.Size(304, 22);
            this.inputEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email :";
            // 
            // inputName
            // 
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputName.Location = new System.Drawing.Point(128, 66);
            this.inputName.Name = "inputName";
            this.inputName.ReadOnly = true;
            this.inputName.Size = new System.Drawing.Size(304, 22);
            this.inputName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPhoneNumber.Location = new System.Drawing.Point(128, 38);
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Size = new System.Drawing.Size(304, 22);
            this.inputPhoneNumber.TabIndex = 1;
            this.inputPhoneNumber.TextChanged += new System.EventHandler(this.inputPhoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone Number :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewRoom);
            this.groupBox2.Location = new System.Drawing.Point(19, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 215);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room\'s Information";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowTemplate.Height = 24;
            this.dataGridViewRoom.Size = new System.Drawing.Size(470, 177);
            this.dataGridViewRoom.TabIndex = 0;
            // 
            // optionFemale
            // 
            this.optionFemale.AutoSize = true;
            this.optionFemale.Enabled = false;
            this.optionFemale.Location = new System.Drawing.Point(214, 123);
            this.optionFemale.Name = "optionFemale";
            this.optionFemale.Size = new System.Drawing.Size(74, 20);
            this.optionFemale.TabIndex = 13;
            this.optionFemale.TabStop = true;
            this.optionFemale.Text = "Female";
            this.optionFemale.UseVisualStyleBackColor = true;
            // 
            // optionMale
            // 
            this.optionMale.AutoSize = true;
            this.optionMale.Enabled = false;
            this.optionMale.Location = new System.Drawing.Point(128, 123);
            this.optionMale.Name = "optionMale";
            this.optionMale.Size = new System.Drawing.Size(58, 20);
            this.optionMale.TabIndex = 12;
            this.optionMale.TabStop = true;
            this.optionMale.Text = "Male";
            this.optionMale.UseVisualStyleBackColor = true;
            // 
            // inputNIK
            // 
            this.inputNIK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputNIK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNIK.Location = new System.Drawing.Point(128, 178);
            this.inputNIK.Name = "inputNIK";
            this.inputNIK.ReadOnly = true;
            this.inputNIK.Size = new System.Drawing.Size(304, 22);
            this.inputNIK.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "NIK :";
            // 
            // inputAge
            // 
            this.inputAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAge.Location = new System.Drawing.Point(128, 150);
            this.inputAge.Name = "inputAge";
            this.inputAge.ReadOnly = true;
            this.inputAge.Size = new System.Drawing.Size(304, 22);
            this.inputAge.TabIndex = 9;
            // 
            // btmClose
            // 
            this.btmClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmClose.Location = new System.Drawing.Point(339, 22);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(91, 29);
            this.btmClose.TabIndex = 4;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Location = new System.Drawing.Point(242, 22);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(91, 29);
            this.btnCheckIn.TabIndex = 8;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btmClose);
            this.groupBox4.Controls.Add(this.btnCheckIn);
            this.groupBox4.Location = new System.Drawing.Point(519, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 68);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.optionFemale);
            this.groupBox3.Controls.Add(this.optionMale);
            this.groupBox3.Controls.Add(this.inputNIK);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.inputAge);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.inputEmail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.inputName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.inputPhoneNumber);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(519, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 217);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer\'s Information";
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCheckIn";
            this.Text = "FormCheckIn";
            this.Load += new System.EventHandler(this.FormCheckIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearchBooking;
        private TextBox inputSearchBooking;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox inputEmail;
        private Label label4;
        private TextBox inputName;
        private Label label3;
        private TextBox inputPhoneNumber;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridViewRoom;
        private RadioButton optionFemale;
        private RadioButton optionMale;
        private TextBox inputNIK;
        private Label label7;
        private TextBox inputAge;
        private Button btmClose;
        private Button btnCheckIn;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
    }
}