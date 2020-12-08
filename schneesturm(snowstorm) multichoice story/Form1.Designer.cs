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
            this.outPutLabel = new System.Windows.Forms.Label();
            this.carStuckSnow = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outPutLabel
            // 
            this.outPutLabel.Font = new System.Drawing.Font("Normande BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPutLabel.Location = new System.Drawing.Point(522, 35);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(275, 23);
            this.outPutLabel.TabIndex = 0;
            this.outPutLabel.Text = "welcome to snowstorm";
            // 
            // carStuckSnow
            // 
            this.carStuckSnow.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.car_stuck_in_snow;
            this.carStuckSnow.Location = new System.Drawing.Point(-2, 35);
            this.carStuckSnow.Name = "carStuckSnow";
            this.carStuckSnow.Size = new System.Drawing.Size(518, 403);
            this.carStuckSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carStuckSnow.TabIndex = 1;
            this.carStuckSnow.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(522, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.carStuckSnow);
            this.Controls.Add(this.outPutLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.PictureBox carStuckSnow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

