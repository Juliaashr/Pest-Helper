﻿using System;
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

    }
}
