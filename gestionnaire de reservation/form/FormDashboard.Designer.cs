namespace gestionnaire_de_reservation
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdmins = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlSalle1 = new gestionnaire_de_reservation.UserControlSalle();
            this.userControlClient1 = new gestionnaire_de_reservation.User_Control.UserControlClient();
            this.userControlAdmins1 = new gestionnaire_de_reservation.UserControlAdmins();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonAdmins);
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 0;
            // 
            // buttonAdmins
            // 
            this.buttonAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdmins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmins.FlatAppearance.BorderSize = 0;
            this.buttonAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmins.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdmins.Image = global::gestionnaire_de_reservation.Properties.Resources.icons8_admin_32;
            this.buttonAdmins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmins.Location = new System.Drawing.Point(45, 565);
            this.buttonAdmins.Name = "buttonAdmins";
            this.buttonAdmins.Size = new System.Drawing.Size(155, 71);
            this.buttonAdmins.TabIndex = 5;
            this.buttonAdmins.Text = " Admins\r\n";
            this.buttonAdmins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdmins.UseVisualStyleBackColor = false;
            this.buttonAdmins.Click += new System.EventHandler(this.buttonAdmins_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(29, 282);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 75);
            this.panelSlide.TabIndex = 0;
            // 
            // buttonRoom
            // 
            this.buttonRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRoom.Image = global::gestionnaire_de_reservation.Properties.Resources.icons8_rooms_32;
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(45, 417);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(159, 75);
            this.buttonRoom.TabIndex = 3;
            this.buttonRoom.Text = " Salles";
            this.buttonRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoom.UseVisualStyleBackColor = false;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReservation.Image = global::gestionnaire_de_reservation.Properties.Resources.icons8_reservation_32;
            this.buttonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.Location = new System.Drawing.Point(45, 488);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(155, 71);
            this.buttonReservation.TabIndex = 4;
            this.buttonReservation.Text = "Reservations";
            this.buttonReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClient.Image = global::gestionnaire_de_reservation.Properties.Resources.icons8_group_50;
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(45, 346);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(155, 75);
            this.buttonClient.TabIndex = 2;
            this.buttonClient.Text = "Clients\r\n";
            this.buttonClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDashboard.Image = global::gestionnaire_de_reservation.Properties.Resources.icons8_dashboard_48;
            this.buttonDashboard.Location = new System.Drawing.Point(45, 284);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(155, 73);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Tableau de board";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 241);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionnaire De Reservations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::gestionnaire_de_reservation.Properties.Resources.icons8_event_management_96;
            this.pictureBox1.Location = new System.Drawing.Point(45, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 163);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenue";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.linkLabelLogout);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1166, 84);
            this.panel5.TabIndex = 0;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogout.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelLogout.Location = new System.Drawing.Point(1043, 53);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(108, 18);
            this.linkLabelLogout.TabIndex = 0;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Déconnexion";
            this.linkLabelLogout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControlAdmins1);
            this.panel2.Controls.Add(this.userControlSalle1);
            this.panel2.Controls.Add(this.userControlClient1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 557);
            this.panel2.TabIndex = 1;
            // 
            // userControlSalle1
            // 
            this.userControlSalle1.AutoSize = true;
            this.userControlSalle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userControlSalle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSalle1.Location = new System.Drawing.Point(0, 0);
            this.userControlSalle1.Name = "userControlSalle1";
            this.userControlSalle1.Size = new System.Drawing.Size(1166, 557);
            this.userControlSalle1.TabIndex = 0;
            this.userControlSalle1.Visible = false;
            // 
            // userControlClient1
            // 
            this.userControlClient1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userControlClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClient1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlClient1.Location = new System.Drawing.Point(0, 0);
            this.userControlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1166, 557);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            // 
            // userControlAdmins1
            // 
            this.userControlAdmins1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userControlAdmins1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAdmins1.Location = new System.Drawing.Point(0, 0);
            this.userControlAdmins1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControlAdmins1.Name = "userControlAdmins1";
            this.userControlAdmins1.Size = new System.Drawing.Size(1166, 557);
            this.userControlAdmins1.TabIndex = 0;
            this.userControlAdmins1.Visible = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de resevation | Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel2;
        private User_Control.UserControlClient userControlClient1;
        private UserControlSalle userControlSalle1;
        private System.Windows.Forms.Button buttonAdmins;
        private UserControlAdmins userControlAdmins1;
    }
}