namespace DesktopApp
{
    partial class FrmCompareFolders
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtFolder1 = new System.Windows.Forms.TextBox();
            this.txtFolder2 = new System.Windows.Forms.TextBox();
            this.btnBrowsFolder2 = new System.Windows.Forms.Button();
            this.btnBrowsFolder1 = new System.Windows.Forms.Button();
            this.btnFolderCompare = new System.Windows.Forms.Button();
            this.lblAllowedfiles = new System.Windows.Forms.Label();
            this.lblFilesIgnored = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 123);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(780, 214);
            this.checkedListBox1.TabIndex = 6;
            // 
            // txtFolder1
            // 
            this.txtFolder1.Location = new System.Drawing.Point(12, 17);
            this.txtFolder1.Name = "txtFolder1";
            this.txtFolder1.Size = new System.Drawing.Size(666, 20);
            this.txtFolder1.TabIndex = 7;
            // 
            // txtFolder2
            // 
            this.txtFolder2.Location = new System.Drawing.Point(12, 43);
            this.txtFolder2.Name = "txtFolder2";
            this.txtFolder2.Size = new System.Drawing.Size(666, 20);
            this.txtFolder2.TabIndex = 8;
            // 
            // btnBrowsFolder2
            // 
            this.btnBrowsFolder2.Location = new System.Drawing.Point(684, 46);
            this.btnBrowsFolder2.Name = "btnBrowsFolder2";
            this.btnBrowsFolder2.Size = new System.Drawing.Size(108, 23);
            this.btnBrowsFolder2.TabIndex = 9;
            this.btnBrowsFolder2.Text = "Brows Folder 2";
            this.btnBrowsFolder2.UseVisualStyleBackColor = true;
            this.btnBrowsFolder2.Click += new System.EventHandler(this.btnBrowsFolder2_Click);
            // 
            // btnBrowsFolder1
            // 
            this.btnBrowsFolder1.Location = new System.Drawing.Point(684, 17);
            this.btnBrowsFolder1.Name = "btnBrowsFolder1";
            this.btnBrowsFolder1.Size = new System.Drawing.Size(108, 23);
            this.btnBrowsFolder1.TabIndex = 10;
            this.btnBrowsFolder1.Text = "Brows Folder 1";
            this.btnBrowsFolder1.UseVisualStyleBackColor = true;
            this.btnBrowsFolder1.Click += new System.EventHandler(this.btnBrowsFolder1_Click);
            // 
            // btnFolderCompare
            // 
            this.btnFolderCompare.Location = new System.Drawing.Point(561, 70);
            this.btnFolderCompare.Name = "btnFolderCompare";
            this.btnFolderCompare.Size = new System.Drawing.Size(117, 23);
            this.btnFolderCompare.TabIndex = 11;
            this.btnFolderCompare.Text = "Compare Folders";
            this.btnFolderCompare.UseVisualStyleBackColor = true;
            this.btnFolderCompare.Click += new System.EventHandler(this.btnFolderCompare_Click);
            // 
            // lblAllowedfiles
            // 
            this.lblAllowedfiles.AutoSize = true;
            this.lblAllowedfiles.Location = new System.Drawing.Point(12, 75);
            this.lblAllowedfiles.Name = "lblAllowedfiles";
            this.lblAllowedfiles.Size = new System.Drawing.Size(74, 13);
            this.lblAllowedfiles.TabIndex = 12;
            this.lblAllowedfiles.Text = "Files Allowed :";
            // 
            // lblFilesIgnored
            // 
            this.lblFilesIgnored.AutoSize = true;
            this.lblFilesIgnored.Location = new System.Drawing.Point(12, 97);
            this.lblFilesIgnored.Name = "lblFilesIgnored";
            this.lblFilesIgnored.Size = new System.Drawing.Size(73, 13);
            this.lblFilesIgnored.TabIndex = 13;
            this.lblFilesIgnored.Text = "Files Ignored :";
            // 
            // FrmCompareFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 524);
            this.Controls.Add(this.lblFilesIgnored);
            this.Controls.Add(this.lblAllowedfiles);
            this.Controls.Add(this.btnFolderCompare);
            this.Controls.Add(this.btnBrowsFolder1);
            this.Controls.Add(this.btnBrowsFolder2);
            this.Controls.Add(this.txtFolder2);
            this.Controls.Add(this.txtFolder1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "FrmCompareFolders";
            this.Text = "Find Duplicates";
            this.Load += new System.EventHandler(this.frmFindDuplicates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtFolder1;
        private System.Windows.Forms.TextBox txtFolder2;
        private System.Windows.Forms.Button btnBrowsFolder2;
        private System.Windows.Forms.Button btnBrowsFolder1;
        private System.Windows.Forms.Button btnFolderCompare;
        private System.Windows.Forms.Label lblAllowedfiles;
        private System.Windows.Forms.Label lblFilesIgnored;
    }
}

