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
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.carStuckSnow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Normande BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(487, 243);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(311, 198);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "snowstorm                       You wake up in a snow storm you decide to ";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Normande BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.blue_50x50;
            this.blueLabel.Location = new System.Drawing.Point(486, 9);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(124, 201);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "Press m to leave car";
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Normande BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.red_50x50;
            this.redLabel.Location = new System.Drawing.Point(627, 9);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(171, 201);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "press n to stay in car";
            // 
            // carStuckSnow
            // 
            this.carStuckSnow.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.car_stuck_in_snow;
            this.carStuckSnow.Location = new System.Drawing.Point(-54, -30);
            this.carStuckSnow.Name = "carStuckSnow";
            this.carStuckSnow.Size = new System.Drawing.Size(518, 489);
            this.carStuckSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carStuckSnow.TabIndex = 1;
            this.carStuckSnow.TabStop = false;
            this.carStuckSnow.Click += new System.EventHandler(this.CarStuckSnow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

