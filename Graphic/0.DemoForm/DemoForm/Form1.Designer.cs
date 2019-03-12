namespace DemoForm
{
    partial class CADRE
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
            this.LeButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ClickMe = new System.Windows.Forms.Button();
            this.ButtonBGcolor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeButton
            // 
            this.LeButton.Location = new System.Drawing.Point(12, 226);
            this.LeButton.Name = "LeButton";
            this.LeButton.Size = new System.Drawing.Size(75, 23);
            this.LeButton.TabIndex = 0;
            this.LeButton.Text = "Le Button";
            this.LeButton.UseVisualStyleBackColor = true;
            this.LeButton.Click += new System.EventHandler(this.LeButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::DemoForm.Properties.Resources.Capture;
            this.pictureBox.Location = new System.Drawing.Point(151, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(121, 104);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ClickMe
            // 
            this.ClickMe.Location = new System.Drawing.Point(93, 226);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(75, 23);
            this.ClickMe.TabIndex = 1;
            this.ClickMe.Text = "Clicke me !";
            this.ClickMe.UseVisualStyleBackColor = true;
            this.ClickMe.Click += new System.EventHandler(this.ClickMe_Click);
            // 
            // ButtonBGcolor
            // 
            this.ButtonBGcolor.Location = new System.Drawing.Point(197, 226);
            this.ButtonBGcolor.Name = "ButtonBGcolor";
            this.ButtonBGcolor.Size = new System.Drawing.Size(75, 23);
            this.ButtonBGcolor.TabIndex = 3;
            this.ButtonBGcolor.Text = "Background";
            this.ButtonBGcolor.UseVisualStyleBackColor = true;
            this.ButtonBGcolor.Click += new System.EventHandler(this.ButtonBGcolor_Click);
            // 
            // CADRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonBGcolor);
            this.Controls.Add(this.ClickMe);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.LeButton);
            this.Name = "CADRE";
            this.Text = "Caption";
            this.Load += new System.EventHandler(this.CADRE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LeButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ClickMe;
        private System.Windows.Forms.Button ButtonBGcolor;
    }
}

