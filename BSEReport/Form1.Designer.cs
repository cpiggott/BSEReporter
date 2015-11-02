namespace BSEReport
{
    partial class Form1
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
            this.uxInfoLabel = new System.Windows.Forms.Label();
            this.uxButtonAggregateData = new System.Windows.Forms.Button();
            this.uxButtonGenerateReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxInfoLabel
            // 
            this.uxInfoLabel.AutoSize = true;
            this.uxInfoLabel.Location = new System.Drawing.Point(13, 13);
            this.uxInfoLabel.Name = "uxInfoLabel";
            this.uxInfoLabel.Size = new System.Drawing.Size(215, 13);
            this.uxInfoLabel.TabIndex = 0;
            this.uxInfoLabel.Text = "Please select from one of the options below:";
            // 
            // uxButtonAggregateData
            // 
            this.uxButtonAggregateData.Location = new System.Drawing.Point(50, 150);
            this.uxButtonAggregateData.Name = "uxButtonAggregateData";
            this.uxButtonAggregateData.Size = new System.Drawing.Size(160, 60);
            this.uxButtonAggregateData.TabIndex = 1;
            this.uxButtonAggregateData.Text = "Aggregate Data";
            this.uxButtonAggregateData.UseVisualStyleBackColor = true;
            this.uxButtonAggregateData.Click += new System.EventHandler(this.uxButtonAggregateData_Click);
            // 
            // uxButtonGenerateReports
            // 
            this.uxButtonGenerateReports.Location = new System.Drawing.Point(350, 150);
            this.uxButtonGenerateReports.Name = "uxButtonGenerateReports";
            this.uxButtonGenerateReports.Size = new System.Drawing.Size(160, 60);
            this.uxButtonGenerateReports.TabIndex = 2;
            this.uxButtonGenerateReports.Text = "Generate Reports";
            this.uxButtonGenerateReports.UseVisualStyleBackColor = true;
            this.uxButtonGenerateReports.Click += new System.EventHandler(this.uxButtonGenerateReports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.uxButtonGenerateReports);
            this.Controls.Add(this.uxButtonAggregateData);
            this.Controls.Add(this.uxInfoLabel);
            this.Name = "Form1";
            this.Text = "BSE Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInfoLabel;
        private System.Windows.Forms.Button uxButtonAggregateData;
        private System.Windows.Forms.Button uxButtonGenerateReports;
    }
}

