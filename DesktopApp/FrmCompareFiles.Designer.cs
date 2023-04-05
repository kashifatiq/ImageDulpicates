namespace DesktopApp
{
    partial class FrmCompareFiles
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
            this.txtFilePath1 = new System.Windows.Forms.TextBox();
            this.btnLoadFile1 = new System.Windows.Forms.Button();
            this.txtFilePath2 = new System.Windows.Forms.TextBox();
            this.btnLoadFile2 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtFilePath1
            // 
            this.txtFilePath1.Location = new System.Drawing.Point(12, 12);
            this.txtFilePath1.Name = "txtFilePath1";
            this.txtFilePath1.Size = new System.Drawing.Size(639, 20);
            this.txtFilePath1.TabIndex = 3;
            // 
            // btnLoadFile1
            // 
            this.btnLoadFile1.Location = new System.Drawing.Point(657, 9);
            this.btnLoadFile1.Name = "btnLoadFile1";
            this.btnLoadFile1.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile1.TabIndex = 4;
            this.btnLoadFile1.Text = "Brows File 1";
            this.btnLoadFile1.UseVisualStyleBackColor = true;
            this.btnLoadFile1.Click += new System.EventHandler(this.btnLoadFile1_Click);
            // 
            // txtFilePath2
            // 
            this.txtFilePath2.Location = new System.Drawing.Point(12, 38);
            this.txtFilePath2.Name = "txtFilePath2";
            this.txtFilePath2.Size = new System.Drawing.Size(639, 20);
            this.txtFilePath2.TabIndex = 5;
            // 
            // btnLoadFile2
            // 
            this.btnLoadFile2.Location = new System.Drawing.Point(657, 35);
            this.btnLoadFile2.Name = "btnLoadFile2";
            this.btnLoadFile2.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile2.TabIndex = 6;
            this.btnLoadFile2.Text = "Brows File 2";
            this.btnLoadFile2.UseVisualStyleBackColor = true;
            this.btnLoadFile2.Click += new System.EventHandler(this.btnLoadFile2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(381, 80);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "label1";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(273, 75);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 7;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // frmCompareFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnLoadFile2);
            this.Controls.Add(this.txtFilePath2);
            this.Controls.Add(this.btnLoadFile1);
            this.Controls.Add(this.txtFilePath1);
            this.Name = "frmCompareFiles";
            this.Text = "compare Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath1;
        private System.Windows.Forms.Button btnLoadFile1;
        private System.Windows.Forms.TextBox txtFilePath2;
        private System.Windows.Forms.Button btnLoadFile2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}