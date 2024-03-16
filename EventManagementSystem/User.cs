﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    public abstract class User
    {
        public string Username {  get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Phone {  get; set; }

        public bool Valid { get; set; }

    }
}
