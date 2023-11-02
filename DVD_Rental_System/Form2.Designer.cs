namespace DVD_Rental_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.home_btn = new System.Windows.Forms.Button();
            this.rents_btn = new System.Windows.Forms.Button();
            this.cust_btn = new System.Windows.Forms.Button();
            this.dvd_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SystemPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SystemPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(171)))));
            this.panelMenu.Controls.Add(this.home_btn);
            this.panelMenu.Controls.Add(this.rents_btn);
            this.panelMenu.Controls.Add(this.cust_btn);
            this.panelMenu.Controls.Add(this.dvd_btn);
            this.panelMenu.Location = new System.Drawing.Point(0, 99);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 470);
            this.panelMenu.TabIndex = 0;
            // 
            // home_btn
            // 
            this.home_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.Location = new System.Drawing.Point(12, 425);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(63, 29);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // rents_btn
            // 
            this.rents_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rents_btn.FlatAppearance.BorderSize = 0;
            this.rents_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rents_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rents_btn.Image = global::DVD_Rental_System.Properties.Resources.icons8_scroll_48;
            this.rents_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rents_btn.Location = new System.Drawing.Point(0, 160);
            this.rents_btn.Name = "rents_btn";
            this.rents_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rents_btn.Size = new System.Drawing.Size(189, 80);
            this.rents_btn.TabIndex = 3;
            this.rents_btn.Text = " Rents";
            this.rents_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rents_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rents_btn.UseVisualStyleBackColor = true;
            this.rents_btn.Click += new System.EventHandler(this.rents_btn_Click);
            // 
            // cust_btn
            // 
            this.cust_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cust_btn.FlatAppearance.BorderSize = 0;
            this.cust_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cust_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_btn.Image = global::DVD_Rental_System.Properties.Resources.icons8_customer_48;
            this.cust_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cust_btn.Location = new System.Drawing.Point(0, 80);
            this.cust_btn.Name = "cust_btn";
            this.cust_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cust_btn.Size = new System.Drawing.Size(189, 80);
            this.cust_btn.TabIndex = 2;
            this.cust_btn.Text = " Customers";
            this.cust_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cust_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cust_btn.UseVisualStyleBackColor = true;
            this.cust_btn.Click += new System.EventHandler(this.cust_btn_Click);
            // 
            // dvd_btn
            // 
            this.dvd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(171)))));
            this.dvd_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvd_btn.FlatAppearance.BorderSize = 0;
            this.dvd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dvd_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvd_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dvd_btn.Image = global::DVD_Rental_System.Properties.Resources.icons8_cd_48;
            this.dvd_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dvd_btn.Location = new System.Drawing.Point(0, 0);
            this.dvd_btn.Name = "dvd_btn";
            this.dvd_btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dvd_btn.Size = new System.Drawing.Size(189, 80);
            this.dvd_btn.TabIndex = 0;
            this.dvd_btn.Text = " DVDs";
            this.dvd_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dvd_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dvd_btn.UseVisualStyleBackColor = false;
            this.dvd_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 99);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVD_Rental_System.Properties.Resources._2;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(300, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(30)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Location = new System.Drawing.Point(189, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 99);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Image = global::DVD_Rental_System.Properties.Resources.icons8_x_24;
            this.exit_btn.Location = new System.Drawing.Point(758, 9);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(20, 20);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 29);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(376, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(76, 30);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "HOME";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SystemPanel
            // 
            this.SystemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemPanel.Controls.Add(this.BodyPanel);
            this.SystemPanel.Location = new System.Drawing.Point(189, 99);
            this.SystemPanel.Name = "SystemPanel";
            this.SystemPanel.Size = new System.Drawing.Size(788, 467);
            this.SystemPanel.TabIndex = 2;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BodyPanel.Controls.Add(this.label1);
            this.BodyPanel.Controls.Add(this.pictureBox1);
            this.BodyPanel.Controls.Add(this.pictureBox2);
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(788, 467);
            this.BodyPanel.TabIndex = 0;
            this.BodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BodyPanel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pictureBox2.Image = global::DVD_Rental_System.Properties.Resources.icons8_hi_96;
            this.pictureBox2.Location = new System.Drawing.Point(160, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin!";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "DVD Rental\r\nSystem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(976, 565);
            this.Controls.Add(this.SystemPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVD Rental System";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SystemPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dvd_btn;
        private System.Windows.Forms.Button rents_btn;
        private System.Windows.Forms.Button cust_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel SystemPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}