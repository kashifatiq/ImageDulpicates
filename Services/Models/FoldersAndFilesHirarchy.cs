using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class FoldersAndFilesHirarchy
    {
        private string fileType;
        public string Name { get; set; }
        public string FilePath { get; set; }
        public bool IsFolder { get; set; }
        public string FileType
        {
            get { return fileType == null ? "" : fileType.Replace(".","").ToLower(); }
            set { fileType = value.ToLower(); }
        }
    }
}
