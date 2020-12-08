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
            this.startButton = new System.Windows.Forms.Button();
            this.carStuckSnow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).BeginInit();
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
            // startButton
            // 
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Image = global::schneesturm_snowstorm__multichoice_story.Properties.Resources.red_button;
            this.startButton.Location = new System.Drawing.Point(591, 128);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(72, 41);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.carStuckSnow);
            this.Controls.Add(this.outPutLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carStuckSnow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.PictureBox carStuckSnow;
        private System.Windows.Forms.Button startButton;
    }
}

