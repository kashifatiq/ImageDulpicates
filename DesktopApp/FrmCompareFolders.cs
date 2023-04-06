using Services;
using Services.Common;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class FrmCompareFolders : Form
    {
        private List<string> allowedFiles = new List<string>();
        private List<string> ignoredFiles = new List<string>();

        public FrmCompareFolders()
        {
            InitializeComponent();
        }

        private void btnBrowsFolder1_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolder1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowsFolder2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                txtFolder2.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void btnFolderCompare_Click(object sender, EventArgs e)
        {
            FolderOperations folderOperations1 = new FolderOperations();
            folderOperations1.LoadDirectoryTree(txtFolder1.Text.Trim());
            foreach (FoldersAndFilesHirarchy result in folderOperations1.foldersAndFilesHirarchies)
            {
                if (allowedFiles.Contains(result.FileType.ToLower()))
                {
                    checkedListBox1.Items.Add(result.FilePath);
                }
            }

            FolderOperations folderOperations2 = new FolderOperations();
            folderOperations2.LoadDirectoryTree(txtFolder1.Text.Trim());
            foreach (FoldersAndFilesHirarchy result in folderOperations2.foldersAndFilesHirarchies)
            {

            }
        }

        private void frmFindDuplicates_Load(object sender, EventArgs e)
        {
            var config = ConfigurationManager.AppSettings["AllowedFile"];
            lblAllowedfiles.Text = lblAllowedfiles.Text + " " + config;
            allowedFiles = config.Split(',').ToList();

            var config2 = ConfigurationManager.AppSettings["IgnoredFiles"];
            lblFilesIgnored.Text = lblFilesIgnored.Text + " " + config2;
            ignoredFiles = config2.Split(',').ToList();
        }
    }
}