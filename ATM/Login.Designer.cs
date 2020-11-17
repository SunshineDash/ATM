namespace ATM
{
    partial class Login
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
            this.CardNumberBox = new System.Windows.Forms.TextBox();
            this.PinCodeBox = new System.Windows.Forms.TextBox();
            this.CardNumberInf = new System.Windows.Forms.TextBox();
            this.PinCodeInf = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Validity = new System.Windows.Forms.TextBox();
            this.PinCodeState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CardNumberBox
            // 
            this.CardNumberBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.CardNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumberBox.Location = new System.Drawing.Point(188, 122);
            this.CardNumberBox.MaxLength = 16;
            this.CardNumberBox.Name = "CardNumberBox";
            this.CardNumberBox.Size = new System.Drawing.Size(210, 24);
            this.CardNumberBox.TabIndex = 0;
            this.CardNumberBox.TextChanged += new System.EventHandler(this.CardNumberBox_TextChanged);
            // 
            // PinCodeBox
            // 
            this.PinCodeBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.PinCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PinCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PinCodeBox.Location = new System.Drawing.Point(188, 150);
            this.PinCodeBox.MaxLength = 4;
            this.PinCodeBox.Name = "PinCodeBox";
            this.PinCodeBox.PasswordChar = '*';
            this.PinCodeBox.Size = new System.Drawing.Size(210, 24);
            this.PinCodeBox.TabIndex = 2;
            // 
            // CardNumberInf
            // 
            this.CardNumberInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardNumberInf.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumberInf.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CardNumberInf.Location = new System.Drawing.Point(75, 122);
            this.CardNumberInf.Name = "CardNumberInf";
            this.CardNumberInf.ReadOnly = true;
            this.CardNumberInf.Size = new System.Drawing.Size(107, 21);
            this.CardNumberInf.TabIndex = 3;
            this.CardNumberInf.Text = "Card Number:";
            this.CardNumberInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PinCodeInf
            // 
            this.PinCodeInf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PinCodeInf.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PinCodeInf.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PinCodeInf.Location = new System.Drawing.Point(75, 150);
            this.PinCodeInf.Name = "PinCodeInf";
            this.PinCodeInf.ReadOnly = true;
            this.PinCodeInf.Size = new System.Drawing.Size(107, 21);
            this.PinCodeInf.TabIndex = 4;
            this.PinCodeInf.Text = "Pin Code:";
            this.PinCodeInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginButton.Location = new System.Drawing.Point(404, 122);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(72, 52);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Validity
            // 
            this.Validity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Validity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Validity.ForeColor = System.Drawing.Color.Green;
            this.Validity.Location = new System.Drawing.Point(188, 104);
            this.Validity.Name = "Validity";
            this.Validity.ReadOnly = true;
            this.Validity.Size = new System.Drawing.Size(210, 17);
            this.Validity.TabIndex = 6;
            // 
            // PinCodeState
            // 
            this.PinCodeState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PinCodeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PinCodeState.ForeColor = System.Drawing.Color.Red;
            this.PinCodeState.Location = new System.Drawing.Point(188, 180);
            this.PinCodeState.Name = "PinCodeState";
            this.PinCodeState.ReadOnly = true;
            this.PinCodeState.Size = new System.Drawing.Size(210, 17);
            this.PinCodeState.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 267);
            this.Controls.Add(this.PinCodeState);
            this.Controls.Add(this.Validity);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PinCodeInf);
            this.Controls.Add(this.CardNumberInf);
            this.Controls.Add(this.PinCodeBox);
            this.Controls.Add(this.CardNumberBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardNumberBox;
        private System.Windows.Forms.TextBox PinCodeBox;
        private System.Windows.Forms.TextBox CardNumberInf;
        private System.Windows.Forms.TextBox PinCodeInf;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Validity;
        private System.Windows.Forms.TextBox PinCodeState;
    }
}

