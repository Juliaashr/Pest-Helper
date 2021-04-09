using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pest_Helper
{
    class Service
    {
        public static void FileControl(DirectoryInfo directory)
        {
            foreach (FileInfo item in directory.GetFiles())
            {
                item.Attributes = (item.Extension.Equals(".txt") && item.Attributes == FileAttributes.Normal) ? FileAttributes.Hidden : FileAttributes.Normal;

                Console.WriteLine($"Все файлы с расширением '.txt' {((item.Attributes == FileAttributes.Hidden)?"скрыты":"открыты")}");
            }
        }
    }
}
