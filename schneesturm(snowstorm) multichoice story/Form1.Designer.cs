namespace schneesturm_snowstorm__multichoice_story
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.mlabel = new System.Windows.Forms.Label();
            this.nlabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.carStuckSnow = new System.Windows.Forms.PictureBox();
            this.snowStormTitle = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(463, 42);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(463, 155);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "You wake up in a snow storm you decide to ";
            // 
            // mlabel
            // 
            this.mlabel.Location = new System.Drawing.Point(497, 335);
            this.mlabel.Name = "mlabel";
            this.mlabel.Size = new System.Drawing.Size(84, 23);
            this.mlabel.TabIndex = 4;
            this.mlabel.Text = "press m for blue";
            // 
            // nlabel
            // 
            this.nlabel.Location = new System.Drawing.Point(660, 335);
            this.nlabel.Name = "nlabel";
            this.nlabel.Size = new System.Drawing.Size(77, 23);
            this.nlabel.TabIndex = 5;
            this.nlabel.Text = "press n for red";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.blue_50x50;
            this.blueLabel.Location = new System.Drawing.Point(480, 197);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(124, 201);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "To leave car";
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.red_50x50;
            this.redLabel.Location = new System.Drawing.Point(627, 197);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(142, 201);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "Stay in car";
            // 
            // carStuckSnow
            // 
            this.carStuckSnow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.carStuckSnow.Location = new System.Drawing.Point(-5, -1);
            this.carStuckSnow.Name = "carStuckSnow";
            this.carStuckSnow.Size = new System.Drawing.Size(469, 419);
            this.carStuckSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carStuckSnow.TabIndex = 1;
            this.carStuckSnow.TabStop = false;
            // 
            // snowStormTitle
            // 
            this.snowStormTitle.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snowStormTitle.Location = new System.Drawing.Point(467, -1);
            this.snowStormTitle.Name = "snowStormTitle";
            this.snowStormTitle.Size = new System.Drawing.Size(222, 43);
            this.snowStormTitle.TabIndex = 6;
            this.snowStormTitle.Text = "Snowstorm";
            // 
            // yellowLabel
            // 
            this.yellowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.yellow_50x50;
            this.yellowLabel.Location = new System.Drawing.Point(777, 197);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(138, 169);
            this.yellowLabel.TabIndex = 7;
            this.yellowLabel.Visible = false;
            // 
            // bLabel
            // 
            this.bLabel.Location = new System.Drawing.Point(789, 335);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(101, 23);
            this.bLabel.TabIndex = 8;
            this.bLabel.Text = "Press b for yellow";
            this.bLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(927, 414);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.snowStormTitle);
            this.Controls.Add(this.nlabel);
            this.Controls.Add(this.mlabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.carStuckSnow);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.yellowLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox carStuckSnow;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label mlabel;
        private System.Windows.Forms.Label nlabel;
        private System.Windows.Forms.Label snowStormTitle;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label bLabel;
    }
}

