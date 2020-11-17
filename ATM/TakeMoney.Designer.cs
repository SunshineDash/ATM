namespace ATM
{
    partial class TakeMoney
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
            this.fiveRubles = new System.Windows.Forms.Button();
            this.tenRubles = new System.Windows.Forms.Button();
            this.twentyRubles = new System.Windows.Forms.Button();
            this.fifthRubles = new System.Windows.Forms.Button();
            this.hundredRubles = new System.Windows.Forms.Button();
            this.fiveHundredRubles = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fiveRubles
            // 
            this.fiveRubles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveRubles.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveRubles.Location = new System.Drawing.Point(19, 79);
            this.fiveRubles.Name = "fiveRubles";
            this.fiveRubles.Size = new System.Drawing.Size(150, 71);
            this.fiveRubles.TabIndex = 0;
            this.fiveRubles.Text = "5 Rubles";
            this.fiveRubles.UseVisualStyleBackColor = true;
            this.fiveRubles.Click += new System.EventHandler(this.fiveRubles_Click);
            // 
            // tenRubles
            // 
            this.tenRubles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenRubles.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenRubles.Location = new System.Drawing.Point(19, 158);
            this.tenRubles.Name = "tenRubles";
            this.tenRubles.Size = new System.Drawing.Size(150, 71);
            this.tenRubles.TabIndex = 1;
            this.tenRubles.Text = "10 Rubles";
            this.tenRubles.UseVisualStyleBackColor = true;
            this.tenRubles.Click += new System.EventHandler(this.tenRubles_Click);
            // 
            // twentyRubles
            // 
            this.twentyRubles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twentyRubles.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twentyRubles.Location = new System.Drawing.Point(19, 235);
            this.twentyRubles.Name = "twentyRubles";
            this.twentyRubles.Size = new System.Drawing.Size(150, 71);
            this.twentyRubles.TabIndex = 2;
            this.twentyRubles.Text = "20 rubles";
            this.twentyRubles.UseVisualStyleBackColor = true;
            this.twentyRubles.Click += new System.EventHandler(this.twentyRubles_Click);
            // 
            // fifthRubles
            // 
            this.fifthRubles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fifthRubles.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fifthRubles.Location = new System.Drawing.Point(487, 79);
            this.fifthRubles.Name = "fifthRubles";
            this.fifthRubles.Size = new System.Drawing.Size(150, 71);
            this.fifthRubles.TabIndex = 3;
            this.fifthRubles.Text = "50 rubles";
            this.fifthRubles.UseVisualStyleBackColor = true;
            this.fifthRubles.Click += new System.EventHandler(this.fifthRubles_Click);
            // 
            // hundredRubles
            // 
            this.hundredRubles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hundredRubles.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hundredRubles.Location = new System.Drawing.Point(487, 158);
            this.hundredRubles.Name = "hundredRubles";
            this.hundredRubles.Size = new System.Drawing.Size(150, 71);
            this.hundredRubles.TabIndex = 4;
            this.hundredRubles.Text = "100 rubles";
            this.hundredRubles.UseVisualStyleBackColor = true;
            this.hundredRubles.Click += new System.EventHandler(this.hundredRubles_Click);
            // 
            // fiveHundredRubles
            // 
            this.fiveHundredRubles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveHundredRubles.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveHundredRubles.Location = new System.Drawing.Point(487, 235);
            this.fiveHundredRubles.Name = "fiveHundredRubles";
            this.fiveHundredRubles.Size = new System.Drawing.Size(150, 71);
            this.fiveHundredRubles.TabIndex = 5;
            this.fiveHundredRubles.Text = "500 rubles";
            this.fiveHundredRubles.UseVisualStyleBackColor = true;
            this.fiveHundredRubles.Click += new System.EventHandler(this.fiveHundredRubles_Click);
            // 
            // infoBox
            // 
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBox.Location = new System.Drawing.Point(175, 144);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(306, 20);
            this.infoBox.TabIndex = 6;
            this.infoBox.Text = "Input count";
            this.infoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(175, 235);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 71);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.Location = new System.Drawing.Point(331, 235);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(150, 71);
            this.doneButton.TabIndex = 8;
            this.doneButton.Text = "Input";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(175, 179);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(306, 27);
            this.inputBox.TabIndex = 9;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // TakeMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 331);
            this.ControlBox = false;
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.fiveHundredRubles);
            this.Controls.Add(this.hundredRubles);
            this.Controls.Add(this.fifthRubles);
            this.Controls.Add(this.twentyRubles);
            this.Controls.Add(this.tenRubles);
            this.Controls.Add(this.fiveRubles);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TakeMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TakeMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fiveRubles;
        private System.Windows.Forms.Button tenRubles;
        private System.Windows.Forms.Button twentyRubles;
        private System.Windows.Forms.Button fifthRubles;
        private System.Windows.Forms.Button hundredRubles;
        private System.Windows.Forms.Button fiveHundredRubles;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox inputBox;
    }
}