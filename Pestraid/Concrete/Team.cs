﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Experience { get; set; }
        public string About { get; set; }
        public string Email {  get; set; }
        public string Phone { get; set; }
        public string SosialAdress { get; set; }
        public string PhotoUrl { get; set; }

    }
}
