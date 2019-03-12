namespace Phi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CADRE));
            this.NumericRed = new System.Windows.Forms.NumericUpDown();
            this.NumericGreen = new System.Windows.Forms.NumericUpDown();
            this.NumericBlue = new System.Windows.Forms.NumericUpDown();
            this.ResultRGB = new System.Windows.Forms.PictureBox();
            this.ResultPhiRGB = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPhiRGB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumericRed
            // 
            this.NumericRed.Location = new System.Drawing.Point(12, 93);
            this.NumericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericRed.Name = "NumericRed";
            this.NumericRed.Size = new System.Drawing.Size(48, 20);
            this.NumericRed.TabIndex = 1;
            this.NumericRed.ValueChanged += new System.EventHandler(this.NumericRed_ValueChanged);
            // 
            // NumericGreen
            // 
            this.NumericGreen.Location = new System.Drawing.Point(66, 93);
            this.NumericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGreen.Name = "NumericGreen";
            this.NumericGreen.Size = new System.Drawing.Size(48, 20);
            this.NumericGreen.TabIndex = 2;
            this.NumericGreen.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // NumericBlue
            // 
            this.NumericBlue.Location = new System.Drawing.Point(120, 93);
            this.NumericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericBlue.Name = "NumericBlue";
            this.NumericBlue.Size = new System.Drawing.Size(48, 20);
            this.NumericBlue.TabIndex = 3;
            this.NumericBlue.ValueChanged += new System.EventHandler(this.NumericBlue_ValueChanged);
            // 
            // ResultRGB
            // 
            this.ResultRGB.BackColor = System.Drawing.Color.Transparent;
            this.ResultRGB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultRGB.Location = new System.Drawing.Point(12, 119);
            this.ResultRGB.Name = "ResultRGB";
            this.ResultRGB.Size = new System.Drawing.Size(156, 64);
            this.ResultRGB.TabIndex = 9;
            this.ResultRGB.TabStop = false;
            // 
            // ResultPhiRGB
            // 
            this.ResultPhiRGB.BackColor = System.Drawing.Color.Transparent;
            this.ResultPhiRGB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultPhiRGB.Location = new System.Drawing.Point(174, 119);
            this.ResultPhiRGB.Name = "ResultPhiRGB";
            this.ResultPhiRGB.Size = new System.Drawing.Size(156, 64);
            this.ResultPhiRGB.TabIndex = 8;
            this.ResultPhiRGB.TabStop = false;
            this.ResultPhiRGB.Click += new System.EventHandler(this.ResultPhiRGB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.ratioToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // ratioToolStripMenuItem
            // 
            this.ratioToolStripMenuItem.Enabled = false;
            this.ratioToolStripMenuItem.Name = "ratioToolStripMenuItem";
            this.ratioToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ratioToolStripMenuItem.Text = "Ratio";
            // 
            // CADRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.ResultPhiRGB);
            this.Controls.Add(this.ResultRGB);
            this.Controls.Add(this.NumericBlue);
            this.Controls.Add(this.NumericGreen);
            this.Controls.Add(this.NumericRed);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CADRE";
            this.Text = "Phi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPhiRGB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NumericGreen;
        private System.Windows.Forms.NumericUpDown NumericBlue;
        private System.Windows.Forms.PictureBox ResultRGB;
        private System.Windows.Forms.NumericUpDown NumericRed;
        private System.Windows.Forms.PictureBox ResultPhiRGB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratioToolStripMenuItem;
    }
}

