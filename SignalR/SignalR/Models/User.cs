using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class User
    {
        public Guid userId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}