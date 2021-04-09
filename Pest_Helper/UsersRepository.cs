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
        public IUser[] Users { get; set; }

        public UsersRepository()
        { 
            Users = new Users [] { new Users("anna2001", "qwe123qwe123"), 
                     new Users("qwerty", "123_ytrewq"), 
                     new Users("maldivi2007", "12345678"), 
                     new Users("zentrum", "AfRiKa"), 
                     new Users("ilikedogs777", "andcats")};
        }

        public void Accsess(DirectoryInfo directory, IUser user)
        {
            foreach (var item in Users)
                if (user.Equals(item))
                {
                    Console.WriteLine($"Здравствуйте, {user.Login}, вы получили доступ. Нажмите 1, чтобы скрыть файлы; нажмите 2, чтобы показать скрытые файлы: ");
                    Service.FileControl(directory);
                }
        }

    }
}
