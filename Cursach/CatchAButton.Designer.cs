namespace Cursach
{
    partial class CatchAButton
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchAButton));
            this.closeButton = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accPlace = new System.Windows.Forms.Label();
            this.rollUpButton = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.leaderboardDataGridView = new System.Windows.Forms.DataGridView();
            this.resetButt = new System.Windows.Forms.Button();
            this.diffLevelCheck = new System.Windows.Forms.Label();
            this.diffLevel = new System.Windows.Forms.Label();
            this.hardButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.Button();
            this.timerButt = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeButton.Location = new System.Drawing.Point(862, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Х";
            this.closeButton.Click += new System.EventHandler(this.Exit_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.mainButton);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 445);
            this.panel1.TabIndex = 3;
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.Color.Red;
            this.mainButton.Enabled = false;
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton.Location = new System.Drawing.Point(172, 117);
            this.mainButton.Margin = new System.Windows.Forms.Padding(2);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(38, 41);
            this.mainButton.TabIndex = 0;
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.panel2.Controls.Add(this.accPlace);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 22);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            // 
            // accPlace
            // 
            this.accPlace.AutoSize = true;
            this.accPlace.Location = new System.Drawing.Point(3, 3);
            this.accPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accPlace.Name = "accPlace";
            this.accPlace.Size = new System.Drawing.Size(35, 13);
            this.accPlace.TabIndex = 0;
            this.accPlace.Text = "label1";
            // 
            // rollUpButton
            // 
            this.rollUpButton.AutoSize = true;
            this.rollUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(160)))), ((int)(((byte)(165)))));
            this.rollUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollUpButton.Font = new System.Drawing.Font("Unispace", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rollUpButton.Location = new System.Drawing.Point(842, -1);
            this.rollUpButton.Name = "rollUpButton";
            this.rollUpButton.Size = new System.Drawing.Size(22, 23);
            this.rollUpButton.TabIndex = 5;
            this.rollUpButton.Text = "-";
            this.rollUpButton.Click += new System.EventHandler(this.RollUp);
            this.rollUpButton.MouseEnter += new System.EventHandler(this.RollUpButton_MouseEnter);
            this.rollUpButton.MouseLeave += new System.EventHandler(this.RollUpButton_MouseLeave);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(45, 408);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(202, 38);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "СТАРТ";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(96, 370);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(108, 34);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.leaderboardDataGridView);
            this.panel3.Controls.Add(this.resetButt);
            this.panel3.Controls.Add(this.diffLevelCheck);
            this.panel3.Controls.Add(this.diffLevel);
            this.panel3.Controls.Add(this.hardButton);
            this.panel3.Controls.Add(this.mediumButton);
            this.panel3.Controls.Add(this.easyButton);
            this.panel3.Controls.Add(this.timeLabel);
            this.panel3.Controls.Add(this.startButton);
            this.panel3.Location = new System.Drawing.Point(588, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 446);
            this.panel3.TabIndex = 8;
            // 
            // leaderboardDataGridView
            // 
            this.leaderboardDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.leaderboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.leaderboardDataGridView.Location = new System.Drawing.Point(20, 117);
            this.leaderboardDataGridView.Name = "leaderboardDataGridView";
            this.leaderboardDataGridView.ReadOnly = true;
            this.leaderboardDataGridView.Size = new System.Drawing.Size(240, 155);
            this.leaderboardDataGridView.TabIndex = 14;
            // 
            // resetButt
            // 
            this.resetButt.Image = global::Cursach.Properties.Resources.icons8_reset_30;
            this.resetButt.Location = new System.Drawing.Point(3, 408);
            this.resetButt.Margin = new System.Windows.Forms.Padding(2);
            this.resetButt.Name = "resetButt";
            this.resetButt.Size = new System.Drawing.Size(35, 38);
            this.resetButt.TabIndex = 13;
            this.resetButt.UseVisualStyleBackColor = true;
            this.resetButt.Click += new System.EventHandler(this.ResetButt_Click);
            // 
            // diffLevelCheck
            // 
            this.diffLevelCheck.AutoSize = true;
            this.diffLevelCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.diffLevelCheck.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffLevelCheck.Location = new System.Drawing.Point(19, 303);
            this.diffLevelCheck.Name = "diffLevelCheck";
            this.diffLevelCheck.Size = new System.Drawing.Size(21, 21);
            this.diffLevelCheck.TabIndex = 12;
            this.diffLevelCheck.Text = ".\r\n";
            // 
            // diffLevel
            // 
            this.diffLevel.AutoSize = true;
            this.diffLevel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.diffLevel.Location = new System.Drawing.Point(16, 275);
            this.diffLevel.Name = "diffLevel";
            this.diffLevel.Size = new System.Drawing.Size(171, 19);
            this.diffLevel.TabIndex = 11;
            this.diffLevel.Text = "УРОВЕНЬ СЛОЖНОСТИ";
            // 
            // hardButton
            // 
            this.hardButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.Location = new System.Drawing.Point(225, 327);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(40, 40);
            this.hardButton.TabIndex = 10;
            this.hardButton.Text = "3";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.Location = new System.Drawing.Point(125, 327);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(40, 40);
            this.mediumButton.TabIndex = 9;
            this.mediumButton.Text = "2";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // easyButton
            // 
            this.easyButton.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.Location = new System.Drawing.Point(19, 327);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(40, 40);
            this.easyButton.TabIndex = 8;
            this.easyButton.Text = "1";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // CatchAButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(883, 486);
            this.ControlBox = false;
            this.Controls.Add(this.rollUpButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CatchAButton";
            this.Text = "CatchAButton";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label rollUpButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Timer timerButt;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Label diffLevel;
        private System.Windows.Forms.Label diffLevelCheck;
        private System.Windows.Forms.Label accPlace;
        private System.Windows.Forms.Button resetButt;
        private System.Windows.Forms.DataGridView leaderboardDataGridView;
    }
}