namespace TrainYoBrain
{
    partial class Logic_cat
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rotation = new System.Windows.Forms.Button();
            this.razvertka = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(433, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(164, 41);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Disassemble a 3D figure into a surface";
            this.richTextBox1.UseWaitCursor = true;
            // 
            // rotation
            // 
            this.rotation.BackColor = System.Drawing.Color.Red;
            this.rotation.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.rotation.Location = new System.Drawing.Point(34, 141);
            this.rotation.Name = "rotation";
            this.rotation.Size = new System.Drawing.Size(117, 56);
            this.rotation.TabIndex = 2;
            this.rotation.Text = "Start \"Block Rotation\"";
            this.rotation.UseVisualStyleBackColor = false;
            this.rotation.Click += new System.EventHandler(this.rotation_Click);
            // 
            // razvertka
            // 
            this.razvertka.BackColor = System.Drawing.Color.Gold;
            this.razvertka.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.razvertka.Location = new System.Drawing.Point(433, 248);
            this.razvertka.Name = "razvertka";
            this.razvertka.Size = new System.Drawing.Size(164, 84);
            this.razvertka.TabIndex = 3;
            this.razvertka.Text = "Start \"Disassembling Figures\"";
            this.razvertka.UseVisualStyleBackColor = false;
            this.razvertka.Click += new System.EventHandler(this.razvertka_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.richTextBox2.Location = new System.Drawing.Point(34, 78);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(117, 44);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Rotating blocks in your mind";
            // 
            // Logic_cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainYoBrain.Properties.Resources.thinkingbox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(609, 391);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.razvertka);
            this.Controls.Add(this.rotation);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Logic_cat";
            this.Text = "Category: Logic";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button rotation;
        private System.Windows.Forms.Button razvertka;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}