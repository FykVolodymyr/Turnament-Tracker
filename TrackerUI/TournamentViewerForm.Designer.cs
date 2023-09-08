namespace TrackerUI
{
    partial class unplayedOnlyCheckbox
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
            this.headerLable = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLable = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLable = new System.Windows.Forms.Label();
            this.teamOneScoreLable = new System.Windows.Forms.Label();
            this.teamOneSocreValue = new System.Windows.Forms.TextBox();
            this.teamTwoSocreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLable = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusLable = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.headerLable.Location = new System.Drawing.Point(32, 9);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(271, 62);
            this.headerLable.TabIndex = 0;
            this.headerLable.Text = "Tournament:";
            this.headerLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tournamentName.Location = new System.Drawing.Point(333, 9);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(189, 62);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLable
            // 
            this.roundLable.AutoSize = true;
            this.roundLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.roundLable.Location = new System.Drawing.Point(32, 96);
            this.roundLable.Name = "roundLable";
            this.roundLable.Size = new System.Drawing.Size(117, 46);
            this.roundLable.TabIndex = 2;
            this.roundLable.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(160, 99);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(362, 45);
            this.roundDropDown.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBox1.Location = new System.Drawing.Point(32, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(257, 50);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Unplayed Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(32, 278);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(490, 335);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneNameLable
            // 
            this.teamOneNameLable.AutoSize = true;
            this.teamOneNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneNameLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamOneNameLable.Location = new System.Drawing.Point(569, 25);
            this.teamOneNameLable.Name = "teamOneNameLable";
            this.teamOneNameLable.Size = new System.Drawing.Size(208, 46);
            this.teamOneNameLable.TabIndex = 6;
            this.teamOneNameLable.Text = "<team one>";
            // 
            // teamOneScoreLable
            // 
            this.teamOneScoreLable.AutoSize = true;
            this.teamOneScoreLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamOneScoreLable.Location = new System.Drawing.Point(569, 101);
            this.teamOneScoreLable.Name = "teamOneScoreLable";
            this.teamOneScoreLable.Size = new System.Drawing.Size(104, 46);
            this.teamOneScoreLable.TabIndex = 7;
            this.teamOneScoreLable.Text = "Score";
            // 
            // teamOneSocreValue
            // 
            this.teamOneSocreValue.Location = new System.Drawing.Point(703, 104);
            this.teamOneSocreValue.Name = "teamOneSocreValue";
            this.teamOneSocreValue.Size = new System.Drawing.Size(106, 43);
            this.teamOneSocreValue.TabIndex = 8;
            // 
            // teamTwoSocreValue
            // 
            this.teamTwoSocreValue.Location = new System.Drawing.Point(703, 340);
            this.teamTwoSocreValue.Name = "teamTwoSocreValue";
            this.teamTwoSocreValue.Size = new System.Drawing.Size(106, 43);
            this.teamTwoSocreValue.TabIndex = 11;
            // 
            // teamTwoScoreLable
            // 
            this.teamTwoScoreLable.AutoSize = true;
            this.teamTwoScoreLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamTwoScoreLable.Location = new System.Drawing.Point(569, 340);
            this.teamTwoScoreLable.Name = "teamTwoScoreLable";
            this.teamTwoScoreLable.Size = new System.Drawing.Size(104, 46);
            this.teamTwoScoreLable.TabIndex = 10;
            this.teamTwoScoreLable.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamTwoName.Location = new System.Drawing.Point(569, 264);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(208, 46);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<team two>";
            this.teamTwoName.Click += new System.EventHandler(this.teamTwoName_Click);
            // 
            // versusLable
            // 
            this.versusLable.AutoSize = true;
            this.versusLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.versusLable.Location = new System.Drawing.Point(722, 185);
            this.versusLable.Name = "versusLable";
            this.versusLable.Size = new System.Drawing.Size(87, 46);
            this.versusLable.TabIndex = 12;
            this.versusLable.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(118)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(863, 188);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(134, 43);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // unplayedOnlyCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 704);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLable);
            this.Controls.Add(this.teamTwoSocreValue);
            this.Controls.Add(this.teamTwoScoreLable);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneSocreValue);
            this.Controls.Add(this.teamOneScoreLable);
            this.Controls.Add(this.teamOneNameLable);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLable);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "unplayedOnlyCheckbox";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLable;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneNameLable;
        private System.Windows.Forms.Label teamOneScoreLable;
        private System.Windows.Forms.TextBox teamOneSocreValue;
        private System.Windows.Forms.TextBox teamTwoSocreValue;
        private System.Windows.Forms.Label teamTwoScoreLable;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusLable;
        private System.Windows.Forms.Button scoreButton;
    }
}

