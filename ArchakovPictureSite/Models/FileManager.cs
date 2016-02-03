using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;

namespace ArchakovPictureSite.Models
{
    public class FileManager
    {
        public FileInfo[] GetFiles(string directoryPath)
        {
            return new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + directoryPath).GetFiles();
        }
    }
}