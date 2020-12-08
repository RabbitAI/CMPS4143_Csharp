namespace Proj5GameofLife_Douglas
{
    partial class GameForm
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
            this.CharStat = new System.Windows.Forms.GroupBox();
            this.FlyNum = new System.Windows.Forms.Label();
            this.FlyNumLabel = new System.Windows.Forms.Label();
            this.FlyName = new System.Windows.Forms.Label();
            this.FlySym = new System.Windows.Forms.PictureBox();
            this.MimNum = new System.Windows.Forms.Label();
            this.MimNumLabel = new System.Windows.Forms.Label();
            this.MimName = new System.Windows.Forms.Label();
            this.MimSym = new System.Windows.Forms.PictureBox();
            this.MajNum = new System.Windows.Forms.Label();
            this.MajNumLabel = new System.Windows.Forms.Label();
            this.MajName = new System.Windows.Forms.Label();
            this.MajSym = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.GenBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.CharStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlySym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimSym)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MajSym)).BeginInit();
            this.SuspendLayout();
            // 
            // CharStat
            // 
            this.CharStat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CharStat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CharStat.Controls.Add(this.FlyNum);
            this.CharStat.Controls.Add(this.FlyNumLabel);
            this.CharStat.Controls.Add(this.FlyName);
            this.CharStat.Controls.Add(this.FlySym);
            this.CharStat.Controls.Add(this.MimNum);
            this.CharStat.Controls.Add(this.MimNumLabel);
            this.CharStat.Controls.Add(this.MimName);
            this.CharStat.Controls.Add(this.MimSym);
            this.CharStat.Controls.Add(this.MajNum);
            this.CharStat.Controls.Add(this.MajNumLabel);
            this.CharStat.Controls.Add(this.MajName);
            this.CharStat.Controls.Add(this.MajSym);
            this.CharStat.Location = new System.Drawing.Point(9, 359);
            this.CharStat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CharStat.Name = "CharStat";
            this.CharStat.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CharStat.Size = new System.Drawing.Size(582, 106);
            this.CharStat.TabIndex = 0;
            this.CharStat.TabStop = false;
            this.CharStat.Text = "Charater Stats";
            // 
            // FlyNum
            // 
            this.FlyNum.AutoSize = true;
            this.FlyNum.Location = new System.Drawing.Point(518, 50);
            this.FlyNum.Name = "FlyNum";
            this.FlyNum.Size = new System.Drawing.Size(16, 18);
            this.FlyNum.TabIndex = 11;
            this.FlyNum.Text = "0";
            // 
            // FlyNumLabel
            // 
            this.FlyNumLabel.AutoSize = true;
            this.FlyNumLabel.Location = new System.Drawing.Point(443, 50);
            this.FlyNumLabel.Name = "FlyNumLabel";
            this.FlyNumLabel.Size = new System.Drawing.Size(68, 18);
            this.FlyNumLabel.TabIndex = 10;
            this.FlyNumLabel.Text = "Number of:";
            // 
            // FlyName
            // 
            this.FlyName.AutoSize = true;
            this.FlyName.Location = new System.Drawing.Point(442, 23);
            this.FlyName.Name = "FlyName";
            this.FlyName.Size = new System.Drawing.Size(24, 18);
            this.FlyName.TabIndex = 9;
            this.FlyName.Text = "Fly";
            // 
            // FlySym
            // 
            this.FlySym.BackColor = System.Drawing.Color.White;
            this.FlySym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlySym.Image = global::Proj5GameofLife_Douglas.Properties.Resources.fly1;
            this.FlySym.Location = new System.Drawing.Point(381, 23);
            this.FlySym.Name = "FlySym";
            this.FlySym.Size = new System.Drawing.Size(55, 68);
            this.FlySym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlySym.TabIndex = 8;
            this.FlySym.TabStop = false;
            // 
            // MimNum
            // 
            this.MimNum.AutoSize = true;
            this.MimNum.Location = new System.Drawing.Point(341, 50);
            this.MimNum.Name = "MimNum";
            this.MimNum.Size = new System.Drawing.Size(16, 18);
            this.MimNum.TabIndex = 7;
            this.MimNum.Text = "0";
            // 
            // MimNumLabel
            // 
            this.MimNumLabel.AutoSize = true;
            this.MimNumLabel.Location = new System.Drawing.Point(262, 50);
            this.MimNumLabel.Name = "MimNumLabel";
            this.MimNumLabel.Size = new System.Drawing.Size(68, 18);
            this.MimNumLabel.TabIndex = 6;
            this.MimNumLabel.Text = "Number of:";
            // 
            // MimName
            // 
            this.MimName.AutoSize = true;
            this.MimName.Location = new System.Drawing.Point(263, 23);
            this.MimName.Name = "MimName";
            this.MimName.Size = new System.Drawing.Size(43, 18);
            this.MimName.TabIndex = 5;
            this.MimName.Text = "Mimic";
            // 
            // MimSym
            // 
            this.MimSym.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MimSym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MimSym.Image = global::Proj5GameofLife_Douglas.Properties.Resources.mimic;
            this.MimSym.Location = new System.Drawing.Point(201, 22);
            this.MimSym.Name = "MimSym";
            this.MimSym.Size = new System.Drawing.Size(55, 68);
            this.MimSym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MimSym.TabIndex = 4;
            this.MimSym.TabStop = false;
            // 
            // MajNum
            // 
            this.MajNum.AutoSize = true;
            this.MajNum.Location = new System.Drawing.Point(157, 50);
            this.MajNum.Name = "MajNum";
            this.MajNum.Size = new System.Drawing.Size(16, 18);
            this.MajNum.TabIndex = 3;
            this.MajNum.Text = "0";
            // 
            // MajNumLabel
            // 
            this.MajNumLabel.AutoSize = true;
            this.MajNumLabel.Location = new System.Drawing.Point(83, 50);
            this.MajNumLabel.Name = "MajNumLabel";
            this.MajNumLabel.Size = new System.Drawing.Size(68, 18);
            this.MajNumLabel.TabIndex = 2;
            this.MajNumLabel.Text = "Number of:";
            // 
            // MajName
            // 
            this.MajName.AutoSize = true;
            this.MajName.Location = new System.Drawing.Point(84, 22);
            this.MajName.Name = "MajName";
            this.MajName.Size = new System.Drawing.Size(58, 18);
            this.MajName.TabIndex = 1;
            this.MajName.Text = "Majestic";
            // 
            // MajSym
            // 
            this.MajSym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MajSym.Image = global::Proj5GameofLife_Douglas.Properties.Resources.Majestic_Live;
            this.MajSym.Location = new System.Drawing.Point(22, 22);
            this.MajSym.Name = "MajSym";
            this.MajSym.Size = new System.Drawing.Size(55, 68);
            this.MajSym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MajSym.TabIndex = 0;
            this.MajSym.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 32);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GenBox
            // 
            this.GenBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GenBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.GenBox.Location = new System.Drawing.Point(390, 13);
            this.GenBox.Name = "GenBox";
            this.GenBox.ReadOnly = true;
            this.GenBox.Size = new System.Drawing.Size(123, 23);
            this.GenBox.TabIndex = 4;
            this.GenBox.Text = "Generation:";
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Location = new System.Drawing.Point(519, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 33);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proj5GameofLife_Douglas.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 478);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GenBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CharStat);
            this.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GameForm";
            this.Text = "Game of Life";
            this.CharStat.ResumeLayout(false);
            this.CharStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlySym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MimSym)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MajSym)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CharStat;
        private System.Windows.Forms.PictureBox MajSym;
        private System.Windows.Forms.PictureBox MimSym;
        private System.Windows.Forms.Label MajNum;
        private System.Windows.Forms.Label MajNumLabel;
        private System.Windows.Forms.Label MajName;
        private System.Windows.Forms.PictureBox FlySym;
        private System.Windows.Forms.Label MimNum;
        private System.Windows.Forms.Label MimNumLabel;
        private System.Windows.Forms.Label MimName;
        private System.Windows.Forms.Label FlyName;
        private System.Windows.Forms.Label FlyNum;
        private System.Windows.Forms.Label FlyNumLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox GenBox;
        private System.Windows.Forms.Button NextButton;
    }
}

