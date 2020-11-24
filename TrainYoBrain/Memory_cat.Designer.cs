namespace TrainYoBrain
{
    partial class Memory
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
            this.proverbs_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Figures = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // proverbs_button
            // 
            this.proverbs_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.proverbs_button.Location = new System.Drawing.Point(341, 73);
            this.proverbs_button.Name = "proverbs_button";
            this.proverbs_button.Size = new System.Drawing.Size(135, 59);
            this.proverbs_button.TabIndex = 0;
            this.proverbs_button.Text = "Start \"Memorization of Proverbs\"";
            this.proverbs_button.UseVisualStyleBackColor = true;
            this.proverbs_button.Click += new System.EventHandler(this.proverbs_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.richTextBox1.Location = new System.Drawing.Point(341, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(135, 55);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Memorize proverbs, then fill in their blank parts";
            // 
            // Figures
            // 
            this.Figures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Figures.Location = new System.Drawing.Point(341, 307);
            this.Figures.Name = "Figures";
            this.Figures.Size = new System.Drawing.Size(135, 57);
            this.Figures.TabIndex = 2;
            this.Figures.Text = "Start \"Memorization of Shapes\"";
            this.Figures.UseVisualStyleBackColor = true;
            this.Figures.Click += new System.EventHandler(this.Figures_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.richTextBox2.Location = new System.Drawing.Point(341, 196);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(135, 105);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "Remember 20 shapes in 8 minutes, after 15 minutes, test yourself by finding each " +
    "one out of 5 variants";
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainYoBrain.Properties.Resources.forProject2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(524, 392);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Figures);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.proverbs_button);
            this.Name = "Memory";
            this.Text = "Category: Memory";
            this.Load += new System.EventHandler(this.Memory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button proverbs_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Button Figures;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}