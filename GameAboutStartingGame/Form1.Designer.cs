namespace GameAboutStartingGame
{
    partial class gameScreen1
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
            this.whiteEdgeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.invisibleGoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // whiteEdgeLabel
            // 
            this.whiteEdgeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.whiteEdgeLabel.Location = new System.Drawing.Point(278, 59);
            this.whiteEdgeLabel.Name = "whiteEdgeLabel";
            this.whiteEdgeLabel.Size = new System.Drawing.Size(317, 136);
            this.whiteEdgeLabel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(293, 72);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(288, 109);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // invisibleGoLabel
            // 
            this.invisibleGoLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invisibleGoLabel.Location = new System.Drawing.Point(281, 253);
            this.invisibleGoLabel.Name = "invisibleGoLabel";
            this.invisibleGoLabel.Size = new System.Drawing.Size(314, 67);
            this.invisibleGoLabel.TabIndex = 3;
            this.invisibleGoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(942, 623);
            this.Controls.Add(this.invisibleGoLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.whiteEdgeLabel);
            this.Name = "gameScreen1";
            this.Text = "gameScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label whiteEdgeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label invisibleGoLabel;
    }
}

