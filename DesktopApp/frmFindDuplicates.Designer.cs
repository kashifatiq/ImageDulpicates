namespace DesktopApp
{
    partial class frmFindDuplicates
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadFile2 = new System.Windows.Forms.Button();
            this.btnLoadFile1 = new System.Windows.Forms.Button();
            this.txtFilePath1 = new System.Windows.Forms.TextBox();
            this.txtFilePath2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtFolder1 = new System.Windows.Forms.TextBox();
            this.txtFolder2 = new System.Windows.Forms.TextBox();
            this.btnBrowsFolder2 = new System.Windows.Forms.Button();
            this.btnBrowsFolder1 = new System.Windows.Forms.Button();
            this.btnFolderCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnLoadFile2
            // 
            this.btnLoadFile2.Location = new System.Drawing.Point(607, 63);
            this.btnLoadFile2.Name = "btnLoadFile2";
            this.btnLoadFile2.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile2.TabIndex = 0;
            this.btnLoadFile2.Text = "Brows File 2";
            this.btnLoadFile2.UseVisualStyleBackColor = true;
            this.btnLoadFile2.Click += new System.EventHandler(this.btnLoadFile2_Click);
            // 
            // btnLoadFile1
            // 
            this.btnLoadFile1.Location = new System.Drawing.Point(607, 34);
            this.btnLoadFile1.Name = "btnLoadFile1";
            this.btnLoadFile1.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile1.TabIndex = 1;
            this.btnLoadFile1.Text = "Brows File 1";
            this.btnLoadFile1.UseVisualStyleBackColor = true;
            this.btnLoadFile1.Click += new System.EventHandler(this.btnLoadFile1_Click);
            // 
            // txtFilePath1
            // 
            this.txtFilePath1.Location = new System.Drawing.Point(12, 37);
            this.txtFilePath1.Name = "txtFilePath1";
            this.txtFilePath1.Size = new System.Drawing.Size(566, 20);
            this.txtFilePath1.TabIndex = 2;
            // 
            // txtFilePath2
            // 
            this.txtFilePath2.Location = new System.Drawing.Point(12, 63);
            this.txtFilePath2.Name = "txtFilePath2";
            this.txtFilePath2.Size = new System.Drawing.Size(566, 20);
            this.txtFilePath2.TabIndex = 3;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(255, 89);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(363, 94);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 200);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(357, 184);
            this.checkedListBox1.TabIndex = 6;
            // 
            // txtFolder1
            // 
            this.txtFolder1.Location = new System.Drawing.Point(12, 142);
            this.txtFolder1.Name = "txtFolder1";
            this.txtFolder1.Size = new System.Drawing.Size(566, 20);
            this.txtFolder1.TabIndex = 7;
            // 
            // txtFolder2
            // 
            this.txtFolder2.Location = new System.Drawing.Point(12, 168);
            this.txtFolder2.Name = "txtFolder2";
            this.txtFolder2.Size = new System.Drawing.Size(566, 20);
            this.txtFolder2.TabIndex = 8;
            // 
            // btnBrowsFolder2
            // 
            this.btnBrowsFolder2.Location = new System.Drawing.Point(607, 168);
            this.btnBrowsFolder2.Name = "btnBrowsFolder2";
            this.btnBrowsFolder2.Size = new System.Drawing.Size(108, 23);
            this.btnBrowsFolder2.TabIndex = 9;
            this.btnBrowsFolder2.Text = "Brows Folder 2";
            this.btnBrowsFolder2.UseVisualStyleBackColor = true;
            this.btnBrowsFolder2.Click += new System.EventHandler(this.btnBrowsFolder2_Click);
            // 
            // btnBrowsFolder1
            // 
            this.btnBrowsFolder1.Location = new System.Drawing.Point(607, 139);
            this.btnBrowsFolder1.Name = "btnBrowsFolder1";
            this.btnBrowsFolder1.Size = new System.Drawing.Size(108, 23);
            this.btnBrowsFolder1.TabIndex = 10;
            this.btnBrowsFolder1.Text = "Brows Folder 1";
            this.btnBrowsFolder1.UseVisualStyleBackColor = true;
            this.btnBrowsFolder1.Click += new System.EventHandler(this.btnBrowsFolder1_Click);
            // 
            // btnFolderCompare
            // 
            this.btnFolderCompare.Location = new System.Drawing.Point(390, 200);
            this.btnFolderCompare.Name = "btnFolderCompare";
            this.btnFolderCompare.Size = new System.Drawing.Size(117, 23);
            this.btnFolderCompare.TabIndex = 11;
            this.btnFolderCompare.Text = "Compare Folders";
            this.btnFolderCompare.UseVisualStyleBackColor = true;
            this.btnFolderCompare.Click += new System.EventHandler(this.btnFolderCompare_Click);
            // 
            // frmFindDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 524);
            this.Controls.Add(this.btnFolderCompare);
            this.Controls.Add(this.btnBrowsFolder1);
            this.Controls.Add(this.btnBrowsFolder2);
            this.Controls.Add(this.txtFolder2);
            this.Controls.Add(this.txtFolder1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtFilePath2);
            this.Controls.Add(this.txtFilePath1);
            this.Controls.Add(this.btnLoadFile1);
            this.Controls.Add(this.btnLoadFile2);
            this.Name = "frmFindDuplicates";
            this.Text = "Find Duplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnLoadFile2;
        private System.Windows.Forms.Button btnLoadFile1;
        private System.Windows.Forms.TextBox txtFilePath1;
        private System.Windows.Forms.TextBox txtFilePath2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtFolder1;
        private System.Windows.Forms.TextBox txtFolder2;
        private System.Windows.Forms.Button btnBrowsFolder2;
        private System.Windows.Forms.Button btnBrowsFolder1;
        private System.Windows.Forms.Button btnFolderCompare;
    }
}

