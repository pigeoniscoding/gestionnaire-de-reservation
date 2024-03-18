namespace gestionnaire_de_reservation
{
    partial class UserControlSalle
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
            this.tabControlSalle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSearchID = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxID1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxCapacite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxNumerodelasalle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControlSalle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSalle
            // 
            this.tabControlSalle.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlSalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlSalle.Controls.Add(this.tabPage1);
            this.tabControlSalle.Controls.Add(this.tabPage2);
            this.tabControlSalle.Controls.Add(this.tabPage3);
            this.tabControlSalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSalle.ItemSize = new System.Drawing.Size(80, 22);
            this.tabControlSalle.Location = new System.Drawing.Point(36, 14);
            this.tabControlSalle.Name = "tabControlSalle";
            this.tabControlSalle.SelectedIndex = 0;
            this.tabControlSalle.Size = new System.Drawing.Size(1031, 417);
            this.tabControlSalle.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSearchID);
            this.tabPage1.Controls.Add(this.dataGridViewClient);
            this.tabPage1.Controls.Add(this.textBoxSearchID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recherche";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSearchID
            // 
            this.buttonSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearchID.FlatAppearance.BorderSize = 0;
            this.buttonSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearchID.Location = new System.Drawing.Point(488, 81);
            this.buttonSearchID.Name = "buttonSearchID";
            this.buttonSearchID.Size = new System.Drawing.Size(166, 32);
            this.buttonSearchID.TabIndex = 15;
            this.buttonSearchID.Text = "Chercher";
            this.buttonSearchID.UseVisualStyleBackColor = false;
            this.buttonSearchID.Click += new System.EventHandler(this.buttonSearchID_Click);
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
            this.Column4});
            this.dataGridViewClient.Location = new System.Drawing.Point(27, 150);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(636, 194);
            this.dataGridViewClient.TabIndex = 14;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id_Salles";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Numero_de_la_salle";
            this.Column2.HeaderText = "Numero_de_la_salle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Capacite";
            this.Column3.HeaderText = "Capacite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Description";
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBoxSearchID
            // 
            this.textBoxSearchID.Location = new System.Drawing.Point(27, 81);
            this.textBoxSearchID.Name = "textBoxSearchID";
            this.textBoxSearchID.Size = new System.Drawing.Size(368, 23);
            this.textBoxSearchID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chercher une Salle\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxPhone);
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonUpdate);
            this.tabPage2.Controls.Add(this.textBoxID1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxFirstName1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modifier | Supprimer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 23);
            this.textBox1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(53, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Numero de la salle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(463, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Capacite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(53, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Description";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(56, 197);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(778, 59);
            this.textBoxPhone.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(272, 274);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(166, 32);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Location = new System.Drawing.Point(70, 274);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(166, 32);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Modifier";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // textBoxID1
            // 
            this.textBoxID1.Location = new System.Drawing.Point(305, 57);
            this.textBoxID1.Name = "textBoxID1";
            this.textBoxID1.Size = new System.Drawing.Size(368, 23);
            this.textBoxID1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(302, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // textBoxFirstName1
            // 
            this.textBoxFirstName1.Location = new System.Drawing.Point(56, 121);
            this.textBoxFirstName1.Name = "textBoxFirstName1";
            this.textBoxFirstName1.Size = new System.Drawing.Size(368, 23);
            this.textBoxFirstName1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(38, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ajouter un Client";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxCapacite);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxDescription);
            this.tabPage3.Controls.Add(this.buttonAjouter);
            this.tabPage3.Controls.Add(this.textBoxNumerodelasalle);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1023, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ajouter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxCapacite
            // 
            this.textBoxCapacite.Location = new System.Drawing.Point(537, 140);
            this.textBoxCapacite.Name = "textBoxCapacite";
            this.textBoxCapacite.Size = new System.Drawing.Size(368, 23);
            this.textBoxCapacite.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(124, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Numero de la salle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(534, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Capacite";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(124, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(127, 216);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(778, 59);
            this.textBoxDescription.TabIndex = 32;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAjouter.FlatAppearance.BorderSize = 0;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAjouter.Location = new System.Drawing.Point(141, 293);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(166, 32);
            this.buttonAjouter.TabIndex = 30;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // textBoxNumerodelasalle
            // 
            this.textBoxNumerodelasalle.Location = new System.Drawing.Point(127, 140);
            this.textBoxNumerodelasalle.Name = "textBoxNumerodelasalle";
            this.textBoxNumerodelasalle.Size = new System.Drawing.Size(368, 23);
            this.textBoxNumerodelasalle.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(109, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ajouter une Salle";
            // 
            // UserControlSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tabControlSalle);
            this.Name = "UserControlSalle";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlSalle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSalle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSearchID;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxSearchID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxID1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFirstName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxCapacite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxNumerodelasalle;
        private System.Windows.Forms.Label label12;
    }
}
