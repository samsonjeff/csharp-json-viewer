using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_json_viewer
{
    internal class Users
    {
        public int id { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public Address? address { get; set; }

        public string? city => address?.city;
        public string? suite => address?.suite;
        public string? zipcode => address?.zipcode;
    }

    internal class Address {
        public string? city { get; set; }
        public string? suite { get; set; }
        public string? zipcode { get; set; }
    }
}
