namespace MonitorWaker_v0._1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.ibtn_Exit = new FontAwesome.Sharp.IconButton();
            this.panelSideMenuAboutMe = new System.Windows.Forms.Panel();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Contact = new System.Windows.Forms.Button();
            this.ibtn_AboutMe = new FontAwesome.Sharp.IconButton();
            this.ibtn_ScreenWaker = new FontAwesome.Sharp.IconButton();
            this.ibtn_Makro = new FontAwesome.Sharp.IconButton();
            this.btnAutoCliker = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelSideMenuAboutMe.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.ibtn_Exit);
            this.panelSideMenu.Controls.Add(this.panelSideMenuAboutMe);
            this.panelSideMenu.Controls.Add(this.ibtn_AboutMe);
            this.panelSideMenu.Controls.Add(this.ibtn_ScreenWaker);
            this.panelSideMenu.Controls.Add(this.ibtn_Makro);
            this.panelSideMenu.Controls.Add(this.btnAutoCliker);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 548);
            this.panelSideMenu.TabIndex = 4;
            // 
            // ibtn_Exit
            // 
            this.ibtn_Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_Exit.FlatAppearance.BorderSize = 0;
            this.ibtn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Exit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtn_Exit.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.ibtn_Exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_Exit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtn_Exit.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_Exit.IconSize = 32;
            this.ibtn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Exit.Location = new System.Drawing.Point(0, 470);
            this.ibtn_Exit.Name = "ibtn_Exit";
            this.ibtn_Exit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_Exit.Rotation = 0D;
            this.ibtn_Exit.Size = new System.Drawing.Size(250, 75);
            this.ibtn_Exit.TabIndex = 8;
            this.ibtn_Exit.Text = "Exit";
            this.ibtn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_Exit.UseVisualStyleBackColor = true;
            this.ibtn_Exit.Click += new System.EventHandler(this.ibtn_Exit_Click);
            // 
            // panelSideMenuAboutMe
            // 
            this.panelSideMenuAboutMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.panelSideMenuAboutMe.Controls.Add(this.btn_Report);
            this.panelSideMenuAboutMe.Controls.Add(this.btn_Contact);
            this.panelSideMenuAboutMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSideMenuAboutMe.Location = new System.Drawing.Point(0, 400);
            this.panelSideMenuAboutMe.Name = "panelSideMenuAboutMe";
            this.panelSideMenuAboutMe.Size = new System.Drawing.Size(250, 70);
            this.panelSideMenuAboutMe.TabIndex = 7;
            // 
            // btn_Report
            // 
            this.btn_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Report.Location = new System.Drawing.Point(0, 35);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(250, 35);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click_1);
            // 
            // btn_Contact
            // 
            this.btn_Contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Contact.FlatAppearance.BorderSize = 0;
            this.btn_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contact.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Contact.Location = new System.Drawing.Point(0, 0);
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.Size = new System.Drawing.Size(250, 35);
            this.btn_Contact.TabIndex = 0;
            this.btn_Contact.Text = "Contact";
            this.btn_Contact.UseVisualStyleBackColor = true;
            this.btn_Contact.Click += new System.EventHandler(this.btn_Contact_Click_1);
            // 
            // ibtn_AboutMe
            // 
            this.ibtn_AboutMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_AboutMe.FlatAppearance.BorderSize = 0;
            this.ibtn_AboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_AboutMe.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtn_AboutMe.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.ibtn_AboutMe.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_AboutMe.IconChar = FontAwesome.Sharp.IconChar.Lightbulb;
            this.ibtn_AboutMe.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_AboutMe.IconSize = 32;
            this.ibtn_AboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_AboutMe.Location = new System.Drawing.Point(0, 325);
            this.ibtn_AboutMe.Name = "ibtn_AboutMe";
            this.ibtn_AboutMe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_AboutMe.Rotation = 0D;
            this.ibtn_AboutMe.Size = new System.Drawing.Size(250, 75);
            this.ibtn_AboutMe.TabIndex = 6;
            this.ibtn_AboutMe.Text = "About Me";
            this.ibtn_AboutMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_AboutMe.UseVisualStyleBackColor = true;
            this.ibtn_AboutMe.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ibtn_ScreenWaker
            // 
            this.ibtn_ScreenWaker.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_ScreenWaker.FlatAppearance.BorderSize = 0;
            this.ibtn_ScreenWaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_ScreenWaker.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtn_ScreenWaker.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_ScreenWaker.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_ScreenWaker.IconChar = FontAwesome.Sharp.IconChar.MousePointer;
            this.ibtn_ScreenWaker.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_ScreenWaker.IconSize = 32;
            this.ibtn_ScreenWaker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_ScreenWaker.Location = new System.Drawing.Point(0, 250);
            this.ibtn_ScreenWaker.Name = "ibtn_ScreenWaker";
            this.ibtn_ScreenWaker.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_ScreenWaker.Rotation = 0D;
            this.ibtn_ScreenWaker.Size = new System.Drawing.Size(250, 75);
            this.ibtn_ScreenWaker.TabIndex = 5;
            this.ibtn_ScreenWaker.Text = "Screen Waker";
            this.ibtn_ScreenWaker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_ScreenWaker.UseVisualStyleBackColor = true;
            this.ibtn_ScreenWaker.Click += new System.EventHandler(this.ibtn_ScreenWaker_Click_1);
            // 
            // ibtn_Makro
            // 
            this.ibtn_Makro.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_Makro.FlatAppearance.BorderSize = 0;
            this.ibtn_Makro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_Makro.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibtn_Makro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_Makro.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtn_Makro.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            this.ibtn_Makro.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtn_Makro.IconSize = 32;
            this.ibtn_Makro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Makro.Location = new System.Drawing.Point(0, 175);
            this.ibtn_Makro.Name = "ibtn_Makro";
            this.ibtn_Makro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_Makro.Rotation = 0D;
            this.ibtn_Makro.Size = new System.Drawing.Size(250, 75);
            this.ibtn_Makro.TabIndex = 2;
            this.ibtn_Makro.Text = "Makro";
            this.ibtn_Makro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_Makro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_Makro.UseVisualStyleBackColor = true;
            this.ibtn_Makro.Click += new System.EventHandler(this.ibtn_Makro_Click);
            // 
            // btnAutoCliker
            // 
            this.btnAutoCliker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutoCliker.FlatAppearance.BorderSize = 0;
            this.btnAutoCliker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoCliker.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnAutoCliker.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoCliker.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAutoCliker.IconChar = FontAwesome.Sharp.IconChar.Mouse;
            this.btnAutoCliker.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAutoCliker.IconSize = 32;
            this.btnAutoCliker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoCliker.Location = new System.Drawing.Point(0, 100);
            this.btnAutoCliker.Name = "btnAutoCliker";
            this.btnAutoCliker.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAutoCliker.Rotation = 0D;
            this.btnAutoCliker.Size = new System.Drawing.Size(250, 75);
            this.btnAutoCliker.TabIndex = 1;
            this.btnAutoCliker.Text = "Auto Cliker";
            this.btnAutoCliker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoCliker.UseVisualStyleBackColor = true;
            this.btnAutoCliker.Click += new System.EventHandler(this.btnAutoCliker_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(250, 100);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.panelChildForm.Controls.Add(this.labelDate);
            this.panelChildForm.Controls.Add(this.labelTime);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(746, 548);
            this.panelChildForm.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Location = new System.Drawing.Point(219, 293);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(79, 32);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDate.Location = new System.Drawing.Point(219, 325);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 32);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 548);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenuAboutMe.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton ibtn_Makro;
        private FontAwesome.Sharp.IconButton btnAutoCliker;
        private FontAwesome.Sharp.IconButton ibtn_Exit;
        private System.Windows.Forms.Panel panelSideMenuAboutMe;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Contact;
        private FontAwesome.Sharp.IconButton ibtn_AboutMe;
        private FontAwesome.Sharp.IconButton ibtn_ScreenWaker;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
    }
}

