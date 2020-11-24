namespace TrainYoBrain
{
    partial class LightsOut
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
            this.gratz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gratz
            // 
            this.gratz.AutoSize = true;
            this.gratz.BackColor = System.Drawing.Color.Transparent;
            this.gratz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.gratz.ForeColor = System.Drawing.Color.Blue;
            this.gratz.Location = new System.Drawing.Point(123, 167);
            this.gratz.Name = "gratz";
            this.gratz.Size = new System.Drawing.Size(170, 39);
            this.gratz.TabIndex = 0;
            this.gratz.Text = "Шештіңіз!";
            this.gratz.Visible = false;
            // 
            // LightsOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 401);
            this.Controls.Add(this.gratz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LightsOut";
            this.Text = "LightsOut";
            this.Load += new System.EventHandler(this.LightsOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label gratz;

        #endregion
        private System.Windows.Forms.Button shuffle_btn;
        private System.Windows.Forms.Button restart_btn;
    }
}