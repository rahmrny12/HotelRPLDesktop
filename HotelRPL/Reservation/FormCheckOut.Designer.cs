using System.Windows.Forms;

namespace HotelRPLApp3.Reservation
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
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalFoodsAndDrinks = new System.Windows.Forms.Label();
            this.dataGridFoodsAndDrinks = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.inputCompensation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputItemStatus = new System.Windows.Forms.ComboBox();
            this.itemStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inputQuantity = new System.Windows.Forms.TextBox();
            this.inputItem = new System.Windows.Forms.ComboBox();
            this.dataGridItem = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.inputSubTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputRoom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printNota = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodsAndDrinks)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStatusBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.labelTotalPrice.Location = new System.Drawing.Point(588, 788);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(150, 20);
            this.labelTotalPrice.TabIndex = 41;
            this.labelTotalPrice.Text = "Total Charge : Rp. 0";
            // 
            // labelTotalFoodsAndDrinks
            // 
            this.labelTotalFoodsAndDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalFoodsAndDrinks.AutoSize = true;
            this.labelTotalFoodsAndDrinks.Location = new System.Drawing.Point(598, 222);
            this.labelTotalFoodsAndDrinks.Name = "labelTotalFoodsAndDrinks";
            this.labelTotalFoodsAndDrinks.Size = new System.Drawing.Size(112, 16);
            this.labelTotalFoodsAndDrinks.TabIndex = 37;
            this.labelTotalFoodsAndDrinks.Text = "Total Price : Rp. 0";
            // 
            // dataGridFoodsAndDrinks
            // 
            this.dataGridFoodsAndDrinks.AllowUserToAddRows = false;
            this.dataGridFoodsAndDrinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFoodsAndDrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFoodsAndDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFoodsAndDrinks.Location = new System.Drawing.Point(17, 38);
            this.dataGridFoodsAndDrinks.Name = "dataGridFoodsAndDrinks";
            this.dataGridFoodsAndDrinks.RowHeadersWidth = 51;
            this.dataGridFoodsAndDrinks.RowTemplate.Height = 24;
            this.dataGridFoodsAndDrinks.Size = new System.Drawing.Size(689, 165);
            this.dataGridFoodsAndDrinks.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelTotalFoodsAndDrinks);
            this.groupBox2.Controls.Add(this.dataGridFoodsAndDrinks);
            this.groupBox2.Location = new System.Drawing.Point(12, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 257);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foods And Drinks Detail";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Location = new System.Drawing.Point(599, 338);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(112, 16);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Compensation Fee :";
            // 
            // inputItemStatus
            // 
            this.inputItemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputItemStatus.DataSource = this.itemStatusBindingSource;
            this.inputItemStatus.DisplayMember = "Name";
            this.inputItemStatus.FormattingEnabled = true;
            this.inputItemStatus.Location = new System.Drawing.Point(472, 61);
            this.inputItemStatus.Name = "inputItemStatus";
            this.inputItemStatus.Size = new System.Drawing.Size(236, 24);
            this.inputItemStatus.TabIndex = 2;
            this.inputItemStatus.Tag = " ";
            this.inputItemStatus.ValueMember = "ID";
            // 
            // itemStatusBindingSource
            // 
            this.itemStatusBindingSource.DataMember = "ItemStatus";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 778);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(163, 40);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(623, 91);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(85, 40);
            this.btnAddItem.TabIndex = 34;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.inputQuantity);
            this.groupBox4.Controls.Add(this.inputItem);
            this.groupBox4.Controls.Add(this.labelTotalItem);
            this.groupBox4.Controls.Add(this.inputCompensation);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.inputItemStatus);
            this.groupBox4.Controls.Add(this.btnAddItem);
            this.groupBox4.Controls.Add(this.dataGridItem);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.inputSubTotal);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(11, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(727, 370);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item\'s Detail";
            // 
            // inputQuantity
            // 
            this.inputQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputQuantity.Location = new System.Drawing.Point(96, 64);
            this.inputQuantity.Name = "inputQuantity";
            this.inputQuantity.Size = new System.Drawing.Size(262, 22);
            this.inputQuantity.TabIndex = 39;
            this.inputQuantity.TextChanged += new System.EventHandler(this.inputQuantity_ValueChanged);
            // 
            // inputItem
            // 
            this.inputItem.FormattingEnabled = true;
            this.inputItem.Location = new System.Drawing.Point(96, 36);
            this.inputItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputItem.Name = "inputItem";
            this.inputItem.Size = new System.Drawing.Size(262, 24);
            this.inputItem.TabIndex = 38;
            this.inputItem.SelectedIndexChanged += new System.EventHandler(this.inputItem_SelectedIndexChanged);
            // 
            // dataGridItem
            // 
            this.dataGridItem.AllowUserToAddRows = false;
            this.dataGridItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItem.Location = new System.Drawing.Point(18, 140);
            this.dataGridItem.Name = "dataGridItem";
            this.dataGridItem.RowHeadersWidth = 51;
            this.dataGridItem.RowTemplate.Height = 24;
            this.dataGridItem.Size = new System.Drawing.Size(690, 182);
            this.dataGridItem.TabIndex = 34;
            this.dataGridItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItem_CellContentClick);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(380, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Item Status :";
            // 
            // inputSubTotal
            // 
            this.inputSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputSubTotal.Enabled = false;
            this.inputSubTotal.Location = new System.Drawing.Point(472, 34);
            this.inputSubTotal.Name = "inputSubTotal";
            this.inputSubTotal.Size = new System.Drawing.Size(236, 22);
            this.inputSubTotal.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(380, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Sub Total :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Quantity :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Item :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number :";
            // 
            // inputRoom
            // 
            this.inputRoom.DisplayMember = "ID";
            this.inputRoom.FormattingEnabled = true;
            this.inputRoom.Location = new System.Drawing.Point(132, 36);
            this.inputRoom.Name = "inputRoom";
            this.inputRoom.Size = new System.Drawing.Size(247, 24);
            this.inputRoom.TabIndex = 1;
            this.inputRoom.ValueMember = "ID";
            this.inputRoom.SelectedIndexChanged += new System.EventHandler(this.inputRoom_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputRoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 87);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room\'s Occupied";
            // 
            // printNota
            // 
            this.printNota.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printNota_PrintPage);
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 830);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.Load += new System.EventHandler(this.FormCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFoodsAndDrinks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStatusBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTotalPrice;
        private Label labelTotalFoodsAndDrinks;
        private DataGridView dataGridFoodsAndDrinks;
        private GroupBox groupBox2;
        private BindingSource itemBindingSource;
        private Label labelTotalItem;
        private TextBox inputCompensation;
        private Label label2;
        private ComboBox inputItemStatus;
        private BindingSource itemStatusBindingSource;
        private Button btnSubmit;
        private Button btnAddItem;
        private ComboBox inputItem;
        private GroupBox groupBox4;
        private DataGridView dataGridItem;
        private Label label16;
        private TextBox inputSubTotal;
        private Label label15;
        private Label label14;
        private Label label11;
        private Label label1;
        private ComboBox inputRoom;
        private GroupBox groupBox1;
        private TextBox inputQuantity;
        private System.Drawing.Printing.PrintDocument printNota;
    }
}