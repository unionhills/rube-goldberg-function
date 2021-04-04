using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubeGoldbergFunction.Core.Entities
{
    public class Note
    {
        public Note()
        {
            Trace = new List<String>();
        }

        public String Id { get; set; }

        public String Subject { get; set; }
        public String Body { get; set; }
        public String CorrelationId { get; set; }
        public List<String> Trace { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
