﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentsManager.Model
{
    public class UserModel 
    {
        public string username { get; set; }

        public string password { get; set; }
    }
}
