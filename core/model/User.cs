using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.core.common;

namespace TaskManager.core.model
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public Enums.Role role { get; set; }
    }
}
