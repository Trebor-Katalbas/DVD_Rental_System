namespace DVD_Rental_System.ModuleForms
{
    partial class add_rents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rent_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.ClearFields = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DVDid = new System.Windows.Forms.TextBox();
            this.Customer_ID = new System.Windows.Forms.TextBox();
            this.DateRent = new System.Windows.Forms.DateTimePicker();
            this.DateReturned = new System.Windows.Forms.DateTimePicker();
            this.ReminderLabel = new System.Windows.Forms.Label();
            this.Unreturned = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.Rent_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 79);
            this.panel1.TabIndex = 7;
            // 
            // Rent_ID
            // 
            this.Rent_ID.BackColor = System.Drawing.Color.White;
            this.Rent_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rent_ID.Enabled = false;
            this.Rent_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_ID.Location = new System.Drawing.Point(280, 35);
            this.Rent_ID.Name = "Rent_ID";
            this.Rent_ID.Size = new System.Drawing.Size(82, 18);
            this.Rent_ID.TabIndex = 3;
            this.Rent_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID :";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(155, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Add DVD Rent";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Edit.Enabled = false;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(162, 322);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 34);
            this.Edit.TabIndex = 18;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.FlatAppearance.BorderSize = 0;
            this.ClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFields.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.ForeColor = System.Drawing.Color.Red;
            this.ClearFields.Location = new System.Drawing.Point(91, 322);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(65, 34);
            this.ClearFields.TabIndex = 17;
            this.ClearFields.Text = "Clear";
            this.ClearFields.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightGreen;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(265, 322);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 34);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Returned :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date Rented :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "DVD ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DVDid
            // 
            this.DVDid.Location = new System.Drawing.Point(151, 165);
            this.DVDid.Name = "DVDid";
            this.DVDid.Size = new System.Drawing.Size(211, 20);
            this.DVDid.TabIndex = 9;
            // 
            // Customer_ID
            // 
            this.Customer_ID.Location = new System.Drawing.Point(151, 118);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(211, 20);
            this.Customer_ID.TabIndex = 8;
            // 
            // DateRent
            // 
            this.DateRent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRent.Location = new System.Drawing.Point(151, 212);
            this.DateRent.Name = "DateRent";
            this.DateRent.Size = new System.Drawing.Size(211, 22);
            this.DateRent.TabIndex = 19;
            // 
            // DateReturned
            // 
            this.DateReturned.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateReturned.Location = new System.Drawing.Point(151, 256);
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.Size = new System.Drawing.Size(211, 22);
            this.DateReturned.TabIndex = 19;
            // 
            // ReminderLabel
            // 
            this.ReminderLabel.AutoSize = true;
            this.ReminderLabel.Location = new System.Drawing.Point(159, 93);
            this.ReminderLabel.Name = "ReminderLabel";
            this.ReminderLabel.Size = new System.Drawing.Size(168, 13);
            this.ReminderLabel.TabIndex = 20;
            this.ReminderLabel.Text = "*ID only (Remove Name and Title)";
            this.ReminderLabel.Visible = false;
            // 
            // Unreturned
            // 
            this.Unreturned.AutoSize = true;
            this.Unreturned.Location = new System.Drawing.Point(151, 284);
            this.Unreturned.Name = "Unreturned";
            this.Unreturned.Size = new System.Drawing.Size(79, 17);
            this.Unreturned.TabIndex = 21;
            this.Unreturned.Text = "Unreturned";
            this.Unreturned.UseVisualStyleBackColor = true;
            // 
            // add_rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 383);
            this.Controls.Add(this.Unreturned);
            this.Controls.Add(this.ReminderLabel);
            this.Controls.Add(this.DateReturned);
            this.Controls.Add(this.DateRent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DVDid);
            this.Controls.Add(this.Customer_ID);
            this.Name = "add_rents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Rent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Rent_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button ClearFields;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox DVDid;
        public System.Windows.Forms.TextBox Customer_ID;
        public System.Windows.Forms.DateTimePicker DateRent;
        public System.Windows.Forms.DateTimePicker DateReturned;
        public System.Windows.Forms.Label ReminderLabel;
        public System.Windows.Forms.CheckBox Unreturned;
    }
}