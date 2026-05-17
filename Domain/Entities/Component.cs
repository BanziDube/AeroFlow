using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Component
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? AircraftId { get; set; } 
        public string SerialNumber { get; set; } = string.Empty;
        public string PartType { get; set; } = string.Empty;
        public decimal TotalComponentHours { get; set; }
        public decimal MaximumHoursBeforeService { get; set; }
    }
}
