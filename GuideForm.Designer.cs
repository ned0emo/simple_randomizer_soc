
namespace TreasuresSoC
{
    partial class GuideForm
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
            this.guideLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guideLabel
            // 
            this.guideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guideLabel.Location = new System.Drawing.Point(13, 13);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(775, 503);
            this.guideLabel.TabIndex = 0;
            this.guideLabel.Text = "label1";
            this.guideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.guideLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuideForm";
            this.Text = "Справка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label guideLabel;
    }
}