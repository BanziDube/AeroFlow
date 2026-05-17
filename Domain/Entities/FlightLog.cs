using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FlightLog
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid AircraftId { get; set; }
        public string DepartureAirport { get; set; } = string.Empty;
        public string ArrivalAirport { get; set; } = string.Empty;
        public decimal FlightDuration { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
