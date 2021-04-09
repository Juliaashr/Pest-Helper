using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pest_Helper
{
    public interface IUser : IEquatable<IUser>
    {
        string Login { get; set; }

        string Password { get; set; }

    }
}
