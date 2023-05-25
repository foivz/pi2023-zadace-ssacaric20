using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca3.Repositories;

namespace Zadaca3.Models
{
    public class Worker : Person
    {
        public string Cnumber { get; set; }
        public string Email { get; set; }
        public string IBAN { get; set; }
        public int Hourly { get; set; }
    }
}
