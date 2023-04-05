using Services;
using Services.Common;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                checkedListBox1.Items.Add(result.FilePath);
            }

            FolderOperations folderOperations2 = new FolderOperations();
            folderOperations2.LoadDirectoryTree(txtFolder1.Text.Trim());
            foreach (FoldersAndFilesHirarchy result in folderOperations2.foldersAndFilesHirarchies)
            {

            }
        }

        private void frmFindDuplicates_Load(object sender, EventArgs e)
        {

        }
    }
}