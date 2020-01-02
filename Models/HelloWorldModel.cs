using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class HelloWorldModel
    {
        public string message { get; set; } = "Hello World";
        public DateTime dt { get; set; } = DateTime.Now;

    }
}
