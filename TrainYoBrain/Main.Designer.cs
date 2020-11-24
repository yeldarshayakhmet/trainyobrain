namespace TrainYoBrain
{
    partial class Main
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
            this.Memory_cat_launcher = new System.Windows.Forms.Button();
            this.Speed_cat_launcher = new System.Windows.Forms.Button();
            this.Logic_cat_launcher = new System.Windows.Forms.Button();
            this.games = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Memory_cat_launcher
            // 
            this.Memory_cat_launcher.BackColor = System.Drawing.Color.Transparent;
            this.Memory_cat_launcher.FlatAppearance.BorderSize = 0;
            this.Memory_cat_launcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Memory_cat_launcher.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory_cat_launcher.ForeColor = System.Drawing.Color.Red;
            this.Memory_cat_launcher.Location = new System.Drawing.Point(398, 441);
            this.Memory_cat_launcher.Name = "Memory_cat_launcher";
            this.Memory_cat_launcher.Size = new System.Drawing.Size(91, 81);
            this.Memory_cat_launcher.TabIndex = 1;
            this.Memory_cat_launcher.UseVisualStyleBackColor = false;
            this.Memory_cat_launcher.Click += new System.EventHandler(this.Memory_cat_launcher_Click);
            // 
            // Speed_cat_launcher
            // 
            this.Speed_cat_launcher.BackColor = System.Drawing.Color.Transparent;
            this.Speed_cat_launcher.FlatAppearance.BorderSize = 0;
            this.Speed_cat_launcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Speed_cat_launcher.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_cat_launcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Speed_cat_launcher.Location = new System.Drawing.Point(38, 293);
            this.Speed_cat_launcher.Name = "Speed_cat_launcher";
            this.Speed_cat_launcher.Size = new System.Drawing.Size(95, 83);
            this.Speed_cat_launcher.TabIndex = 2;
            this.Speed_cat_launcher.UseVisualStyleBackColor = false;
            this.Speed_cat_launcher.Click += new System.EventHandler(this.Speed_cat_launcher_Click);
            // 
            // Logic_cat_launcher
            // 
            this.Logic_cat_launcher.BackColor = System.Drawing.Color.Transparent;
            this.Logic_cat_launcher.FlatAppearance.BorderSize = 0;
            this.Logic_cat_launcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logic_cat_launcher.Font = new System.Drawing.Font("Mistral", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logic_cat_launcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Logic_cat_launcher.Location = new System.Drawing.Point(422, 149);
            this.Logic_cat_launcher.Name = "Logic_cat_launcher";
            this.Logic_cat_launcher.Size = new System.Drawing.Size(91, 82);
            this.Logic_cat_launcher.TabIndex = 3;
            this.Logic_cat_launcher.UseVisualStyleBackColor = false;
            this.Logic_cat_launcher.Click += new System.EventHandler(this.Logic_cat_launcher_Click);
            // 
            // games
            // 
            this.games.BackColor = System.Drawing.Color.Transparent;
            this.games.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.games.Location = new System.Drawing.Point(148, 611);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(262, 62);
            this.games.TabIndex = 4;
            this.games.UseVisualStyleBackColor = false;
            this.games.Click += new System.EventHandler(this.games_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainYoBrain.Properties.Resources.backgr;
            this.ClientSize = new System.Drawing.Size(547, 677);
            this.Controls.Add(this.games);
            this.Controls.Add(this.Logic_cat_launcher);
            this.Controls.Add(this.Speed_cat_launcher);
            this.Controls.Add(this.Memory_cat_launcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "TrainYoBrain";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Memory_cat_launcher;
        private System.Windows.Forms.Button Speed_cat_launcher;
        private System.Windows.Forms.Button Logic_cat_launcher;
        private System.Windows.Forms.Button games;
    }
}