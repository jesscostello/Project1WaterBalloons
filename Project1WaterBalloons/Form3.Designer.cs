namespace Project1WaterBalloons
{
    partial class Form3
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
            this.lblLose = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblDodges = new System.Windows.Forms.Label();
            this.lblBalloons = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.ckbDodge = new System.Windows.Forms.CheckBox();
            this.picDodge2 = new System.Windows.Forms.PictureBox();
            this.picDodge = new System.Windows.Forms.PictureBox();
            this.picSix = new System.Windows.Forms.PictureBox();
            this.picFive = new System.Windows.Forms.PictureBox();
            this.picFour = new System.Windows.Forms.PictureBox();
            this.picThree = new System.Windows.Forms.PictureBox();
            this.picTwo = new System.Windows.Forms.PictureBox();
            this.picOne = new System.Windows.Forms.PictureBox();
            this.picThrow = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.picWin = new System.Windows.Forms.PictureBox();
            this.btnStartAgain = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblLoser = new System.Windows.Forms.Label();
            this.picLoser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDodge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(369, 38);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(68, 20);
            this.lblLose.TabIndex = 12;
            this.lblLose.Text = "Losses: ";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(385, 9);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(52, 20);
            this.lblWin.TabIndex = 11;
            this.lblWin.Text = "Wins: ";
            // 
            // lblDodges
            // 
            this.lblDodges.AutoSize = true;
            this.lblDodges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodges.Location = new System.Drawing.Point(9, 264);
            this.lblDodges.Name = "lblDodges";
            this.lblDodges.Size = new System.Drawing.Size(154, 17);
            this.lblDodges.TabIndex = 13;
            this.lblDodges.Text = "Dodges Remaining: ";
            // 
            // lblBalloons
            // 
            this.lblBalloons.AutoSize = true;
            this.lblBalloons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalloons.Location = new System.Drawing.Point(9, 363);
            this.lblBalloons.Name = "lblBalloons";
            this.lblBalloons.Size = new System.Drawing.Size(156, 17);
            this.lblBalloons.TabIndex = 14;
            this.lblBalloons.Text = "Balloons Remaining:";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(373, 74);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(114, 40);
            this.btnFill.TabIndex = 16;
            this.btnFill.Text = "Fill Balloons";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnLine
            // 
            this.btnLine.Enabled = false;
            this.btnLine.Location = new System.Drawing.Point(373, 120);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(114, 39);
            this.btnLine.TabIndex = 17;
            this.btnLine.Text = "Line Up Balloons";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Enabled = false;
            this.btnThrow.Location = new System.Drawing.Point(373, 386);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(114, 37);
            this.btnThrow.TabIndex = 18;
            this.btnThrow.Text = "Throw!";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // ckbDodge
            // 
            this.ckbDodge.AutoSize = true;
            this.ckbDodge.Location = new System.Drawing.Point(373, 363);
            this.ckbDodge.Name = "ckbDodge";
            this.ckbDodge.Size = new System.Drawing.Size(119, 17);
            this.ckbDodge.TabIndex = 35;
            this.ckbDodge.Text = "Dodge This Balloon";
            this.ckbDodge.UseVisualStyleBackColor = true;
            // 
            // picDodge2
            // 
            this.picDodge2.BackgroundImage = global::Project1WaterBalloons.Resources.Dodge;
            this.picDodge2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDodge2.Location = new System.Drawing.Point(83, 284);
            this.picDodge2.Name = "picDodge2";
            this.picDodge2.Size = new System.Drawing.Size(65, 64);
            this.picDodge2.TabIndex = 28;
            this.picDodge2.TabStop = false;
            // 
            // picDodge
            // 
            this.picDodge.BackgroundImage = global::Project1WaterBalloons.Resources.Dodge;
            this.picDodge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDodge.Location = new System.Drawing.Point(12, 284);
            this.picDodge.Name = "picDodge";
            this.picDodge.Size = new System.Drawing.Size(65, 64);
            this.picDodge.TabIndex = 27;
            this.picDodge.TabStop = false;
            // 
            // picSix
            // 
            this.picSix.BackgroundImage = global::Project1WaterBalloons.Resources.Balloon;
            this.picSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSix.Location = new System.Drawing.Point(217, 386);
            this.picSix.Name = "picSix";
            this.picSix.Size = new System.Drawing.Size(35, 37);
            this.picSix.TabIndex = 26;
            this.picSix.TabStop = false;
            this.picSix.Visible = false;
            // 
            // picFive
            // 
            this.picFive.BackgroundImage = global::Project1WaterBalloons.Resources.Balloon;
            this.picFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFive.Location = new System.Drawing.Point(176, 386);
            this.picFive.Name = "picFive";
            this.picFive.Size = new System.Drawing.Size(35, 37);
            this.picFive.TabIndex = 25;
            this.picFive.TabStop = false;
            this.picFive.Visible = false;
            // 
            // picFour
            // 
            this.picFour.BackgroundImage = global::Project1WaterBalloons.Resources.Balloon;
            this.picFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFour.Location = new System.Drawing.Point(135, 386);
            this.picFour.Name = "picFour";
            this.picFour.Size = new System.Drawing.Size(35, 37);
            this.picFour.TabIndex = 24;
            this.picFour.TabStop = false;
            this.picFour.Visible = false;
            // 
            // picThree
            // 
            this.picThree.BackgroundImage = global::Project1WaterBalloons.Resources.Balloon;
            this.picThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picThree.Location = new System.Drawing.Point(94, 386);
            this.picThree.Name = "picThree";
            this.picThree.Size = new System.Drawing.Size(35, 37);
            this.picThree.TabIndex = 23;
            this.picThree.TabStop = false;
            this.picThree.Visible = false;
            // 
            // picTwo
            // 
            this.picTwo.BackgroundImage = global::Project1WaterBalloons.Resources.Balloon;
            this.picTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTwo.Location = new System.Drawing.Point(53, 386);
            this.picTwo.Name = "picTwo";
            this.picTwo.Size = new System.Drawing.Size(35, 37);
            this.picTwo.TabIndex = 22;
            this.picTwo.TabStop = false;
            this.picTwo.Visible = false;
            // 
            // picOne
            // 
            this.picOne.BackgroundImage = global::Project1WaterBalloons.Resources.Balloon;
            this.picOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOne.Location = new System.Drawing.Point(12, 386);
            this.picOne.Name = "picOne";
            this.picOne.Size = new System.Drawing.Size(35, 37);
            this.picOne.TabIndex = 21;
            this.picOne.TabStop = false;
            this.picOne.Visible = false;
            // 
            // picThrow
            // 
            this.picThrow.BackgroundImage = global::Project1WaterBalloons.Resources.Throw;
            this.picThrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picThrow.Location = new System.Drawing.Point(348, 165);
            this.picThrow.Name = "picThrow";
            this.picThrow.Size = new System.Drawing.Size(167, 183);
            this.picThrow.TabIndex = 20;
            this.picThrow.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackgroundImage = global::Project1WaterBalloons.Resources.Player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(12, 24);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(139, 207);
            this.picPlayer.TabIndex = 15;
            this.picPlayer.TabStop = false;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(176, 38);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(0, 13);
            this.lblDelete.TabIndex = 36;
            // 
            // picWin
            // 
            this.picWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWin.Image = global::Project1WaterBalloons.Resources.Throw;
            this.picWin.Location = new System.Drawing.Point(2, 0);
            this.picWin.Name = "picWin";
            this.picWin.Size = new System.Drawing.Size(523, 432);
            this.picWin.TabIndex = 37;
            this.picWin.TabStop = false;
            this.picWin.Visible = false;
            // 
            // btnStartAgain
            // 
            this.btnStartAgain.BackColor = System.Drawing.Color.SpringGreen;
            this.btnStartAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAgain.Font = new System.Drawing.Font("Goudy Stout", 15.75F);
            this.btnStartAgain.Location = new System.Drawing.Point(29, 305);
            this.btnStartAgain.Name = "btnStartAgain";
            this.btnStartAgain.Size = new System.Drawing.Size(182, 97);
            this.btnStartAgain.TabIndex = 39;
            this.btnStartAgain.Text = "Play Again";
            this.btnStartAgain.UseVisualStyleBackColor = false;
            this.btnStartAgain.Visible = false;
            this.btnStartAgain.Click += new System.EventHandler(this.btnStartAgain_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Goudy Stout", 15.75F);
            this.lblWinner.Location = new System.Drawing.Point(314, 30);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(201, 28);
            this.lblWinner.TabIndex = 40;
            this.lblWinner.Text = "You Won!";
            this.lblWinner.Visible = false;
            // 
            // lblLoser
            // 
            this.lblLoser.AutoSize = true;
            this.lblLoser.BackColor = System.Drawing.Color.Transparent;
            this.lblLoser.Font = new System.Drawing.Font("Goudy Stout", 15.75F);
            this.lblLoser.Location = new System.Drawing.Point(157, 182);
            this.lblLoser.Name = "lblLoser";
            this.lblLoser.Size = new System.Drawing.Size(211, 28);
            this.lblLoser.TabIndex = 41;
            this.lblLoser.Text = "You Lose!";
            this.lblLoser.Visible = false;
            // 
            // picLoser
            // 
            this.picLoser.BackgroundImage = global::Project1WaterBalloons.Resources.Splat;
            this.picLoser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoser.Location = new System.Drawing.Point(2, 0);
            this.picLoser.Name = "picLoser";
            this.picLoser.Size = new System.Drawing.Size(523, 432);
            this.picLoser.TabIndex = 42;
            this.picLoser.TabStop = false;
            this.picLoser.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 435);
            this.Controls.Add(this.picLoser);
            this.Controls.Add(this.lblLoser);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnStartAgain);
            this.Controls.Add(this.picWin);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.ckbDodge);
            this.Controls.Add(this.picDodge2);
            this.Controls.Add(this.picDodge);
            this.Controls.Add(this.picSix);
            this.Controls.Add(this.picFive);
            this.Controls.Add(this.picFour);
            this.Controls.Add(this.picThree);
            this.Controls.Add(this.picTwo);
            this.Controls.Add(this.picOne);
            this.Controls.Add(this.picThrow);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.lblBalloons);
            this.Controls.Add(this.lblDodges);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.lblWin);
            this.Name = "Form3";
            this.Text = "Current Game";
            ((System.ComponentModel.ISupportInitialize)(this.picDodge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox picLoser;
        public System.Windows.Forms.Label lblWin;
        public System.Windows.Forms.Label lblLose;
        public System.Windows.Forms.Label lblDodges;
        public System.Windows.Forms.Label lblBalloons;
        public System.Windows.Forms.PictureBox picPlayer;
        public System.Windows.Forms.Button btnFill;
        public System.Windows.Forms.Button btnLine;
        public System.Windows.Forms.Button btnThrow;
        public System.Windows.Forms.PictureBox picThrow;
        public System.Windows.Forms.PictureBox picOne;
        public System.Windows.Forms.PictureBox picTwo;
        public System.Windows.Forms.PictureBox picThree;
        public System.Windows.Forms.PictureBox picFour;
        public System.Windows.Forms.PictureBox picFive;
        public System.Windows.Forms.PictureBox picSix;
        public System.Windows.Forms.PictureBox picDodge;
        public System.Windows.Forms.PictureBox picDodge2;
        public System.Windows.Forms.CheckBox ckbDodge;
        public System.Windows.Forms.Label lblDelete;
        public System.Windows.Forms.PictureBox picWin;
        public System.Windows.Forms.Button btnStartAgain;
        public System.Windows.Forms.Label lblWinner;
        public System.Windows.Forms.Label lblLoser;
    }
}