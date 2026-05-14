using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aircraft
    {
        //Access Modifier || Data Type || Column Name
        public Guid Id { get; set; } = Guid.NewGuid();
        public string RegistrationNumber { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;
        public decimal TotalAirframeHours { get; set; } 
        public int Status { get; set; } // 0: Active 1: Maintenance

       // public List<Component> Components { get; set; } = new();
    }
}
