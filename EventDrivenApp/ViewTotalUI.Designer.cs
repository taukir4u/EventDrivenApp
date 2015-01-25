namespace EventDrivenApp
{
    partial class ViewTotalUI
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
            this.peopleInRepoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peopleInRepoLabel
            // 
            this.peopleInRepoLabel.AutoSize = true;
            this.peopleInRepoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleInRepoLabel.Location = new System.Drawing.Point(118, 41);
            this.peopleInRepoLabel.Name = "peopleInRepoLabel";
            this.peopleInRepoLabel.Size = new System.Drawing.Size(0, 55);
            this.peopleInRepoLabel.TabIndex = 0;
            // 
            // ViewTotalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 156);
            this.Controls.Add(this.peopleInRepoLabel);
            this.Name = "ViewTotalUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleInRepoLabel;
    }
}