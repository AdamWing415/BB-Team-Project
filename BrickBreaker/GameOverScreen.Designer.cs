﻿namespace BrickBreaker
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
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.letter1Output = new System.Windows.Forms.Button();
            this.letter2Output = new System.Windows.Forms.Button();
            this.letter3Output = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Old English Text MT", 50F);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.gameOverLabel.Location = new System.Drawing.Point(0, 67);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(854, 105);
            this.gameOverLabel.TabIndex = 10;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Enabled = false;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);

            this.exitButton.Location = new System.Drawing.Point(228, 521);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 250;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Menu";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            this.exitButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.exitButton_PreviewKeyDown);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.White;
            this.playAgainButton.Enabled = false;
            this.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playAgainButton.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.Location = new System.Drawing.Point(660, 521);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(194, 77);
            this.playAgainButton.TabIndex = 200;
            this.playAgainButton.TabStop = false;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            this.playAgainButton.Enter += new System.EventHandler(this.playAgainButton_Enter);
            this.playAgainButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playAgainButton_PreviewKeyDown);
            // 
            // letter1Output
            // 
            this.letter1Output.BackColor = System.Drawing.Color.White;
            this.letter1Output.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter1Output.Location = new System.Drawing.Point(242, 211);
            this.letter1Output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.letter1Output.Name = "letter1Output";
            this.letter1Output.Size = new System.Drawing.Size(120, 120);
            this.letter1Output.TabIndex = 20;
            this.letter1Output.TabStop = false;
            this.letter1Output.Text = "A";
            this.letter1Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.letter1Output.UseVisualStyleBackColor = false;
            this.letter1Output.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.letter1Output_PreviewKeyDown);
            // 
            // letter2Output
            // 
            this.letter2Output.BackColor = System.Drawing.Color.White;
            this.letter2Output.Enabled = false;
            this.letter2Output.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter2Output.Location = new System.Drawing.Point(368, 211);
            this.letter2Output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.letter2Output.Name = "letter2Output";
            this.letter2Output.Size = new System.Drawing.Size(120, 120);
            this.letter2Output.TabIndex = 99;
            this.letter2Output.TabStop = false;
            this.letter2Output.Text = "A";
            this.letter2Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.letter2Output.UseVisualStyleBackColor = false;
            this.letter2Output.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.letter2Output_PreviewKeyDown);
            // 
            // letter3Output
            // 
            this.letter3Output.BackColor = System.Drawing.Color.White;
            this.letter3Output.Enabled = false;
            this.letter3Output.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter3Output.Location = new System.Drawing.Point(492, 211);
            this.letter3Output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.letter3Output.Name = "letter3Output";
            this.letter3Output.Size = new System.Drawing.Size(120, 120);
            this.letter3Output.TabIndex = 150;
            this.letter3Output.TabStop = false;
            this.letter3Output.Text = "A";
            this.letter3Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.letter3Output.UseVisualStyleBackColor = false;
            this.letter3Output.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.letter3Output_PreviewKeyDown);
            // 

            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.game_screen_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

            this.Controls.Add(this.letter3Output);
            this.Controls.Add(this.letter2Output);
            this.Controls.Add(this.letter1Output);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.gameOverLabel);
            this.DoubleBuffered = true;
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playAgainButton;

        private System.Windows.Forms.Button letter1Output;
        private System.Windows.Forms.Button letter2Output;
        private System.Windows.Forms.Button letter3Output;

    }
}
