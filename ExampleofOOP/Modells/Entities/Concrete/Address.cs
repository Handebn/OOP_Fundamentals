using ExampleofOOP.Modells.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleofOOP.Modells.Entities.Concrete
{
    public class Address : BaseEntity<int>
    {
        public override int Id { get; set; }

        public string City { get; set; }
        public string Region { get; set; }
    }
}
