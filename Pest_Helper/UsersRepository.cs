using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pest_Helper
{
    class UsersRepository
    {
        public static void Accsess(DirectoryInfo directory, Users user)
        {
            Dictionary<string, string> logPass = new Dictionary<string, string>(5);

            logPass.Add("anna2001", "qwe123qwe123");
            logPass.Add("qwerty", "123_ytrewq");
            logPass.Add("maldivi2007", "12345678");
            logPass.Add("zentrum", "AfRiKa");
            logPass.Add("ilikedogs777", "andcats");

            if(logPass != null)
                foreach (var item in logPass)
                        if (user?.Login == item.Key && user?.Password == item.Value)
                            FileControl(directory, user);
            else
                 Console.WriteLine("Пользователей с доступом не существует!");
        }

        public static void FileControl(DirectoryInfo directory, Users user)
        {
            Console.WriteLine($"Здравствуйте, {user.Login}, вы получили доступ. Нажмите 1, чтобы скрыть файлы; нажмите 2, чтобы показать скрытые файлы: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Service.Pest(directory);
                    break;
                case "2":
                    Service.Help(directory);
                    break;
            }
        }
    }
}
