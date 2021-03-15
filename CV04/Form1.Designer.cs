
namespace CV04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Difficulty = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListBox.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 128;
            this.gameListBox.Location = new System.Drawing.Point(0, 0);
            this.gameListBox.MultiColumn = true;
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(732, 178);
            this.gameListBox.TabIndex = 0;
            this.gameListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameListBox_KeyDown);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.accuracyLabel,
            this.Difficulty,
            this.difficultProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 156);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(732, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(49, 17);
            this.correctLabel.Text = "Correct:";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(47, 17);
            this.missedLabel.Text = "Missed:";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(59, 17);
            this.accuracyLabel.Text = "Accuracy:";
            // 
            // Difficulty
            // 
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(460, 17);
            this.Difficulty.Spring = true;
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultProgressBar
            // 
            this.difficultProgressBar.Maximum = 800;
            this.difficultProgressBar.Name = "difficultProgressBar";
            this.difficultProgressBar.Size = new System.Drawing.Size(100, 16);
            this.difficultProgressBar.Step = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 178);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel Difficulty;
        private System.Windows.Forms.ToolStripProgressBar difficultProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

