namespace BSEReport
{
    partial class FormAggregateData
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxButtonSelectFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxButtonSave = new System.Windows.Forms.Button();
            this.uxLabelFile = new System.Windows.Forms.Label();
            this.uxLabelFileLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "CSV files(*.csv; *.CSV) | *.csv; *.CSV ";
            this.openFileDialog.Multiselect = true;
            // 
            // uxButtonSelectFiles
            // 
            this.uxButtonSelectFiles.Location = new System.Drawing.Point(16, 67);
            this.uxButtonSelectFiles.Name = "uxButtonSelectFiles";
            this.uxButtonSelectFiles.Size = new System.Drawing.Size(264, 40);
            this.uxButtonSelectFiles.TabIndex = 0;
            this.uxButtonSelectFiles.Text = "Select Files";
            this.uxButtonSelectFiles.UseVisualStyleBackColor = true;
            this.uxButtonSelectFiles.Click += new System.EventHandler(this.uxButtonSelectFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select .CSV Files that you would like to merge together:";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(287, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(285, 304);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "1. Select file you would like to merge:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2. Select a location to save your merged file:";
            // 
            // uxButtonSave
            // 
            this.uxButtonSave.Location = new System.Drawing.Point(15, 170);
            this.uxButtonSave.Name = "uxButtonSave";
            this.uxButtonSave.Size = new System.Drawing.Size(264, 40);
            this.uxButtonSave.TabIndex = 5;
            this.uxButtonSave.Text = "Save File Location";
            this.uxButtonSave.UseVisualStyleBackColor = true;
            this.uxButtonSave.Click += new System.EventHandler(this.uxButtonSave_Click);
            // 
            // uxLabelFile
            // 
            this.uxLabelFile.AutoSize = true;
            this.uxLabelFile.Location = new System.Drawing.Point(13, 145);
            this.uxLabelFile.Name = "uxLabelFile";
            this.uxLabelFile.Size = new System.Drawing.Size(29, 13);
            this.uxLabelFile.TabIndex = 6;
            this.uxLabelFile.Text = "File: ";
            // 
            // uxLabelFileLocation
            // 
            this.uxLabelFileLocation.AutoSize = true;
            this.uxLabelFileLocation.Location = new System.Drawing.Point(38, 145);
            this.uxLabelFileLocation.Name = "uxLabelFileLocation";
            this.uxLabelFileLocation.Size = new System.Drawing.Size(0, 13);
            this.uxLabelFileLocation.TabIndex = 7;
            // 
            // FormAggregateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.uxLabelFileLocation);
            this.Controls.Add(this.uxLabelFile);
            this.Controls.Add(this.uxButtonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxButtonSelectFiles);
            this.Name = "FormAggregateData";
            this.Text = "FormAggregateData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button uxButtonSelectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxButtonSave;
        private System.Windows.Forms.Label uxLabelFile;
        private System.Windows.Forms.Label uxLabelFileLocation;
    }
}