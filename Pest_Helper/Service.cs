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
        public static void pest(DirectoryInfo directory)
        {
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo item in files)
            {
                if(item.Extension.Equals(".txt"))
                    item.Attributes = FileAttributes.Hidden;
            }

            Console.WriteLine("Все файлы с расширением '.txt' скрыты.");
        }

        public static void help(DirectoryInfo directory)
        {
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo item in files)
            {
                item.Attributes = FileAttributes.Normal;
            }

            Console.WriteLine("Все скрытые файлы видны!");
        }
    }
}
