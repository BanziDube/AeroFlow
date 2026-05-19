using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MaintenanceEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ComponentId { get; set; }
        public string WorkOrderNumber {  get; set; } = string.Empty;
        public DateTime CompletionDate { get; set; }
        public string MechanicLicense { get; set; } = string.Empty;

        public Component Component { get; set; }
    }
}
