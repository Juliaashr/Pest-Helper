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
        public IUser User { get; set; }

        public UsersRepository(IUser user) => User = user;

        public void Accsess(DirectoryInfo directory)
        {
            Dictionary<string, string> logPass = new Dictionary<string, string>(5);

            logPass.Add("anna2001", "qwe123qwe123");
            logPass.Add("qwerty", "123_ytrewq");
            logPass.Add("maldivi2007", "12345678");
            logPass.Add("zentrum", "AfRiKa");
            logPass.Add("ilikedogs777", "andcats");


             foreach (var item in logPass)
                if (User?.Login == item.Key && User?.Password == item.Value)
                {
                    Console.WriteLine($"Здравствуйте, {User.Login}, вы получили доступ. Нажмите 1, чтобы скрыть файлы; нажмите 2, чтобы показать скрытые файлы: ");

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
}
