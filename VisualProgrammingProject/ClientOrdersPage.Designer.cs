﻿namespace VisualProgrammingProject
{
    partial class ClientOrdersPage
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDetailsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnStatus,
            this.columnTime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(445, 196);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 180;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.Width = 140;
            // 
            // orderDetailsBtn
            // 
            this.orderDetailsBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderDetailsBtn.Location = new System.Drawing.Point(155, 264);
            this.orderDetailsBtn.Name = "orderDetailsBtn";
            this.orderDetailsBtn.Size = new System.Drawing.Size(210, 76);
            this.orderDetailsBtn.TabIndex = 1;
            this.orderDetailsBtn.Text = "Order Details";
            this.orderDetailsBtn.UseVisualStyleBackColor = true;
            this.orderDetailsBtn.Click += new System.EventHandler(this.orderDetailsBtn_Click);
            // 
            // ClientOrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 372);
            this.Controls.Add(this.orderDetailsBtn);
            this.Controls.Add(this.listView1);
            this.Name = "ClientOrdersPage";
            this.Text = "ClientOrdersPage";
            this.Load += new System.EventHandler(this.ClientOrdersPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.Button orderDetailsBtn;
    }
}