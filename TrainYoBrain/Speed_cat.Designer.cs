namespace TrainYoBrain
{
    partial class Speed_cat
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
            this.speed_game_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // speed_game_button
            // 
            this.speed_game_button.BackColor = System.Drawing.Color.AliceBlue;
            this.speed_game_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_game_button.Location = new System.Drawing.Point(261, 362);
            this.speed_game_button.Name = "speed_game_button";
            this.speed_game_button.Size = new System.Drawing.Size(128, 44);
            this.speed_game_button.TabIndex = 0;
            this.speed_game_button.Text = "Start";
            this.speed_game_button.UseVisualStyleBackColor = false;
            this.speed_game_button.Click += new System.EventHandler(this.speed_game_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.richTextBox1.Location = new System.Drawing.Point(252, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(188, 111);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Solve math problems on either right and left sides to decide which one results in" +
    " a greater value";
            // 
            // Speed_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainYoBrain.Properties.Resources.newsletter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 418);
            this.Controls.Add(this.speed_game_button);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Speed_cat";
            this.Text = "Category: Speed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button speed_game_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}