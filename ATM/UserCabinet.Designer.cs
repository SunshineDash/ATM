namespace ATM
{
    partial class UserCabinet
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
            this.balanceButton = new System.Windows.Forms.Button();
            this.giveMoneyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // balanceButton
            // 
            this.balanceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.balanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.balanceButton.Location = new System.Drawing.Point(12, 81);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(161, 87);
            this.balanceButton.TabIndex = 0;
            this.balanceButton.Text = "View your balance";
            this.balanceButton.UseVisualStyleBackColor = true;
            this.balanceButton.Click += new System.EventHandler(this.balanceButton_Click);
            // 
            // giveMoneyButton
            // 
            this.giveMoneyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.giveMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giveMoneyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.giveMoneyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.giveMoneyButton.Location = new System.Drawing.Point(179, 81);
            this.giveMoneyButton.Name = "giveMoneyButton";
            this.giveMoneyButton.Size = new System.Drawing.Size(145, 87);
            this.giveMoneyButton.TabIndex = 1;
            this.giveMoneyButton.Text = "Take money";
            this.giveMoneyButton.UseVisualStyleBackColor = true;
            this.giveMoneyButton.Click += new System.EventHandler(this.giveMoneyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(116, 174);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 61);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Return the card";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserCabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 254);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.giveMoneyButton);
            this.Controls.Add(this.balanceButton);
            this.Name = "UserCabinet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserCabinet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button balanceButton;
        private System.Windows.Forms.Button giveMoneyButton;
        private System.Windows.Forms.Button exitButton;
    }
}