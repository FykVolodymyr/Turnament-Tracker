namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeLable = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLable = new System.Windows.Forms.Label();
            this.placeNameLable = new System.Windows.Forms.Label();
            this.prizeAmountLable = new System.Windows.Forms.Label();
            this.prizePercentageLable = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.priceAmountValue = new System.Windows.Forms.TextBox();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.orLable = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeLable
            // 
            this.createPrizeLable.AutoSize = true;
            this.createPrizeLable.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createPrizeLable.Location = new System.Drawing.Point(12, 9);
            this.createPrizeLable.Name = "createPrizeLable";
            this.createPrizeLable.Size = new System.Drawing.Size(267, 62);
            this.createPrizeLable.TabIndex = 1;
            this.createPrizeLable.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(450, 99);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(268, 43);
            this.placeNumberValue.TabIndex = 23;
            this.placeNumberValue.TextChanged += new System.EventHandler(this.placeNumberValue_TextChanged);
            // 
            // placeNumberLable
            // 
            this.placeNumberLable.AutoSize = true;
            this.placeNumberLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.placeNumberLable.Location = new System.Drawing.Point(12, 96);
            this.placeNumberLable.Name = "placeNumberLable";
            this.placeNumberLable.Size = new System.Drawing.Size(230, 46);
            this.placeNumberLable.TabIndex = 22;
            this.placeNumberLable.Text = "Place Number";
            // 
            // placeNameLable
            // 
            this.placeNameLable.AutoSize = true;
            this.placeNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.placeNameLable.Location = new System.Drawing.Point(12, 167);
            this.placeNameLable.Name = "placeNameLable";
            this.placeNameLable.Size = new System.Drawing.Size(196, 46);
            this.placeNameLable.TabIndex = 30;
            this.placeNameLable.Text = "Place Name";
            // 
            // prizeAmountLable
            // 
            this.prizeAmountLable.AutoSize = true;
            this.prizeAmountLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizeAmountLable.Location = new System.Drawing.Point(12, 238);
            this.prizeAmountLable.Name = "prizeAmountLable";
            this.prizeAmountLable.Size = new System.Drawing.Size(222, 46);
            this.prizeAmountLable.TabIndex = 31;
            this.prizeAmountLable.Text = "Prize Amount";
            // 
            // prizePercentageLable
            // 
            this.prizePercentageLable.AutoSize = true;
            this.prizePercentageLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.prizePercentageLable.Location = new System.Drawing.Point(12, 380);
            this.prizePercentageLable.Name = "prizePercentageLable";
            this.prizePercentageLable.Size = new System.Drawing.Size(269, 46);
            this.prizePercentageLable.TabIndex = 32;
            this.prizePercentageLable.Text = "Prize Percentage";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(450, 170);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(268, 43);
            this.placeNameValue.TabIndex = 33;
            this.placeNameValue.TextChanged += new System.EventHandler(this.placeNameValue_TextChanged);
            // 
            // priceAmountValue
            // 
            this.priceAmountValue.Location = new System.Drawing.Point(450, 241);
            this.priceAmountValue.Name = "priceAmountValue";
            this.priceAmountValue.Size = new System.Drawing.Size(268, 43);
            this.priceAmountValue.TabIndex = 34;
            this.priceAmountValue.TextChanged += new System.EventHandler(this.priceAmountValue_TextChanged);
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(450, 383);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(268, 43);
            this.prizePercentageValue.TabIndex = 35;
            this.prizePercentageValue.TextChanged += new System.EventHandler(this.prizePercentageValue_TextChanged);
            // 
            // orLable
            // 
            this.orLable.AutoSize = true;
            this.orLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLable.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.orLable.Location = new System.Drawing.Point(308, 309);
            this.orLable.Name = "orLable";
            this.orLable.Size = new System.Drawing.Size(80, 46);
            this.orLable.TabIndex = 36;
            this.orLable.Text = "-or-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(118)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.createPrizeButton.Location = new System.Drawing.Point(186, 466);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(317, 57);
            this.createPrizeButton.TabIndex = 37;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 1041);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLable);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.priceAmountValue);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.prizePercentageLable);
            this.Controls.Add(this.prizeAmountLable);
            this.Controls.Add(this.placeNameLable);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLable);
            this.Controls.Add(this.createPrizeLable);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLable;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLable;
        private System.Windows.Forms.Label placeNameLable;
        private System.Windows.Forms.Label prizeAmountLable;
        private System.Windows.Forms.Label prizePercentageLable;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.TextBox priceAmountValue;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label orLable;
        private System.Windows.Forms.Button createPrizeButton;
    }
}