﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Assessment_System.Models
{
    public class SuperPasswordModel
    {
        public string adminId { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
    }
}
