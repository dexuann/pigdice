namespace PST3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dieImage1 = new System.Windows.Forms.PictureBox();
            this.dieImage2 = new System.Windows.Forms.PictureBox();
            this.cpuScoreLabel = new System.Windows.Forms.Label();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.scoreThisTurnLabel = new System.Windows.Forms.Label();
            this.turnStatusLabel = new System.Windows.Forms.Label();
            this.cpuTotalScoreLabel = new System.Windows.Forms.Label();
            this.userTotalScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollButton = new System.Windows.Forms.Button();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.currentTurnScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dieImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieImage2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dieImage1
            // 
            this.dieImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dieImage1.Location = new System.Drawing.Point(12, 147);
            this.dieImage1.Name = "dieImage1";
            this.dieImage1.Size = new System.Drawing.Size(152, 148);
            this.dieImage1.TabIndex = 0;
            this.dieImage1.TabStop = false;
            // 
            // dieImage2
            // 
            this.dieImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dieImage2.Location = new System.Drawing.Point(220, 147);
            this.dieImage2.Name = "dieImage2";
            this.dieImage2.Size = new System.Drawing.Size(152, 148);
            this.dieImage2.TabIndex = 1;
            this.dieImage2.TabStop = false;
            // 
            // cpuScoreLabel
            // 
            this.cpuScoreLabel.AutoSize = true;
            this.cpuScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScoreLabel.Location = new System.Drawing.Point(101, 61);
            this.cpuScoreLabel.Name = "cpuScoreLabel";
            this.cpuScoreLabel.Size = new System.Drawing.Size(122, 18);
            this.cpuScoreLabel.TabIndex = 2;
            this.cpuScoreLabel.Text = "Computer Score:";
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.AutoSize = true;
            this.userScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScoreLabel.Location = new System.Drawing.Point(135, 101);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(88, 18);
            this.userScoreLabel.TabIndex = 3;
            this.userScoreLabel.Text = "User Score:";
            // 
            // scoreThisTurnLabel
            // 
            this.scoreThisTurnLabel.AutoSize = true;
            this.scoreThisTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreThisTurnLabel.Location = new System.Drawing.Point(123, 315);
            this.scoreThisTurnLabel.Name = "scoreThisTurnLabel";
            this.scoreThisTurnLabel.Size = new System.Drawing.Size(108, 18);
            this.scoreThisTurnLabel.TabIndex = 4;
            this.scoreThisTurnLabel.Text = "Score this turn:";
            // 
            // turnStatusLabel
            // 
            this.turnStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.turnStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnStatusLabel.Location = new System.Drawing.Point(0, 437);
            this.turnStatusLabel.Name = "turnStatusLabel";
            this.turnStatusLabel.Padding = new System.Windows.Forms.Padding(5);
            this.turnStatusLabel.Size = new System.Drawing.Size(384, 34);
            this.turnStatusLabel.TabIndex = 5;
            this.turnStatusLabel.Text = "current turn status";
            this.turnStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuTotalScoreLabel
            // 
            this.cpuTotalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTotalScoreLabel.Location = new System.Drawing.Point(229, 61);
            this.cpuTotalScoreLabel.Name = "cpuTotalScoreLabel";
            this.cpuTotalScoreLabel.Size = new System.Drawing.Size(74, 18);
            this.cpuTotalScoreLabel.TabIndex = 6;
            this.cpuTotalScoreLabel.Text = "0";
            // 
            // userTotalScoreLabel
            // 
            this.userTotalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTotalScoreLabel.Location = new System.Drawing.Point(229, 101);
            this.userTotalScoreLabel.Name = "userTotalScoreLabel";
            this.userTotalScoreLabel.Size = new System.Drawing.Size(79, 18);
            this.userTotalScoreLabel.TabIndex = 7;
            this.userTotalScoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(162, 349);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(61, 28);
            this.rollButton.TabIndex = 9;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // endTurnButton
            // 
            this.endTurnButton.Enabled = false;
            this.endTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTurnButton.Location = new System.Drawing.Point(153, 386);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(78, 31);
            this.endTurnButton.TabIndex = 10;
            this.endTurnButton.Text = "End turn";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // currentTurnScoreLabel
            // 
            this.currentTurnScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTurnScoreLabel.Location = new System.Drawing.Point(237, 315);
            this.currentTurnScoreLabel.Name = "currentTurnScoreLabel";
            this.currentTurnScoreLabel.Size = new System.Drawing.Size(96, 18);
            this.currentTurnScoreLabel.TabIndex = 11;
            this.currentTurnScoreLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 471);
            this.Controls.Add(this.currentTurnScoreLabel);
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.userTotalScoreLabel);
            this.Controls.Add(this.cpuTotalScoreLabel);
            this.Controls.Add(this.turnStatusLabel);
            this.Controls.Add(this.scoreThisTurnLabel);
            this.Controls.Add(this.userScoreLabel);
            this.Controls.Add(this.cpuScoreLabel);
            this.Controls.Add(this.dieImage1);
            this.Controls.Add(this.dieImage2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Pig!";
            ((System.ComponentModel.ISupportInitialize)(this.dieImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieImage2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dieImage1;
        private System.Windows.Forms.PictureBox dieImage2;
        private System.Windows.Forms.Label cpuScoreLabel;
        private System.Windows.Forms.Label userScoreLabel;
        private System.Windows.Forms.Label scoreThisTurnLabel;
        private System.Windows.Forms.Label turnStatusLabel;
        private System.Windows.Forms.Label cpuTotalScoreLabel;
        private System.Windows.Forms.Label userTotalScoreLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button endTurnButton;
        private System.Windows.Forms.Label currentTurnScoreLabel;
    }
}

