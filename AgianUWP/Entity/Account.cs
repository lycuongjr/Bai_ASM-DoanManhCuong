﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgianUWP.Entity
{
    class Account
    {
        
        private string _email;
        private string _password;

        
        public string email { get => _email; set => _email = value; }
        public string password { get => _password; set => _password = value; }
    }
}
