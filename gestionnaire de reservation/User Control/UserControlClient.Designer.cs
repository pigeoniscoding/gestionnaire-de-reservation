namespace gestionnaire_de_reservation.User_Control
{
    partial class UserControlClient
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDeleteClient = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxBirthDay = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxEmail1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageUpdateAndDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageUpdateAndDeleteClient);
            this.tabControlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClient.Location = new System.Drawing.Point(0, 0);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1102, 462);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.button1);
            this.tabPageSearchClient.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchClient.Controls.Add(this.textBoxSearchEmail);
            this.tabPageSearchClient.Controls.Add(this.label2);
            this.tabPageSearchClient.Controls.Add(this.label1);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1094, 432);
            this.tabPageSearchClient.TabIndex = 0;
            this.tabPageSearchClient.Text = "Recherche";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(528, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewClient.Location = new System.Drawing.Point(103, 229);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(890, 156);
            this.dataGridViewClient.TabIndex = 3;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_personnes";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nom";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Prenom";
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Adress_mail";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Numero_de_telephone";
            this.Column5.HeaderText = "Numero";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Date_de_naissance";
            this.Column6.HeaderText = "Date de naissance";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // textBoxSearchEmail
            // 
            this.textBoxSearchEmail.Location = new System.Drawing.Point(67, 105);
            this.textBoxSearchEmail.Name = "textBoxSearchEmail";
            this.textBoxSearchEmail.Size = new System.Drawing.Size(368, 23);
            this.textBoxSearchEmail.TabIndex = 2;
            this.textBoxSearchEmail.TextChanged += new System.EventHandler(this.textBoxSearchEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageUpdateAndDeleteClient
            // 
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label8);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label7);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxPhone);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxBirthDay);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxEmail1);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label6);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxLastName1);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label5);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxFirstName1);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label4);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label3);
            this.tabPageUpdateAndDeleteClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteClient.Name = "tabPageUpdateAndDeleteClient";
            this.tabPageUpdateAndDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteClient.Size = new System.Drawing.Size(1023, 387);
            this.tabPageUpdateAndDeleteClient.TabIndex = 1;
            this.tabPageUpdateAndDeleteClient.Text = "Modifier | supprimer";
            this.tabPageUpdateAndDeleteClient.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(35, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telephone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(493, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date de naissance";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(38, 211);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(368, 23);
            this.textBoxPhone.TabIndex = 12;
            // 
            // textBoxBirthDay
            // 
            this.textBoxBirthDay.Location = new System.Drawing.Point(496, 211);
            this.textBoxBirthDay.Name = "textBoxBirthDay";
            this.textBoxBirthDay.Size = new System.Drawing.Size(368, 23);
            this.textBoxBirthDay.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(254, 288);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(166, 32);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Location = new System.Drawing.Point(52, 288);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(166, 32);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Modifier";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxEmail1
            // 
            this.textBoxEmail1.Location = new System.Drawing.Point(287, 71);
            this.textBoxEmail1.Name = "textBoxEmail1";
            this.textBoxEmail1.Size = new System.Drawing.Size(368, 23);
            this.textBoxEmail1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(284, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Location = new System.Drawing.Point(505, 135);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(368, 23);
            this.textBoxLastName1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(35, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prenom";
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Location = new System.Drawing.Point(38, 135);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(368, 23);
            this.textBoxFirstName1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(502, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ajouter un Client";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageUpdateAndDeleteClient.ResumeLayout(false);
            this.tabPageUpdateAndDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxSearchEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxBirthDay;
    }
}
