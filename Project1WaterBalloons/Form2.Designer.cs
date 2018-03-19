namespace Project1WaterBalloons
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnGotIt = new System.Windows.Forms.Button();
            this.lblHow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 61);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(361, 221);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // btnGotIt
            // 
            this.btnGotIt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGotIt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGotIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotIt.Location = new System.Drawing.Point(143, 302);
            this.btnGotIt.Name = "btnGotIt";
            this.btnGotIt.Size = new System.Drawing.Size(102, 51);
            this.btnGotIt.TabIndex = 1;
            this.btnGotIt.Text = "Got It!";
            this.btnGotIt.UseVisualStyleBackColor = false;
            this.btnGotIt.Click += new System.EventHandler(this.btnGotIt_Click);
            // 
            // lblHow
            // 
            this.lblHow.AutoSize = true;
            this.lblHow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHow.Location = new System.Drawing.Point(138, 19);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(107, 20);
            this.lblHow.TabIndex = 2;
            this.lblHow.Text = "How To Play";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 365);
            this.Controls.Add(this.lblHow);
            this.Controls.Add(this.btnGotIt);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Form2";
            this.Text = "How To Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnGotIt;
        private System.Windows.Forms.Label lblHow;
    }
}