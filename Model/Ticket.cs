using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum TicketStatus
    {
        Open,
        Resolved,
        ClosedWithoutResolve
    }
    internal class Ticket
    {
        public string Id { get; set; }  // Assuming it's a string based on the given "_id": "1".
        public DateTimeOffset DateTimeReported { get; set; }
        public string Subject { get; set; }
        public string TypeOfIncident { get; set; }
        public string ReportedByEmployeeId { get; set; }
        public string Priority { get; set; }
        public DateTimeOffset Deadline { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
