namespace gestionnaire_de_reservation
{
    partial class UserControlAdmins
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageSearchAdmin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
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
            this.textBoxPhoneAdmin = new System.Windows.Forms.TextBox();
            this.textBoxBirthDayAdmin = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxEmailAdmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLastNameAdmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirstNameAdmin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageAddAdmin = new System.Windows.Forms.TabPage();
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonChercheNouvAdmin = new System.Windows.Forms.Button();
            this.dataGridViewAdminAdd = new System.Windows.Forms.DataGridView();
            this.textBoxEmailNovAdmin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdd4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageSearchAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.tabPageUpdateAndDeleteClient.SuspendLayout();
            this.tabPageAddAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAdmin.Controls.Add(this.tabPageSearchAdmin);
            this.tabControlAdmin.Controls.Add(this.tabPageUpdateAndDeleteClient);
            this.tabControlAdmin.Controls.Add(this.tabPageAddAdmin);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1102, 462);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageSearchAdmin
            // 
            this.tabPageSearchAdmin.Controls.Add(this.button1);
            this.tabPageSearchAdmin.Controls.Add(this.dataGridViewAdmin);
            this.tabPageSearchAdmin.Controls.Add(this.textBoxSearchEmail);
            this.tabPageSearchAdmin.Controls.Add(this.label2);
            this.tabPageSearchAdmin.Controls.Add(this.label1);
            this.tabPageSearchAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSearchAdmin.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchAdmin.Name = "tabPageSearchAdmin";
            this.tabPageSearchAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchAdmin.Size = new System.Drawing.Size(1094, 432);
            this.tabPageSearchAdmin.TabIndex = 0;
            this.tabPageSearchAdmin.Text = "Recherche";
            this.tabPageSearchAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(527, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Chercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(66, 207);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(890, 156);
            this.dataGridViewAdmin.TabIndex = 3;
            this.dataGridViewAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellClick);
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
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
            this.textBoxSearchEmail.Location = new System.Drawing.Point(66, 106);
            this.textBoxSearchEmail.Name = "textBoxSearchEmail";
            this.textBoxSearchEmail.Size = new System.Drawing.Size(368, 23);
            this.textBoxSearchEmail.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chercher un Admin\r\n";
            // 
            // tabPageUpdateAndDeleteClient
            // 
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label8);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label7);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxPhoneAdmin);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxBirthDayAdmin);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxEmailAdmin);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label6);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxLastNameAdmin);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label5);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.textBoxFirstNameAdmin);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label4);
            this.tabPageUpdateAndDeleteClient.Controls.Add(this.label3);
            this.tabPageUpdateAndDeleteClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteClient.Name = "tabPageUpdateAndDeleteClient";
            this.tabPageUpdateAndDeleteClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteClient.Size = new System.Drawing.Size(1094, 432);
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
            // textBoxPhoneAdmin
            // 
            this.textBoxPhoneAdmin.Location = new System.Drawing.Point(38, 211);
            this.textBoxPhoneAdmin.Name = "textBoxPhoneAdmin";
            this.textBoxPhoneAdmin.Size = new System.Drawing.Size(368, 23);
            this.textBoxPhoneAdmin.TabIndex = 12;
            // 
            // textBoxBirthDayAdmin
            // 
            this.textBoxBirthDayAdmin.Location = new System.Drawing.Point(496, 211);
            this.textBoxBirthDayAdmin.Name = "textBoxBirthDayAdmin";
            this.textBoxBirthDayAdmin.Size = new System.Drawing.Size(368, 23);
            this.textBoxBirthDayAdmin.TabIndex = 11;
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
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            // textBoxEmailAdmin
            // 
            this.textBoxEmailAdmin.Location = new System.Drawing.Point(287, 71);
            this.textBoxEmailAdmin.Name = "textBoxEmailAdmin";
            this.textBoxEmailAdmin.Size = new System.Drawing.Size(368, 23);
            this.textBoxEmailAdmin.TabIndex = 8;
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
            // textBoxLastNameAdmin
            // 
            this.textBoxLastNameAdmin.Location = new System.Drawing.Point(505, 135);
            this.textBoxLastNameAdmin.Name = "textBoxLastNameAdmin";
            this.textBoxLastNameAdmin.Size = new System.Drawing.Size(368, 23);
            this.textBoxLastNameAdmin.TabIndex = 6;
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
            // textBoxFirstNameAdmin
            // 
            this.textBoxFirstNameAdmin.Location = new System.Drawing.Point(38, 135);
            this.textBoxFirstNameAdmin.Name = "textBoxFirstNameAdmin";
            this.textBoxFirstNameAdmin.Size = new System.Drawing.Size(368, 23);
            this.textBoxFirstNameAdmin.TabIndex = 4;
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
            this.label3.Size = new System.Drawing.Size(227, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modifier|Supprimer un Admin\r\n";
            // 
            // tabPageAddAdmin
            // 
            this.tabPageAddAdmin.Controls.Add(this.buttonAddAdmin);
            this.tabPageAddAdmin.Controls.Add(this.label11);
            this.tabPageAddAdmin.Controls.Add(this.buttonChercheNouvAdmin);
            this.tabPageAddAdmin.Controls.Add(this.dataGridViewAdminAdd);
            this.tabPageAddAdmin.Controls.Add(this.textBoxEmailNovAdmin);
            this.tabPageAddAdmin.Controls.Add(this.label9);
            this.tabPageAddAdmin.Controls.Add(this.label10);
            this.tabPageAddAdmin.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddAdmin.Name = "tabPageAddAdmin";
            this.tabPageAddAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddAdmin.Size = new System.Drawing.Size(1094, 432);
            this.tabPageAddAdmin.TabIndex = 2;
            this.tabPageAddAdmin.Text = "Ajouter";
            this.tabPageAddAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAddAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddAdmin.Location = new System.Drawing.Point(745, 99);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(166, 32);
            this.buttonAddAdmin.TabIndex = 17;
            this.buttonAddAdmin.Text = "Ajouter";
            this.buttonAddAdmin.UseVisualStyleBackColor = false;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonAddAdmin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(41, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(409, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "(Cherchez l\'utilisateur que vous voulez ajouter comme Admin)";
            // 
            // buttonChercheNouvAdmin
            // 
            this.buttonChercheNouvAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChercheNouvAdmin.FlatAppearance.BorderSize = 0;
            this.buttonChercheNouvAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChercheNouvAdmin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChercheNouvAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonChercheNouvAdmin.Location = new System.Drawing.Point(552, 99);
            this.buttonChercheNouvAdmin.Name = "buttonChercheNouvAdmin";
            this.buttonChercheNouvAdmin.Size = new System.Drawing.Size(166, 32);
            this.buttonChercheNouvAdmin.TabIndex = 15;
            this.buttonChercheNouvAdmin.Text = "Chercher";
            this.buttonChercheNouvAdmin.UseVisualStyleBackColor = false;
            this.buttonChercheNouvAdmin.Click += new System.EventHandler(this.buttonChercheNouvAdmin_Click);
            // 
            // dataGridViewAdminAdd
            // 
            this.dataGridViewAdminAdd.AllowUserToAddRows = false;
            this.dataGridViewAdminAdd.AllowUserToDeleteRows = false;
            this.dataGridViewAdminAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAdminAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAdminAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ColumnAdd4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewAdminAdd.Location = new System.Drawing.Point(127, 232);
            this.dataGridViewAdminAdd.Name = "dataGridViewAdminAdd";
            this.dataGridViewAdminAdd.ReadOnly = true;
            this.dataGridViewAdminAdd.Size = new System.Drawing.Size(890, 156);
            this.dataGridViewAdminAdd.TabIndex = 14;
            this.dataGridViewAdminAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminAdd_CellClick);
            // 
            // textBoxEmailNovAdmin
            // 
            this.textBoxEmailNovAdmin.Location = new System.Drawing.Point(91, 108);
            this.textBoxEmailNovAdmin.Name = "textBoxEmailNovAdmin";
            this.textBoxEmailNovAdmin.Size = new System.Drawing.Size(368, 23);
            this.textBoxEmailNovAdmin.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(88, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(41, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ajouter un Admin\r\n";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_personnes";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ColumnAdd4
            // 
            this.ColumnAdd4.DataPropertyName = "Adress_mail";
            this.ColumnAdd4.HeaderText = "Email";
            this.ColumnAdd4.Name = "ColumnAdd4";
            this.ColumnAdd4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Numero_de_telephone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_de_naissance";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date de naissance";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // UserControlAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "UserControlAdmins";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageSearchAdmin.ResumeLayout(false);
            this.tabPageSearchAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.tabPageUpdateAndDeleteClient.ResumeLayout(false);
            this.tabPageUpdateAndDeleteClient.PerformLayout();
            this.tabPageAddAdmin.ResumeLayout(false);
            this.tabPageAddAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPageSearchAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox textBoxSearchEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhoneAdmin;
        private System.Windows.Forms.TextBox textBoxBirthDayAdmin;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxEmailAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLastNameAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirstNameAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageAddAdmin;
        private System.Windows.Forms.Button buttonChercheNouvAdmin;
        private System.Windows.Forms.DataGridView dataGridViewAdminAdd;
        private System.Windows.Forms.TextBox textBoxEmailNovAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
