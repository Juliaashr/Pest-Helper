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
        public static void Pest(DirectoryInfo directory)
        {
            foreach (FileInfo item in directory.GetFiles())
            {
                if(item.Extension.Equals(".txt"))
                    item.Attributes = FileAttributes.Hidden;
            }

            Console.WriteLine("Все файлы с расширением '.txt' скрыты.");
        }

        public static void Help(DirectoryInfo directory)
        {
            foreach (FileInfo item in directory.GetFiles())
            {
                item.Attributes = FileAttributes.Normal;
            }

            Console.WriteLine("Все скрытые файлы видны!");
        }
    }
}
