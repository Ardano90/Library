namespace Ardano.Library
{
    public partial class ProgressionWindowForm
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
            this.labelTaskSheet = new System.Windows.Forms.Label();
            this.labelEstimatedTime = new System.Windows.Forms.Label();
            this.labelTaskView = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBarSubtask = new System.Windows.Forms.ProgressBar();
            this.labelProgressSubtask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar.Location = new System.Drawing.Point(38, 94);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(6);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(904, 65);
            this.ProgressBar.TabIndex = 0;
            // 
            // labelTaskSheet
            // 
            this.labelTaskSheet.Location = new System.Drawing.Point(38, 54);
            this.labelTaskSheet.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTaskSheet.Name = "labelTaskSheet";
            this.labelTaskSheet.Size = new System.Drawing.Size(904, 25);
            this.labelTaskSheet.TabIndex = 2;
            this.labelTaskSheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstimatedTime
            // 
            this.labelEstimatedTime.Location = new System.Drawing.Point(38, 320);
            this.labelEstimatedTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEstimatedTime.Name = "labelEstimatedTime";
            this.labelEstimatedTime.Size = new System.Drawing.Size(904, 25);
            this.labelEstimatedTime.TabIndex = 2;
            this.labelEstimatedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaskView
            // 
            this.labelTaskView.Location = new System.Drawing.Point(38, 188);
            this.labelTaskView.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTaskView.Name = "labelTaskView";
            this.labelTaskView.Size = new System.Drawing.Size(904, 25);
            this.labelTaskView.TabIndex = 2;
            this.labelTaskView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(426, 362);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 53);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelProgress.Location = new System.Drawing.Point(459, 110);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(69, 28);
            this.labelProgress.TabIndex = 2;
            this.labelProgress.Text = "0%";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarSubtask
            // 
            this.progressBarSubtask.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarSubtask.Location = new System.Drawing.Point(38, 229);
            this.progressBarSubtask.Margin = new System.Windows.Forms.Padding(6);
            this.progressBarSubtask.Name = "progressBarSubtask";
            this.progressBarSubtask.Size = new System.Drawing.Size(904, 65);
            this.progressBarSubtask.TabIndex = 0;
            // 
            // labelProgressSubtask
            // 
            this.labelProgressSubtask.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelProgressSubtask.Location = new System.Drawing.Point(459, 245);
            this.labelProgressSubtask.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProgressSubtask.Name = "labelProgressSubtask";
            this.labelProgressSubtask.Size = new System.Drawing.Size(69, 28);
            this.labelProgressSubtask.TabIndex = 2;
            this.labelProgressSubtask.Text = "0%";
            this.labelProgressSubtask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressionWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 439);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelProgressSubtask);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelEstimatedTime);
            this.Controls.Add(this.labelTaskView);
            this.Controls.Add(this.labelTaskSheet);
            this.Controls.Add(this.progressBarSubtask);
            this.Controls.Add(this.ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProgressionWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.ProgressionbarForm_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label labelTaskSheet;
        private System.Windows.Forms.Label labelEstimatedTime;
        private System.Windows.Forms.Label labelTaskView;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBarSubtask;
        private System.Windows.Forms.Label labelProgressSubtask;
    }
}