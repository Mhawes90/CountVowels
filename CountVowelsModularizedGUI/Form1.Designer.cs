namespace CountVowelsModularizedGUI
{
    partial class CountVowelsForm
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
            this.StartCountButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DirectionLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.VowelOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartCountButton
            // 
            this.StartCountButton.AutoSize = true;
            this.StartCountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCountButton.Location = new System.Drawing.Point(280, 373);
            this.StartCountButton.Name = "StartCountButton";
            this.StartCountButton.Size = new System.Drawing.Size(298, 47);
            this.StartCountButton.TabIndex = 0;
            this.StartCountButton.Text = "Count The Vowels!";
            this.StartCountButton.UseVisualStyleBackColor = true;
            this.StartCountButton.Click += new System.EventHandler(this.StartCountButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(226, 59);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(430, 44);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Count Vowels Program";
            // 
            // DirectionLabel
            // 
            this.DirectionLabel.AutoSize = true;
            this.DirectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectionLabel.Location = new System.Drawing.Point(69, 155);
            this.DirectionLabel.Name = "DirectionLabel";
            this.DirectionLabel.Size = new System.Drawing.Size(386, 37);
            this.DirectionLabel.TabIndex = 2;
            this.DirectionLabel.Text = "String to count vowels for:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.Location = new System.Drawing.Point(76, 217);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(691, 122);
            this.InputTextBox.TabIndex = 3;
            // 
            // VowelOutputLabel
            // 
            this.VowelOutputLabel.AutoSize = true;
            this.VowelOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VowelOutputLabel.Location = new System.Drawing.Point(135, 481);
            this.VowelOutputLabel.Name = "VowelOutputLabel";
            this.VowelOutputLabel.Size = new System.Drawing.Size(413, 37);
            this.VowelOutputLabel.TabIndex = 4;
            this.VowelOutputLabel.Text = "Number of vowels in string: ";
            // 
            // CountVowelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(868, 606);
            this.Controls.Add(this.VowelOutputLabel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.DirectionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StartCountButton);
            this.Name = "CountVowelsForm";
            this.Text = "Count Vowels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartCountButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DirectionLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label VowelOutputLabel;
    }
}

