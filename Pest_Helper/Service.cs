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
        public static void FileControl(DirectoryInfo directory, string helpVal)
        {
            foreach (FileInfo item in directory.GetFiles())
            {
                switch (helpVal)
                {
                    case "1":
                        if (item.Extension.Equals(".txt"))
                            item.Attributes = FileAttributes.Hidden;

                        Console.WriteLine("Все файлы с расширением '.txt' скрыты.");

                        break;
                    case "2":

                        item.Attributes = FileAttributes.Normal;
                        Console.WriteLine("Все скрытые файлы видны!");
                        break;
                }
            }
        }
    }
}
