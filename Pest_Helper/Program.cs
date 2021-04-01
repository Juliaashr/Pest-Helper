using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pest_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\SUBDIR";

            DirectoryInfo directory = new DirectoryInfo(path);

            if(directory.Exists)
            {
                Console.WriteLine("Введите логин и пароль: ");

                UsersRepository repository = new UsersRepository(new Users(Console.ReadLine(), Console.ReadLine()));

                repository.Accsess(directory);
            }
            else
                Console.WriteLine("Директории не существует!");

            Console.ReadKey();
        }
    }
}
