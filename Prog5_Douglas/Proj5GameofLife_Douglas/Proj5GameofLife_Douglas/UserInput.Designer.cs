namespace Proj5GameofLife_Douglas
{
    partial class UserInput
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
            this.CommLabel = new System.Windows.Forms.Label();
            this.GridSizeLabel = new System.Windows.Forms.Label();
            this.GenNumLabel = new System.Windows.Forms.Label();
            this.MajNumLabel = new System.Windows.Forms.Label();
            this.MimNumLabel = new System.Windows.Forms.Label();
            this.FlyNumLabel = new System.Windows.Forms.Label();
            this.GridSizeInput = new System.Windows.Forms.TextBox();
            this.GenNumInput = new System.Windows.Forms.TextBox();
            this.MajNumInput = new System.Windows.Forms.TextBox();
            this.MimNumInput = new System.Windows.Forms.TextBox();
            this.FlyNumInput = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommLabel
            // 
            this.CommLabel.AutoSize = true;
            this.CommLabel.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommLabel.Location = new System.Drawing.Point(43, 34);
            this.CommLabel.Name = "CommLabel";
            this.CommLabel.Size = new System.Drawing.Size(302, 29);
            this.CommLabel.TabIndex = 0;
            this.CommLabel.Text = "Enter desired values for game\r\n";
            // 
            // GridSizeLabel
            // 
            this.GridSizeLabel.AutoSize = true;
            this.GridSizeLabel.Location = new System.Drawing.Point(48, 90);
            this.GridSizeLabel.Name = "GridSizeLabel";
            this.GridSizeLabel.Size = new System.Drawing.Size(83, 17);
            this.GridSizeLabel.TabIndex = 1;
            this.GridSizeLabel.Text = "Size of grid:";
            // 
            // GenNumLabel
            // 
            this.GenNumLabel.AutoSize = true;
            this.GenNumLabel.Location = new System.Drawing.Point(48, 120);
            this.GenNumLabel.Name = "GenNumLabel";
            this.GenNumLabel.Size = new System.Drawing.Size(157, 17);
            this.GenNumLabel.TabIndex = 2;
            this.GenNumLabel.Text = "Number of generations:";
            // 
            // MajNumLabel
            // 
            this.MajNumLabel.AutoSize = true;
            this.MajNumLabel.Location = new System.Drawing.Point(48, 150);
            this.MajNumLabel.Name = "MajNumLabel";
            this.MajNumLabel.Size = new System.Drawing.Size(140, 17);
            this.MajNumLabel.TabIndex = 3;
            this.MajNumLabel.Text = "Number of majestics:";
            // 
            // MimNumLabel
            // 
            this.MimNumLabel.AutoSize = true;
            this.MimNumLabel.Location = new System.Drawing.Point(48, 179);
            this.MimNumLabel.Name = "MimNumLabel";
            this.MimNumLabel.Size = new System.Drawing.Size(124, 17);
            this.MimNumLabel.TabIndex = 4;
            this.MimNumLabel.Text = "Number of mimics:";
            // 
            // FlyNumLabel
            // 
            this.FlyNumLabel.AutoSize = true;
            this.FlyNumLabel.Location = new System.Drawing.Point(51, 210);
            this.FlyNumLabel.Name = "FlyNumLabel";
            this.FlyNumLabel.Size = new System.Drawing.Size(107, 17);
            this.FlyNumLabel.TabIndex = 5;
            this.FlyNumLabel.Text = "Number of flies:";
            // 
            // GridSizeInput
            // 
            this.GridSizeInput.Location = new System.Drawing.Point(207, 84);
            this.GridSizeInput.Name = "GridSizeInput";
            this.GridSizeInput.Size = new System.Drawing.Size(100, 22);
            this.GridSizeInput.TabIndex = 6;
            // 
            // GenNumInput
            // 
            this.GenNumInput.Location = new System.Drawing.Point(207, 114);
            this.GenNumInput.Name = "GenNumInput";
            this.GenNumInput.Size = new System.Drawing.Size(100, 22);
            this.GenNumInput.TabIndex = 7;
            // 
            // MajNumInput
            // 
            this.MajNumInput.Location = new System.Drawing.Point(207, 144);
            this.MajNumInput.Name = "MajNumInput";
            this.MajNumInput.Size = new System.Drawing.Size(100, 22);
            this.MajNumInput.TabIndex = 8;
            // 
            // MimNumInput
            // 
            this.MimNumInput.Location = new System.Drawing.Point(207, 173);
            this.MimNumInput.Name = "MimNumInput";
            this.MimNumInput.Size = new System.Drawing.Size(100, 22);
            this.MimNumInput.TabIndex = 9;
            // 
            // FlyNumInput
            // 
            this.FlyNumInput.Location = new System.Drawing.Point(207, 205);
            this.FlyNumInput.Name = "FlyNumInput";
            this.FlyNumInput.Size = new System.Drawing.Size(100, 22);
            this.FlyNumInput.TabIndex = 10;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Location = new System.Drawing.Point(231, 251);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 34);
            this.EnterButton.TabIndex = 11;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 297);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.FlyNumInput);
            this.Controls.Add(this.MimNumInput);
            this.Controls.Add(this.MajNumInput);
            this.Controls.Add(this.GenNumInput);
            this.Controls.Add(this.GridSizeInput);
            this.Controls.Add(this.FlyNumLabel);
            this.Controls.Add(this.MimNumLabel);
            this.Controls.Add(this.MajNumLabel);
            this.Controls.Add(this.GenNumLabel);
            this.Controls.Add(this.GridSizeLabel);
            this.Controls.Add(this.CommLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInput";
            this.Text = "User Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CommLabel;
        private System.Windows.Forms.Label GridSizeLabel;
        private System.Windows.Forms.Label GenNumLabel;
        private System.Windows.Forms.Label MajNumLabel;
        private System.Windows.Forms.Label MimNumLabel;
        private System.Windows.Forms.Label FlyNumLabel;
        private System.Windows.Forms.TextBox GridSizeInput;
        private System.Windows.Forms.TextBox GenNumInput;
        private System.Windows.Forms.TextBox MajNumInput;
        private System.Windows.Forms.TextBox MimNumInput;
        private System.Windows.Forms.TextBox FlyNumInput;
        private System.Windows.Forms.Button EnterButton;
    }
}