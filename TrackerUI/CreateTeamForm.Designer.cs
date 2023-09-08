namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.selectTeamMemberLable = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLable = new System.Windows.Forms.Label();
            this.createTeamLable = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLable = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLable = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectTeamMemberLable
            // 
            this.selectTeamMemberLable.AutoSize = true;
            this.selectTeamMemberLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.selectTeamMemberLable.Location = new System.Drawing.Point(23, 223);
            this.selectTeamMemberLable.Name = "selectTeamMemberLable";
            this.selectTeamMemberLable.Size = new System.Drawing.Size(335, 46);
            this.selectTeamMemberLable.TabIndex = 15;
            this.selectTeamMemberLable.Text = "Select Team Member";
            this.selectTeamMemberLable.Click += new System.EventHandler(this.selectTeamMemberLable_Click);
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(23, 159);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(392, 43);
            this.teamNameValue.TabIndex = 14;
            this.teamNameValue.TextChanged += new System.EventHandler(this.teamNameValue_TextChanged);
            // 
            // teamNameLable
            // 
            this.teamNameLable.AutoSize = true;
            this.teamNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamNameLable.Location = new System.Drawing.Point(23, 92);
            this.teamNameLable.Name = "teamNameLable";
            this.teamNameLable.Size = new System.Drawing.Size(197, 46);
            this.teamNameLable.TabIndex = 13;
            this.teamNameLable.Text = "Team Name";
            this.teamNameLable.Click += new System.EventHandler(this.teamNameLable_Click);
            // 
            // createTeamLable
            // 
            this.createTeamLable.AutoSize = true;
            this.createTeamLable.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTeamLable.Location = new System.Drawing.Point(23, 9);
            this.createTeamLable.Name = "createTeamLable";
            this.createTeamLable.Size = new System.Drawing.Size(272, 62);
            this.createTeamLable.TabIndex = 12;
            this.createTeamLable.Text = "Create Team";
            this.createTeamLable.Click += new System.EventHandler(this.createTeamLable_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(118)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.addMemberButton.Location = new System.Drawing.Point(72, 355);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(223, 57);
            this.addMemberButton.TabIndex = 18;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(23, 290);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(392, 45);
            this.selectTeamMemberDropDown.TabIndex = 17;
            this.selectTeamMemberDropDown.SelectedIndexChanged += new System.EventHandler(this.selectTeamMemberDropDown_SelectedIndexChanged);
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneLable);
            this.addNewMemberGroupBox.Controls.Add(this.emailValue);
            this.addNewMemberGroupBox.Controls.Add(this.emailLable);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLable);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLable);
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(23, 441);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(658, 485);
            this.addNewMemberGroupBox.TabIndex = 19;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            this.addNewMemberGroupBox.Enter += new System.EventHandler(this.addNewMemberGroupBox_Enter);
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(261, 69);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(268, 43);
            this.firstNameValue.TabIndex = 21;
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.firstNameLable.Location = new System.Drawing.Point(19, 67);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(181, 46);
            this.firstNameLable.TabIndex = 20;
            this.firstNameLable.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(261, 158);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(268, 43);
            this.lastNameValue.TabIndex = 23;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lastNameLable.Location = new System.Drawing.Point(19, 156);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(177, 46);
            this.lastNameLable.TabIndex = 22;
            this.lastNameLable.Text = "Last Name";
            this.lastNameLable.Click += new System.EventHandler(this.lastNameLable_Click);
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(261, 247);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(268, 43);
            this.emailValue.TabIndex = 25;
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.emailLable.Location = new System.Drawing.Point(23, 245);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(99, 46);
            this.emailLable.TabIndex = 24;
            this.emailLable.Text = "Email";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(261, 336);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(268, 43);
            this.cellphoneValue.TabIndex = 27;
            // 
            // cellphoneLable
            // 
            this.cellphoneLable.AutoSize = true;
            this.cellphoneLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphoneLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cellphoneLable.Location = new System.Drawing.Point(19, 334);
            this.cellphoneLable.Name = "cellphoneLable";
            this.cellphoneLable.Size = new System.Drawing.Size(171, 46);
            this.cellphoneLable.TabIndex = 26;
            this.cellphoneLable.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(118)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createMemberButton.Location = new System.Drawing.Point(158, 406);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(317, 57);
            this.createMemberButton.TabIndex = 20;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(708, 456);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(452, 448);
            this.teamMembersListBox.TabIndex = 20;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(118)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(1183, 632);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(186, 100);
            this.deleteSelectedMemberButton.TabIndex = 21;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(118)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createTeamButton.Location = new System.Drawing.Point(523, 945);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(317, 57);
            this.createTeamButton.TabIndex = 28;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 1041);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLable);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLable);
            this.Controls.Add(this.createTeamLable);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectTeamMemberLable;
        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLable;
        private System.Windows.Forms.Label createTeamLable;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLable;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}