using System.Windows.Forms;

namespace HotelRPLApp3.Reservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.inputDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.inputGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNIK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputSearchCustomer = new System.Windows.Forms.TextBox();
            this.optionSearch = new System.Windows.Forms.RadioButton();
            this.optionAddNew = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputStaying = new System.Windows.Forms.NumericUpDown();
            this.inputCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.inputRoomType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAvailableRooms = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSelectedRooms = new System.Windows.Forms.DataGridView();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.inputItem = new System.Windows.Forms.ComboBox();
            this.inputSubtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.inputQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dataGridViewAdditionalItems = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.printDocumentNota = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputStaying)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRooms)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedRooms)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdditionalItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewCustomer);
            this.groupBox1.Controls.Add(this.inputDateOfBirth);
            this.groupBox1.Controls.Add(this.inputGender);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.inputPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputNIK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputSearchCustomer);
            this.groupBox1.Controls.Add(this.optionSearch);
            this.groupBox1.Controls.Add(this.optionAddNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(474, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(17, 51);
            this.dataGridViewCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 29;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(440, 171);
            this.dataGridViewCustomer.TabIndex = 1;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            // 
            // inputDateOfBirth
            // 
            this.inputDateOfBirth.Location = new System.Drawing.Point(157, 181);
            this.inputDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputDateOfBirth.Name = "inputDateOfBirth";
            this.inputDateOfBirth.Size = new System.Drawing.Size(273, 22);
            this.inputDateOfBirth.TabIndex = 15;
            // 
            // inputGender
            // 
            this.inputGender.FormattingEnabled = true;
            this.inputGender.Location = new System.Drawing.Point(157, 128);
            this.inputGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(273, 24);
            this.inputGender.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date Of Birth :";
            // 
            // inputPhone
            // 
            this.inputPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPhone.Location = new System.Drawing.Point(157, 154);
            this.inputPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(27, 22);
            this.inputPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender :";
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEmail.Location = new System.Drawing.Point(157, 102);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(27, 22);
            this.inputEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email :";
            // 
            // inputNIK
            // 
            this.inputNIK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNIK.Location = new System.Drawing.Point(157, 75);
            this.inputNIK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNIK.Name = "inputNIK";
            this.inputNIK.Size = new System.Drawing.Size(27, 22);
            this.inputNIK.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIK :";
            // 
            // inputName
            // 
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputName.Location = new System.Drawing.Point(157, 49);
            this.inputName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(27, 22);
            this.inputName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name :";
            // 
            // inputSearchCustomer
            // 
            this.inputSearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSearchCustomer.Location = new System.Drawing.Point(208, 22);
            this.inputSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputSearchCustomer.Name = "inputSearchCustomer";
            this.inputSearchCustomer.Size = new System.Drawing.Size(249, 22);
            this.inputSearchCustomer.TabIndex = 2;
            this.inputSearchCustomer.TextChanged += new System.EventHandler(this.inputSearchCustomer_TextChanged);
            // 
            // optionSearch
            // 
            this.optionSearch.AutoSize = true;
            this.optionSearch.Checked = true;
            this.optionSearch.Location = new System.Drawing.Point(128, 23);
            this.optionSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionSearch.Name = "optionSearch";
            this.optionSearch.Size = new System.Drawing.Size(71, 20);
            this.optionSearch.TabIndex = 1;
            this.optionSearch.TabStop = true;
            this.optionSearch.Text = "Search";
            this.optionSearch.UseVisualStyleBackColor = true;
            this.optionSearch.CheckedChanged += new System.EventHandler(this.optionSearch_CheckedChanged);
            // 
            // optionAddNew
            // 
            this.optionAddNew.AutoSize = true;
            this.optionAddNew.Location = new System.Drawing.Point(17, 22);
            this.optionAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionAddNew.Name = "optionAddNew";
            this.optionAddNew.Size = new System.Drawing.Size(83, 20);
            this.optionAddNew.TabIndex = 0;
            this.optionAddNew.Text = "Add New";
            this.optionAddNew.UseVisualStyleBackColor = true;
            this.optionAddNew.CheckedChanged += new System.EventHandler(this.optionAddNew_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.inputStaying);
            this.groupBox2.Controls.Add(this.inputCheckOut);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.inputCheckIn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(519, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(486, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation";
            // 
            // inputStaying
            // 
            this.inputStaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputStaying.Location = new System.Drawing.Point(146, 59);
            this.inputStaying.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputStaying.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputStaying.Name = "inputStaying";
            this.inputStaying.Size = new System.Drawing.Size(324, 22);
            this.inputStaying.TabIndex = 22;
            this.inputStaying.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputStaying.ValueChanged += new System.EventHandler(this.inputStaying_ValueChanged);
            // 
            // inputCheckOut
            // 
            this.inputCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCheckOut.Enabled = false;
            this.inputCheckOut.Location = new System.Drawing.Point(146, 93);
            this.inputCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCheckOut.Name = "inputCheckOut";
            this.inputCheckOut.Size = new System.Drawing.Size(324, 22);
            this.inputCheckOut.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Check Out Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Staying :";
            // 
            // inputCheckIn
            // 
            this.inputCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCheckIn.Location = new System.Drawing.Point(146, 24);
            this.inputCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCheckIn.Name = "inputCheckIn";
            this.inputCheckIn.Size = new System.Drawing.Size(324, 22);
            this.inputCheckIn.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Check In Date :";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnSearchRoom);
            this.groupBox3.Controls.Add(this.inputRoomType);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(519, 141);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(486, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Type";
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(129, 58);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(109, 31);
            this.btnSearchRoom.TabIndex = 18;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // inputRoomType
            // 
            this.inputRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRoomType.FormattingEnabled = true;
            this.inputRoomType.Location = new System.Drawing.Point(129, 31);
            this.inputRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputRoomType.Name = "inputRoomType";
            this.inputRoomType.Size = new System.Drawing.Size(341, 24);
            this.inputRoomType.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Room Type :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewAvailableRooms);
            this.groupBox4.Location = new System.Drawing.Point(12, 258);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(447, 183);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Available Rooms :";
            // 
            // dataGridViewAvailableRooms
            // 
            this.dataGridViewAvailableRooms.AllowUserToAddRows = false;
            this.dataGridViewAvailableRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableRooms.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewAvailableRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAvailableRooms.Name = "dataGridViewAvailableRooms";
            this.dataGridViewAvailableRooms.RowHeadersWidth = 51;
            this.dataGridViewAvailableRooms.RowTemplate.Height = 29;
            this.dataGridViewAvailableRooms.Size = new System.Drawing.Size(435, 153);
            this.dataGridViewAvailableRooms.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dataGridViewSelectedRooms);
            this.groupBox5.Location = new System.Drawing.Point(521, 258);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(482, 183);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected Rooms";
            // 
            // dataGridViewSelectedRooms
            // 
            this.dataGridViewSelectedRooms.AllowUserToAddRows = false;
            this.dataGridViewSelectedRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSelectedRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelectedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedRooms.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewSelectedRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSelectedRooms.Name = "dataGridViewSelectedRooms";
            this.dataGridViewSelectedRooms.RowHeadersWidth = 51;
            this.dataGridViewSelectedRooms.RowTemplate.Height = 29;
            this.dataGridViewSelectedRooms.Size = new System.Drawing.Size(476, 153);
            this.dataGridViewSelectedRooms.TabIndex = 1;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Location = new System.Drawing.Point(465, 317);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(50, 36);
            this.btnAddRoom.TabIndex = 19;
            this.btnAddRoom.Text = ">>";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRoom.Location = new System.Drawing.Point(465, 357);
            this.btnRemoveRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(50, 36);
            this.btnRemoveRoom.TabIndex = 20;
            this.btnRemoveRoom.Text = "<<";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.inputItem);
            this.groupBox6.Controls.Add(this.inputSubtotal);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.inputPrice);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.inputQuantity);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.btnAddItem);
            this.groupBox6.Controls.Add(this.dataGridViewAdditionalItems);
            this.groupBox6.Location = new System.Drawing.Point(12, 457);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(730, 219);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Additional Items";
            // 
            // inputItem
            // 
            this.inputItem.FormattingEnabled = true;
            this.inputItem.Location = new System.Drawing.Point(106, 20);
            this.inputItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputItem.Name = "inputItem";
            this.inputItem.Size = new System.Drawing.Size(243, 24);
            this.inputItem.TabIndex = 16;
            this.inputItem.TextChanged += new System.EventHandler(this.inputItem_SelectedIndexChanged);
            // 
            // inputSubtotal
            // 
            this.inputSubtotal.Enabled = false;
            this.inputSubtotal.Location = new System.Drawing.Point(453, 48);
            this.inputSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputSubtotal.Name = "inputSubtotal";
            this.inputSubtotal.Size = new System.Drawing.Size(243, 22);
            this.inputSubtotal.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(364, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Sub Total :";
            // 
            // inputPrice
            // 
            this.inputPrice.Enabled = false;
            this.inputPrice.Location = new System.Drawing.Point(453, 21);
            this.inputPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(243, 22);
            this.inputPrice.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(364, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Price :";
            // 
            // inputQuantity
            // 
            this.inputQuantity.Location = new System.Drawing.Point(106, 47);
            this.inputQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(243, 22);
            this.inputQuantity.TabIndex = 21;
            this.inputQuantity.TextChanged += new System.EventHandler(this.inputQuantity_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Quantity :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Item :";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(621, 78);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(103, 31);
            this.btnAddItem.TabIndex = 19;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dataGridViewAdditionalItems
            // 
            this.dataGridViewAdditionalItems.AllowUserToAddRows = false;
            this.dataGridViewAdditionalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdditionalItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdditionalItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdditionalItems.Location = new System.Drawing.Point(6, 78);
            this.dataGridViewAdditionalItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAdditionalItems.Name = "dataGridViewAdditionalItems";
            this.dataGridViewAdditionalItems.RowHeadersWidth = 51;
            this.dataGridViewAdditionalItems.RowTemplate.Height = 29;
            this.dataGridViewAdditionalItems.Size = new System.Drawing.Size(608, 128);
            this.dataGridViewAdditionalItems.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(767, 525);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(238, 31);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.Location = new System.Drawing.Point(767, 475);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "Total :";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTotal.Location = new System.Drawing.Point(767, 493);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(82, 28);
            this.labelTotal.TabIndex = 27;
            this.labelTotal.Text = "Rp. 0,00";
            // 
            // printDocumentNota
            // 
            this.printDocumentNota.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentNota_PrintPage);
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 687);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnRemoveRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReservation";
            this.Text = "Reservation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputStaying)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableRooms)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedRooms)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdditionalItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton optionAddNew;
        private RadioButton optionSearch;
        private TextBox inputSearchCustomer;
        private TextBox inputName;
        private Label label1;
        private TextBox inputPhone;
        private Label label5;
        private Label label4;
        private TextBox inputEmail;
        private Label label3;
        private TextBox inputNIK;
        private Label label2;
        private Label label6;
        private DateTimePicker inputDateOfBirth;
        private ComboBox inputGender;
        private GroupBox groupBox2;
        private DateTimePicker inputCheckIn;
        private Label label7;
        private NumericUpDown inputStaying;
        private DateTimePicker inputCheckOut;
        private Label label9;
        private Label label8;
        private GroupBox groupBox3;
        private ComboBox inputRoomType;
        private Label label10;
        private Button btnSearchRoom;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button btnAddRoom;
        private Button btnRemoveRoom;
        private DataGridView dataGridViewAvailableRooms;
        private DataGridView dataGridViewSelectedRooms;
        private GroupBox groupBox6;
        private DataGridView dataGridViewAdditionalItems;
        private Button btnAddItem;
        private Label label11;
        private TextBox inputQuantity;
        private Label label12;
        private TextBox inputSubtotal;
        private Label label13;
        private TextBox inputPrice;
        private Label label14;
        private ComboBox inputItem;
        private Button btnSubmit;
        private Label label15;
        private Label labelTotal;
        private DataGridView dataGridViewCustomer;
        private System.Drawing.Printing.PrintDocument printDocumentNota;
    }
}