namespace DVD_Rental_System.ModuleForms
{
    partial class add_cust
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
            this.Cust_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.ClearFields = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.ContBox = new System.Windows.Forms.TextBox();
            this.LastBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.Cust_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 79);
            this.panel1.TabIndex = 7;
            // 
            // Cust_ID
            // 
            this.Cust_ID.BackColor = System.Drawing.Color.White;
            this.Cust_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cust_ID.Enabled = false;
            this.Cust_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_ID.Location = new System.Drawing.Point(280, 35);
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.Size = new System.Drawing.Size(82, 18);
            this.Cust_ID.TabIndex = 3;
            this.Cust_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.TitleLabel.Size = new System.Drawing.Size(154, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Add Customer";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Edit.Enabled = false;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(162, 320);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 34);
            this.Edit.TabIndex = 17;
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
            this.ClearFields.Location = new System.Drawing.Point(91, 320);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(65, 34);
            this.ClearFields.TabIndex = 16;
            this.ClearFields.Text = "Clear";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightGreen;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(265, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 34);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name :";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(108, 254);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(254, 20);
            this.AddressBox.TabIndex = 14;
            // 
            // ContBox
            // 
            this.ContBox.Location = new System.Drawing.Point(166, 210);
            this.ContBox.Name = "ContBox";
            this.ContBox.Size = new System.Drawing.Size(196, 20);
            this.ContBox.TabIndex = 13;
            // 
            // LastBox
            // 
            this.LastBox.Location = new System.Drawing.Point(166, 163);
            this.LastBox.Name = "LastBox";
            this.LastBox.Size = new System.Drawing.Size(196, 20);
            this.LastBox.TabIndex = 8;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(166, 116);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(196, 20);
            this.NameBox.TabIndex = 7;
            // 
            // add_cust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 383);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.LastBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_cust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Cust_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button ClearFields;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox AddressBox;
        public System.Windows.Forms.TextBox ContBox;
        public System.Windows.Forms.TextBox LastBox;
        public System.Windows.Forms.TextBox NameBox;
    }
}