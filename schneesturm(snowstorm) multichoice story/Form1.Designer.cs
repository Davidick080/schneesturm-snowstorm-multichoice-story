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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.carStuckSnow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(470, 207);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(456, 198);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "snowstorm                                                       You wake up in a " +
    "snow storm you decide to ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(507, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "press m for blue";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(677, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "press n for red";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.blue_50x50;
            this.blueLabel.Location = new System.Drawing.Point(470, 9);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(124, 201);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "To leave car";
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.red_50x50;
            this.redLabel.Location = new System.Drawing.Point(627, 9);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(171, 201);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "Stay in car";
            // 
            // carStuckSnow
            // 
            this.carStuckSnow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carStuckSnow.Location = new System.Drawing.Point(-5, -1);
            this.carStuckSnow.Name = "carStuckSnow";
            this.carStuckSnow.Size = new System.Drawing.Size(469, 419);
            this.carStuckSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carStuckSnow.TabIndex = 1;
            this.carStuckSnow.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(927, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.carStuckSnow);
            this.Controls.Add(this.outputLabel);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

