namespace Ardano.Library
{
    public partial class ProgressionBarForm
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelTaskSheet = new System.Windows.Forms.Label();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.labelTaskView = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar.Location = new System.Drawing.Point(38, 135);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(6);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(904, 83);
            this.ProgressBar.TabIndex = 0;
            // 
            // labelProgress
            // 
            this.labelProgress.Location = new System.Drawing.Point(441, 164);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(88, 25);
            this.labelProgress.TabIndex = 2;
            this.labelProgress.Text = "0%";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaskSheet
            // 
            this.labelTaskSheet.Location = new System.Drawing.Point(38, 54);
            this.labelTaskSheet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTaskSheet.Name = "labelTaskSheet";
            this.labelTaskSheet.Size = new System.Drawing.Size(904, 25);
            this.labelTaskSheet.TabIndex = 2;
            this.labelTaskSheet.Text = "creating sheet..";
            this.labelTaskSheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.Location = new System.Drawing.Point(33, 252);
            this.labelEstimatedTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(904, 25);
            this.labelEstimatedTime.TabIndex = 2;
            this.labelEstimatedTime.Text = "estimated time";
            this.labelEstimatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEstimatedTime.Visible = false;
            // 
            // labelTaskView
            // 
            this.labelTaskView.Location = new System.Drawing.Point(38, 90);
            this.labelTaskView.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTaskView.Name = "labelTaskView";
            this.labelTaskView.Size = new System.Drawing.Size(904, 25);
            this.labelTaskView.TabIndex = 2;
            this.labelTaskView.Text = "adding view...";
            this.labelTaskView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTaskView.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(414, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 53);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ProgressionBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 383);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelEstimatedTime);
            this.Controls.Add(this.labelTaskView);
            this.Controls.Add(this.labelTaskSheet);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.ProgressBar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProgressionBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.ProgressionbarForm_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelTaskSheet;
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.Label labelTaskView;
        private System.Windows.Forms.Button buttonCancel;
    }
}