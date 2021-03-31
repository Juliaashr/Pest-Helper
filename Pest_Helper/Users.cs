using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pest_Helper
{
    class Users: IUser
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public Users(string login, string password) => (Login, Password) = (login, password);

        public void Accsess(DirectoryInfo directory)
        {
            Dictionary<string, string> logPass = new Dictionary<string, string>(5);

            logPass.Add("anna2001", "qwe123qwe123");
            logPass.Add("qwerty","123_ytrewq");
            logPass.Add("maldivi2007", "12345678");
            logPass.Add("zentrum", "AfRiKa");
            logPass.Add("ilikedogs777", "andcats");

            foreach (var item in logPass)
            {
                if(Login == item.Key && Password == item.Value)
                    FileControl(directory);
            }
        }

        public void FileControl(DirectoryInfo directory)
        {
            Console.WriteLine($"Здравствуйте, {Login}, вы получили доступ. Нажмите 1, чтобы скрыть файлы; нажмите 2, чтобы показать скрытые файлы: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Service.pest(directory);
                    break;
                case "2":
                    Service.help(directory);
                    break;
            }
        }
    }
}
