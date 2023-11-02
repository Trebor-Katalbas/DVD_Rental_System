namespace DVD_Rental_System.ModuleForms
{
    partial class add_dvd
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
            this.DVD_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.ClearFields = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.available = new System.Windows.Forms.RadioButton();
            this.rented = new System.Windows.Forms.RadioButton();
            this.returned = new System.Windows.Forms.RadioButton();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.DVD_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 78);
            this.panel1.TabIndex = 0;
            // 
            // DVD_ID
            // 
            this.DVD_ID.BackColor = System.Drawing.Color.White;
            this.DVD_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVD_ID.Enabled = false;
            this.DVD_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVD_ID.Location = new System.Drawing.Point(280, 35);
            this.DVD_ID.Name = "DVD_ID";
            this.DVD_ID.Size = new System.Drawing.Size(82, 18);
            this.DVD_ID.TabIndex = 3;
            this.DVD_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(12, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(104, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Add DVD";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(108, 117);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(254, 20);
            this.TitleBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(108, 211);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(254, 20);
            this.PriceBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightGreen;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(265, 321);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 34);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.FlatAppearance.BorderSize = 0;
            this.ClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFields.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.ForeColor = System.Drawing.Color.Red;
            this.ClearFields.Location = new System.Drawing.Point(91, 321);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(65, 34);
            this.ClearFields.TabIndex = 5;
            this.ClearFields.Text = "Clear";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Edit.Enabled = false;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(162, 321);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 34);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Location = new System.Drawing.Point(108, 259);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(68, 17);
            this.available.TabIndex = 7;
            this.available.TabStop = true;
            this.available.Text = "Available";
            this.available.UseVisualStyleBackColor = true;
            // 
            // rented
            // 
            this.rented.AutoSize = true;
            this.rented.Location = new System.Drawing.Point(108, 282);
            this.rented.Name = "rented";
            this.rented.Size = new System.Drawing.Size(60, 17);
            this.rented.TabIndex = 7;
            this.rented.TabStop = true;
            this.rented.Text = "Rented";
            this.rented.UseVisualStyleBackColor = true;
            // 
            // returned
            // 
            this.returned.AutoSize = true;
            this.returned.Location = new System.Drawing.Point(199, 259);
            this.returned.Name = "returned";
            this.returned.Size = new System.Drawing.Size(69, 17);
            this.returned.TabIndex = 7;
            this.returned.TabStop = true;
            this.returned.Text = "Returned";
            this.returned.UseVisualStyleBackColor = true;
            // 
            // GenreBox
            // 
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Drama",
            "Fantasy",
            "Horror",
            "Romance",
            "Science Fiction",
            "Documentary",
            "Musical",
            "Historical",
            "Sports",
            "Political",
            "Post-Apocalyptic",
            "Zombie"});
            this.GenreBox.Location = new System.Drawing.Point(108, 164);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(254, 21);
            this.GenreBox.TabIndex = 8;
            // 
            // add_dvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 383);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.returned);
            this.Controls.Add(this.rented);
            this.Controls.Add(this.available);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.panel1);
            this.Name = "add_dvd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add DVD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearFields;
        public System.Windows.Forms.TextBox TitleBox;
        public System.Windows.Forms.TextBox PriceBox;
        public System.Windows.Forms.Button Add;
        public System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox DVD_ID;
        public System.Windows.Forms.RadioButton available;
        public System.Windows.Forms.RadioButton rented;
        public System.Windows.Forms.RadioButton returned;
        public System.Windows.Forms.ComboBox GenreBox;
    }
}