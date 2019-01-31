using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenga.Models
{
    public class Broker
    {
        public int idBroker { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string mail { get; set; }
        public string phoneNumber { get; set; }
    }
}