﻿using ExampleofOOP.Modells.Entities.Abstract;
using ExampleofOOP.Modells.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleofOOP.Modells.Entities.Concrete
{
    public class AppUser : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }


    }
}
