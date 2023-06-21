namespace Doodle_Jump
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.uploadHighscoreLabel = new System.Windows.Forms.Label();
            this.highscoreTextBox = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.viewHighScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(363, 313);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 60);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "QUIT?";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(40, 313);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(129, 60);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "RETRY?";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(195, 60);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(155, 29);
            this.gameOverLabel.TabIndex = 2;
            this.gameOverLabel.Text = "GAME OVER!";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(195, 114);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 29);
            this.scoreLabel.TabIndex = 3;
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(81, 578);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(129, 74);
            this.uploadButton.TabIndex = 5;
            this.uploadButton.Text = "Upload Highscore";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // uploadHighscoreLabel
            // 
            this.uploadHighscoreLabel.AutoSize = true;
            this.uploadHighscoreLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadHighscoreLabel.Location = new System.Drawing.Point(52, 465);
            this.uploadHighscoreLabel.Name = "uploadHighscoreLabel";
            this.uploadHighscoreLabel.Size = new System.Drawing.Size(191, 29);
            this.uploadHighscoreLabel.TabIndex = 6;
            this.uploadHighscoreLabel.Text = "Upload your score?";
            // 
            // highscoreTextBox
            // 
            this.highscoreTextBox.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreTextBox.Location = new System.Drawing.Point(81, 524);
            this.highscoreTextBox.Name = "highscoreTextBox";
            this.highscoreTextBox.Size = new System.Drawing.Size(129, 36);
            this.highscoreTextBox.TabIndex = 7;
            this.highscoreTextBox.Text = "Enter Name";
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(363, 442);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(129, 74);
            this.viewButton.TabIndex = 8;
            this.viewButton.Text = "View Highscores";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // viewHighScoreLabel
            // 
            this.viewHighScoreLabel.AutoSize = true;
            this.viewHighScoreLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHighScoreLabel.Location = new System.Drawing.Point(326, 531);
            this.viewHighScoreLabel.Name = "viewHighScoreLabel";
            this.viewHighScoreLabel.Size = new System.Drawing.Size(0, 36);
            this.viewHighScoreLabel.TabIndex = 9;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.viewHighScoreLabel);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.highscoreTextBox);
            this.Controls.Add(this.uploadHighscoreLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.exitButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(549, 697);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label uploadHighscoreLabel;
        private System.Windows.Forms.TextBox highscoreTextBox;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label viewHighScoreLabel;
    }
}
