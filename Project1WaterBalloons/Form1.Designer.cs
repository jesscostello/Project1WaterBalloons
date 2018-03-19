namespace Project1WaterBalloons
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lblReady = new System.Windows.Forms.Label();
            this.lblFirstTime = new System.Windows.Forms.Label();
            this.picBucket = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBucket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SpringGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(322, 261);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 97);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Play Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(12, 27);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(241, 40);
            this.lblIntro.TabIndex = 5;
            this.lblIntro.Text = "Avoid the balloon filled with paint \r\nto win the game!";
            // 
            // btnInstructions
            // 
            this.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructions.Location = new System.Drawing.Point(352, 125);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(110, 40);
            this.btnInstructions.TabIndex = 6;
            this.btnInstructions.Text = "How To Play";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.Location = new System.Drawing.Point(354, 216);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(108, 31);
            this.lblReady.TabIndex = 7;
            this.lblReady.Text = "Ready?";
            // 
            // lblFirstTime
            // 
            this.lblFirstTime.AutoSize = true;
            this.lblFirstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstTime.Location = new System.Drawing.Point(330, 82);
            this.lblFirstTime.Name = "lblFirstTime";
            this.lblFirstTime.Size = new System.Drawing.Size(150, 31);
            this.lblFirstTime.TabIndex = 8;
            this.lblFirstTime.Text = "First Time?";
            // 
            // picBucket
            // 
            this.picBucket.BackgroundImage = global::Project1WaterBalloons.Resources.Bucket;
            this.picBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBucket.Location = new System.Drawing.Point(137, 271);
            this.picBucket.Name = "picBucket";
            this.picBucket.Size = new System.Drawing.Size(168, 113);
            this.picBucket.TabIndex = 3;
            this.picBucket.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackgroundImage = global::Project1WaterBalloons.Resources.Player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(12, 82);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(139, 207);
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 404);
            this.Controls.Add(this.lblFirstTime);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.picBucket);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Water Balloon Game";
            ((System.ComponentModel.ISupportInitialize)(this.picBucket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBucket;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Label lblFirstTime;
    }
}

