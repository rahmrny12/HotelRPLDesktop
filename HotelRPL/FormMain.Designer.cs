using System;
using System.Windows.Forms;

namespace HotelRPLApp3
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestAdditionalItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodAndDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.employeeToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.checkInToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.reservationToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.checkoutToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.exitToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.labelCurrentTime = new System.Windows.Forms.ToolStripLabel();
            this.labelJob = new System.Windows.Forms.ToolStripLabel();
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.masterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.requestAdditionalItemToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.checkInToolStripMenuItem.Text = "Check In";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // requestAdditionalItemToolStripMenuItem
            // 
            this.requestAdditionalItemToolStripMenuItem.Name = "requestAdditionalItemToolStripMenuItem";
            this.requestAdditionalItemToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.requestAdditionalItemToolStripMenuItem.Text = "Request Additional Item";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem1,
            this.guestsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // checkInToolStripMenuItem1
            // 
            this.checkInToolStripMenuItem1.Name = "checkInToolStripMenuItem1";
            this.checkInToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.checkInToolStripMenuItem1.Text = "Check In";
            this.checkInToolStripMenuItem1.Click += new System.EventHandler(this.checkInToolStripMenuItem1_Click);
            // 
            // guestsToolStripMenuItem
            // 
            this.guestsToolStripMenuItem.Name = "guestsToolStripMenuItem";
            this.guestsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guestsToolStripMenuItem.Text = "Guests";
            this.guestsToolStripMenuItem.Click += new System.EventHandler(this.guestsToolStripMenuItem_Click);
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
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // foodAndDrinkToolStripMenuItem
            // 
            this.foodAndDrinkToolStripMenuItem.Name = "foodAndDrinkToolStripMenuItem";
            this.foodAndDrinkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.foodAndDrinkToolStripMenuItem.Text = "FoodAndDrink";
            this.foodAndDrinkToolStripMenuItem.Click += new System.EventHandler(this.foodAndDrinkToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.itemToolStripMenuItem.Text = "Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // roomTypeToolStripMenuItem
            // 
            this.roomTypeToolStripMenuItem.Name = "roomTypeToolStripMenuItem";
            this.roomTypeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.roomTypeToolStripMenuItem.Text = "Room Type";
            this.roomTypeToolStripMenuItem.Click += new System.EventHandler(this.roomTypeToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStrip,
            this.checkInToolStrip,
            this.reservationToolStrip,
            this.checkoutToolStrip,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.logoutToolStrip,
            this.exitToolStrip,
            this.labelCurrentTime,
            this.labelJob});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // employeeToolStrip
            // 
            this.employeeToolStrip.Name = "employeeToolStrip";
            this.employeeToolStrip.Size = new System.Drawing.Size(75, 22);
            this.employeeToolStrip.Text = "Employee";
            this.employeeToolStrip.Click += new System.EventHandler(this.employeeToolStrip_Click);
            // 
            // checkInToolStrip
            // 
            this.checkInToolStrip.Name = "checkInToolStrip";
            this.checkInToolStrip.Size = new System.Drawing.Size(64, 22);
            this.checkInToolStrip.Text = "Check In";
            this.checkInToolStrip.Click += new System.EventHandler(this.checkInToolStrip_Click);
            // 
            // reservationToolStrip
            // 
            this.reservationToolStrip.Name = "reservationToolStrip";
            this.reservationToolStrip.Size = new System.Drawing.Size(86, 22);
            this.reservationToolStrip.Text = "Reservation";
            this.reservationToolStrip.Click += new System.EventHandler(this.reservationToolStrip_Click);
            // 
            // checkoutToolStrip
            // 
            this.checkoutToolStrip.Name = "checkoutToolStrip";
            this.checkoutToolStrip.Size = new System.Drawing.Size(76, 22);
            this.checkoutToolStrip.Text = "Check Out";
            this.checkoutToolStrip.Click += new System.EventHandler(this.checkoutToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // logoutToolStrip
            // 
            this.logoutToolStrip.Name = "logoutToolStrip";
            this.logoutToolStrip.Size = new System.Drawing.Size(62, 22);
            this.logoutToolStrip.Text = "Log Out";
            this.logoutToolStrip.Click += new System.EventHandler(this.logoutToolStrip_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(33, 22);
            this.exitToolStrip.Text = "Exit";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStrip_Click);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelCurrentTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(88, 22);
            this.labelCurrentTime.Text = "currentTime";
            // 
            // labelJob
            // 
            this.labelJob.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.labelJob.Margin = new System.Windows.Forms.Padding(0, 1, 80, 2);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(65, 22);
            this.labelJob.Text = "labelJob";
            // 
            // currentTimer
            // 
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem reservationToolStripMenuItem;
        private ToolStripMenuItem checkInToolStripMenuItem;
        private ToolStripMenuItem requestAdditionalItemToolStripMenuItem;
        private ToolStripMenuItem checkOutToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem checkInToolStripMenuItem1;
        private ToolStripMenuItem guestsToolStripMenuItem;
        private ToolStripMenuItem masterToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem foodAndDrinkToolStripMenuItem;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem roomTypeToolStripMenuItem;
        private ToolStripMenuItem roomToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripLabel checkoutToolStrip;
        private ToolStripLabel checkInToolStrip;
        private ToolStripLabel reservationToolStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel logoutToolStrip;
        private ToolStripLabel exitToolStrip;
        private ToolStripLabel employeeToolStrip;
        private ToolStripLabel labelCurrentTime;
        private ToolStripLabel labelJob;
        private System.Windows.Forms.Timer currentTimer;
    }
}