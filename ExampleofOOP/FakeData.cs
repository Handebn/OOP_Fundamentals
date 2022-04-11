using ExampleofOOP.Modells.Entities.Concrete;
using ExampleofOOP.Modells.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleofOOP
{
    public static class FakeData
    {
        public static List<AppUser> AppUsers = new List<AppUser>()
        {
            new AppUser{ Id= Guid.NewGuid(), FirstName ="Hande", LastName="Balaban", UserName="HB1001",Password ="123", Role= Role.Admin},
            new AppUser {Id=Guid.NewGuid(), FirstName="İpek",LastName="Yılmaz", UserName="IP1002",Password ="123", Role=Role.Member},
            new AppUser {Id = Guid.NewGuid(), FirstName ="Burak", LastName="Yılmaz", UserName="HY1003",Password ="123", Role = Role.Admin},
        };
    }
}
