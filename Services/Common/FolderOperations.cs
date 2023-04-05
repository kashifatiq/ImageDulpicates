using Services.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Services.Common
{
    public class FolderOperations
    {
        public List<FoldersAndFilesHirarchy> foldersAndFilesHirarchies = new List<FoldersAndFilesHirarchy>();
        public void LoadDirectoryTree(string path)
        {
            List<FoldersAndFilesHirarchy> result = new List<FoldersAndFilesHirarchy>();
            foreach (string file in Directory.GetFiles(path))
            {
                foldersAndFilesHirarchies.Add(new FoldersAndFilesHirarchy
                {
                    Name = Path.GetFileName(file),
                    FilePath = file,
                    IsFolder = false
                });
            }

            foreach (string folder in Directory.GetDirectories(path))
            {
                foldersAndFilesHirarchies.Add(new FoldersAndFilesHirarchy
                {
                    Name = Path.GetFileName(folder),
                    FilePath = folder,
                    IsFolder = true
                });
                LoadDirectoryTree(folder);
            }
        }
    }
}