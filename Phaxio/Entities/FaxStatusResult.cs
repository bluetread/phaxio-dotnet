using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phaxio.Entities
{
    /// <summary>
    ///  This represents a Phaxio faxStatus result object
    /// </summary>
    public class FaxStatusResult
    {
        [DeserializeAs(Name = "id")]
        public int Id { get; set; }

        [DeserializeAs(Name = "num_pages")]
        public int NumPages { get; set; }

        [DeserializeAs(Name = "cost")]
        public int Cost { get; set; }

        [DeserializeAs(Name = "status")]
        public string Status { get; set; }

        [DeserializeAs(Name = "is_test")]
        public bool IsTest { get; set; }

        [DeserializeAs(Name = "requested_at")]
        public long RequestedAt { get; set; }

        [DeserializeAs(Name = "completed_at")]
        public long CompletedAt { get; set; }

        [DeserializeAs(Name = "recipients")]
        public List<Recipient> Recipients { get; set; }
    }
}
