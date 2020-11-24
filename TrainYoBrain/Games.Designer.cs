namespace TrainYoBrain
{
    partial class Games
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
            this.Slide = new System.Windows.Forms.Button();
            this.HanoiTowers = new System.Windows.Forms.Button();
            this.Lightsout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Slide
            // 
            this.Slide.BackColor = System.Drawing.Color.Transparent;
            this.Slide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Slide.Location = new System.Drawing.Point(56, 264);
            this.Slide.Name = "Slide";
            this.Slide.Size = new System.Drawing.Size(91, 95);
            this.Slide.TabIndex = 0;
            this.Slide.UseVisualStyleBackColor = false;
            this.Slide.Click += new System.EventHandler(this.Slide_Click);
            // 
            // HanoiTowers
            // 
            this.HanoiTowers.BackColor = System.Drawing.Color.Transparent;
            this.HanoiTowers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HanoiTowers.Location = new System.Drawing.Point(188, 264);
            this.HanoiTowers.Name = "HanoiTowers";
            this.HanoiTowers.Size = new System.Drawing.Size(171, 95);
            this.HanoiTowers.TabIndex = 1;
            this.HanoiTowers.UseVisualStyleBackColor = false;
            this.HanoiTowers.Click += new System.EventHandler(this.HanoiTowers_Click);
            // 
            // Lightsout
            // 
            this.Lightsout.BackColor = System.Drawing.Color.Transparent;
            this.Lightsout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lightsout.Location = new System.Drawing.Point(397, 264);
            this.Lightsout.Name = "Lightsout";
            this.Lightsout.Size = new System.Drawing.Size(91, 95);
            this.Lightsout.TabIndex = 2;
            this.Lightsout.UseVisualStyleBackColor = false;
            this.Lightsout.Click += new System.EventHandler(this.Lightsout_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainYoBrain.Properties.Resources.backgr2;
            this.ClientSize = new System.Drawing.Size(543, 371);
            this.Controls.Add(this.Lightsout);
            this.Controls.Add(this.HanoiTowers);
            this.Controls.Add(this.Slide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Games";
            this.Text = "Games";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Slide;
        private System.Windows.Forms.Button HanoiTowers;
        private System.Windows.Forms.Button Lightsout;
    }
}