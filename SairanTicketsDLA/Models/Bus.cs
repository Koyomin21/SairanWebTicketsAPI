using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SairanTicketsDLA.Enums;

namespace SairanTicketsDLA.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public int Capacity { get; set; }
        public BusType BusType{ get; set; }
    }
}
